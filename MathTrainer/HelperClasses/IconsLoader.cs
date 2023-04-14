using System.Drawing;


namespace MathTrainer
{
    /// <summary>
    /// Загрузчик иконок для окон
    /// </summary>
    public static class IconsLoader
    {
        /// <summary>
        /// Путь до иконки редактирования
        /// </summary>
        private static readonly string IconEditFile = "\\Resources\\Icons\\Edit.ico";

        /// <summary>
        /// Получить иконку "Редактирование"
        /// </summary>
        /// <returns></returns>
        public static Icon GetIconEditPath()
        {
            string path = DirectoryManager.TryToFindValidPathToFile(IconEditFile);
            var icon = new Icon(path);
            return icon;
        }
    }
}
