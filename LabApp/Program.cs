using LabApp.Forms; // Переконайтеся, що тут вказано правильний шлях до ChooseModel
using System;
using System.IO;
using System.Windows.Forms;

namespace LabApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Глобальне перехоплення помилок (запобігає "тихим вильотам")
            Application.ThreadException += (s, e) =>
                MessageBox.Show(e.Exception.Message, "Критична помилка UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                MessageBox.Show(e.ExceptionObject.ToString(), "Критична помилка домену", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // 2. АВТОМАТИЧНЕ ОЧИЩЕННЯ БІОМЕТРИЧНОЇ БАЗИ ПРИ СТАРТІ
            // Це гарантує відсутність зависань через пошкоджений файл моделі
            string modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TrainedFaceModel.yaml");
            try
            {
                if (File.Exists(modelPath))
                {
                    File.Delete(modelPath);
                }
            }
            catch
            {
                // Ігноруємо винятки, якщо файл тимчасово заблокований системою
            }

            // 3. Запуск головної форми
            Application.Run(new ChooseModel());
        }
    }
}