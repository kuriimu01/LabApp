using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace LabApp.Security
{
    public static class BiometricService
    {
        private static LBPHFaceRecognizer _recognizer;
        private static CascadeClassifier _faceDetector;
        private const string CascadeFile = "haarcascade_frontalface_default.xml";
        private const string ModelFile = "TrainedFaceModel.yaml";

        public static bool IsModelTrained { get; private set; }

        static BiometricService()
        {
            _recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100);

            if (File.Exists(CascadeFile))
                _faceDetector = new CascadeClassifier(CascadeFile);
            else
                throw new FileNotFoundException($"Не знайдено файл каскаду: {CascadeFile}");

            // БЕЗПЕЧНЕ ЧИТАННЯ МОДЕЛІ
            if (File.Exists(ModelFile))
            {
                try
                {
                    _recognizer.Read(ModelFile);
                    IsModelTrained = true;
                }
                catch (Exception ex)
                {
                    // Якщо файл пошкоджено (ofs == fs_data_blksz), ловимо помилку
                    System.Windows.Forms.MessageBox.Show(
                        "Файл біометричної моделі був пошкоджений і його було автоматично видалено для уникнення збоїв.\nБудь ласка, зареєструйте своє обличчя наново.",
                        "Увага: Пошкодження бази",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);

                    // Видаляємо зламаний файл
                    try { File.Delete(ModelFile); } catch { }

                    IsModelTrained = false;
                }
            }
        }

        // Знаходження обличчя на кадрі
        public static Rectangle[] DetectFaces(Image<Gray, byte> grayImage)
        {
            return _faceDetector.DetectMultiScale(grayImage, 1.2, 5, Size.Empty, Size.Empty);
        }

        // Навчання моделі для нового користувача
        // У реальній системі userId береться з UserModel.Id, а зображення зберігаються в БД або ФС
        public static void TrainModel(int userId, List<Image<Gray, byte>> userFaces)
        {
            // LBPH (Local Binary Patterns Histograms) використовує цілі числа як мітки (Labels)
            // Кожне зображення обличчя маркується ідентифікатором userId
            using (VectorOfMat mats = new VectorOfMat())
            using (VectorOfInt labels = new VectorOfInt())
            {
                foreach (var face in userFaces)
                {
                    mats.Push(face.Mat);
                    labels.Push(new int[] { userId });
                }

                // Якщо файл моделі вже існує, додаємо нові дані (Update), 
                // якщо ні — створюємо нову модель (Train).
                if (File.Exists(ModelFile))
                {
                    _recognizer.Read(ModelFile);
                    _recognizer.Update(mats, labels);
                }
                else
                {
                    _recognizer.Train(mats, labels);
                }

                // Збереження навченої моделі у файл .yaml
                _recognizer.Write(ModelFile);
                IsModelTrained = true;
            }
        }

        public static FaceRecognizer.PredictionResult PredictUser(Image<Gray, byte> faceImage)
        {
            // Initialize(); <--- Цей рядок видалено, він більше не потрібен

            if (!IsModelTrained)
                return new FaceRecognizer.PredictionResult { Label = -1, Distance = double.MaxValue };

            try
            {
                CvInvoke.Resize(faceImage, faceImage, new Size(100, 100));
                var result = _recognizer.Predict(faceImage);

                // ПЕРЕВІРКА НА "СМІТТЯ": 
                // Якщо бібліотека повернула ID, якого немає в списку ваших користувачів
                var allUsers = DbDataAccess.LoadUsers();
                if (!allUsers.Any(u => u.Id == result.Label))
                {
                    // Використовуємо фігурні дужки для версії 4.4.0
                    return new FaceRecognizer.PredictionResult { Label = -1, Distance = double.MaxValue };
                }

                return result;
            }
            catch
            {
                return new FaceRecognizer.PredictionResult { Label = -1, Distance = double.MaxValue };
            }
        }
    }
}