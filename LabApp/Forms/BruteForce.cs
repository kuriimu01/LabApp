using LabApp.Security;
using LabApp.TBD_But;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp.Forms
{
    public partial class BruteForce : Form
    {
        public BruteForce()
        {
            InitializeComponent();
        }

        private void BtnCalculateTime_Click(object sender, EventArgs e)
        {
            var config = GetConfigFromUI();

            double myCpuSpeed = 2000.0;

            string estimated = BruteForceService.CalculateEstimatedTime(config, myCpuSpeed);
            LblEstimatedTime.Text = $"Теоретичний час: {estimated}";
        }

        private async void BtnStartBruteForce_Click(object sender, EventArgs e)
        {
            if (UserComboBox.SelectedItem == null)
            {
                MessageBox.Show("Оберіть користувача!");
                return;
            }

            UserModel targetUser = (UserModel)UserComboBox.SelectedItem;
            BruteForceConfig config = GetConfigFromUI();

            // Блокуємо кнопки, щоб не запустити два процеси одночасно
            BtnStartBruteForce.Enabled = false;
            BtnCalculateTime.Enabled = false;

            LblResult.Text = "Статус: Перебір триває, зачекайте...";
            LblTimeElapsed.Text = "Витрачено часу: 00:00:00";
            LblAttempts.Text = "Кількість спроб: рахуємо...";

            try
            {
                // Запускаємо важкий процес у фоновому потоці (Task.Run), 
                // щоб форма не зависла (не писала "Not Responding")
                var result = await Task.Run(() =>
                {
                    bool isFound = BruteForceService.TryBruteForce(
                        targetUser,
                        config,
                        out string password,
                        out TimeSpan timeElapsed,
                        out long attemptsCount);

                    // Повертаємо об'єкт з результатами з фонового потоку
                    return new
                    {
                        Found = isFound,
                        Password = password,
                        Time = timeElapsed,
                        Attempts = attemptsCount
                    };
                });

                // Коли фоновий потік завершився, виводимо результати на форму
                if (result.Found)
                {
                    LblResult.Text = $"Статус: ПАРОЛЬ ЗНАЙДЕНО! -> {result.Password}";
                    LblResult.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    LblResult.Text = "Статус: Пароль не знайдено в заданому діапазоні.";
                    LblResult.ForeColor = System.Drawing.Color.Red;
                }

                LblTimeElapsed.Text = $"Витрачено часу: {result.Time.Hours:D2}:{result.Time.Minutes:D2}:{result.Time.Seconds:D2}.{result.Time.Milliseconds:D3}";
                LblAttempts.Text = $"Кількість спроб: {result.Attempts:N0}"; // N0 додасть пробіли між тисячами
            }
            finally
            {
                // Розблоковуємо кнопки незалежно від того, успішно чи помилка
                BtnStartBruteForce.Enabled = true;
                BtnCalculateTime.Enabled = true;
            }
        }

        private void BruteForce_Load(object sender, EventArgs e)
        {
            var users = DbDataAccess.LoadUsers();
            UserComboBox.DataSource = users;
            UserComboBox.DisplayMember = "Username"; 
            UserComboBox.ValueMember = "Id";         
        }
        private BruteForceConfig GetConfigFromUI()
        {
            return new BruteForceConfig
            {
                MinLength = (int)MinLengthNum.Value,
                MaxLength = (int)MaxLengthNum.Value,
                UseLatinLower = ChbLatinLower.Checked,
                UseLatinUpper = ChbLatinUpper.Checked,
                UseDigits = ChbDigits.Checked,
                UseSpecial = ChbSpecial.Checked,
                UseCyrillicLower = ChbCyrillic.Checked
            };
        }

    }
}
