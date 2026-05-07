using LabApp.TBD_But;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace LabApp.Security
{
    public class BruteForceConfig
    {
        public int MinLength { get; set; } = 1;
        public int MaxLength { get; set; } = 4;
        public bool UseLatinLower { get; set; } = true;
        public bool UseLatinUpper { get; set; } = false;
        public bool UseDigits { get; set; } = false;
        public bool UseSpecial { get; set; } = false;
        public bool UseCyrillicLower { get; set; } = false;
    }

    public static class BruteForceService
    {
        private const string LatinLower = "abcdefghijklmnopqrstuvwxyz";
        private const string LatinUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Digits = "0123456789";
        private const string Special = "!@#$%^&*()_+-=[]{}|;':\",./<>?";
        private const string CyrillicLower = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

        public static string GetAlphabet(BruteForceConfig config)
        {
            string alphabet = "";
            if (config.UseLatinLower) alphabet += LatinLower;
            if (config.UseLatinUpper) alphabet += LatinUpper;
            if (config.UseDigits) alphabet += Digits;
            if (config.UseSpecial) alphabet += Special;
            if (config.UseCyrillicLower) alphabet += CyrillicLower;

            return string.IsNullOrEmpty(alphabet) ? LatinLower : alphabet;
        }

        public static string CalculateEstimatedTime(BruteForceConfig config, double hashesPerSecond = 100000.0)
        {
            string alphabet = GetAlphabet(config);
            if (string.IsNullOrEmpty(alphabet)) return "Оберіть хоча б один набір символів!";

            int alphabetSize = alphabet.Length;
            double totalCombinations = 0;

            for (int length = config.MinLength; length <= config.MaxLength; length++)
            {
                totalCombinations += Math.Pow(alphabetSize, length);
            }

            double secondsRequired = totalCombinations / hashesPerSecond;
            TimeSpan time = TimeSpan.FromSeconds(secondsRequired);

            if (time.TotalDays > 365)
                return $"{(time.TotalDays / 365):F2} років (Комбінацій: {totalCombinations:N0})";
            if (time.TotalDays > 1)
                return $"{time.TotalDays:F2} днів (Комбінацій: {totalCombinations:N0})";

            return $"{time.Hours} год, {time.Minutes} хв, {time.Seconds} сек (Комбінацій: {totalCombinations:N0})";
        }

        public static bool TryBruteForce(UserModel targetUser, BruteForceConfig config, out string foundPassword, out TimeSpan timeElapsed, out long attempts)
        {
            foundPassword = null;
            timeElapsed = TimeSpan.Zero;
            attempts = 0;

            string alphabet = GetAlphabet(config);
            if (string.IsNullOrEmpty(alphabet)) return false;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            string targetHash = targetUser.PasswordHash;

            // Змінні для потокобезпечного збереження результатів з різних ядер процесора
            string syncFoundPassword = null;
            long syncAttempts = 0;

            for (int length = config.MinLength; length <= config.MaxLength; length++)
            {
                // Якщо пароль вже знайдено на попередній довжині - зупиняємо цикл
                if (syncFoundPassword != null) break;

                int currentLength = length;

                // Якщо довжина 1, перебираємо без рекурсії
                if (currentLength == 1)
                {
                    Parallel.For(0, alphabet.Length, (i, state) =>
                    {
                        Interlocked.Increment(ref syncAttempts); // Безпечне збільшення лічильника
                        string attempt = alphabet[i].ToString();

                        if (PasswordService.VerifyPassword(attempt, targetHash))
                        {
                            syncFoundPassword = attempt;
                            state.Stop(); // Даємо команду іншим ядрам припинити роботу
                        }
                    });
                }
                else
                {
                    // БАГАТОПОТОКОВІСТЬ: Розкидаємо перший символ алфавіту по різних ядрах
                    Parallel.For(0, alphabet.Length, (i, state) =>
                    {
                        // Кожен потік створює власний масив символів і лічильник
                        char[] localGuess = new char[currentLength];
                        localGuess[0] = alphabet[i];
                        long localAttempts = 0;

                        // Запускаємо рекурсію з другої позиції (індекс 1)
                        if (GenerateAndCheck(targetHash, localGuess, 1, alphabet, ref localAttempts, state))
                        {
                            syncFoundPassword = new string(localGuess);
                        }

                        // Безпечно додаємо спроби цього потоку до загального лічильника
                        Interlocked.Add(ref syncAttempts, localAttempts);
                    });
                }
            }

            sw.Stop();
            timeElapsed = sw.Elapsed;
            attempts = syncAttempts;

            if (syncFoundPassword != null)
            {
                foundPassword = syncFoundPassword;
                return true;
            }

            return false;
        }

        // Рекурсивний метод, який працює всередині кожного окремого потоку
        private static bool GenerateAndCheck(string targetHash, char[] currentGuess, int position, string alphabet, ref long localAttempts, ParallelLoopState state)
        {
            // Якщо якесь інше ядро процесора вже знайшло пароль - зупиняємо цю гілку
            if (state.IsStopped) return false;

            if (position == currentGuess.Length)
            {
                localAttempts++;
                string passwordAttempt = new string(currentGuess);

                if (PasswordService.VerifyPassword(passwordAttempt, targetHash))
                {
                    state.Stop(); // Сигнал всім іншим ядрам негайно зупинитися
                    return true;
                }
                return false;
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                // Додаткова перевірка, щоб не робити зайву роботу, якщо пароль вже знайдено
                if (state.IsStopped) break;

                currentGuess[position] = alphabet[i];
                if (GenerateAndCheck(targetHash, currentGuess, position + 1, alphabet, ref localAttempts, state))
                {
                    return true;
                }
            }
            return false;
        }
    }
}