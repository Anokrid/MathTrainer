using System;
using System.Drawing;
using System.Windows.Forms;


namespace MathTrainer
{
    public static class BackgroundManager
    {
        /// <summary>
        /// Путь к папке с изображениями, являющимися бэкграундами
        /// </summary>
        private static readonly string PathToImages = "\\Resources\\Backgrounds\\";

        /// <summary>
        /// Формат изображений
        /// </summary>
        private static readonly string ImageFormat = ".jpg";

        /// <summary>
        /// Загрузить изоюражение, которое будет использовано в качестве заднего фона определённого окна
        /// </summary>
        /// <param name="backgroundId">Индекс загружаемого изображения</param>
        /// <returns></returns>
        public static Image GetBackground(int backgroundId)
        {
            string imageName = PathToImages + backgroundId + ImageFormat;
            string path = DirectoryManager.TryToFindValidPathToFile(imageName);

            try
            {
                Image newBackground = Image.FromFile(path);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return newBackground;
            }
            catch
            {
                MessageBox.Show("Не удаётся обнаружить задний фон с указанным ID, вероятнее всего указанный файл был удалён", "Файл отсутсвует!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
