using System;
using System.IO;

namespace MathTrainer
{
    /// <summary>
    /// Класс, осуществляющий поиск существующего пути до папки ресурсов
    /// </summary>
    public static class DirectoryManager
    {
        #region Возможные пути поиска
        private static readonly string FirstPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        private static readonly string SecondPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        private static readonly string ThirdPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory); 
        #endregion

        /// <summary>
        /// Попытаться найти путь до файла
        /// </summary>
        /// <param name="fileName">Наименование файла</param>
        /// <returns></returns>
        public static string TryToFindValidPathToFile(string fileName)
        {
            return GetValidPath(fileName, IsFileExist);
        }

        /// <summary>
        /// Попытаться найти путь до папки
        /// </summary>
        /// <param name="directoryName">Наименование папки</param>
        /// <returns></returns>
        public static string TryToFindValidPathToDirectory(string directoryName)
        {
            return GetValidPath(directoryName, IsDirectoryExist);
        }

        /// <summary>
        /// Проверить путь до папки или файла на существование
        /// </summary>
        /// <param name="shortPath">Короткий путь или название файла</param>
        /// <param name="func">Функция валидации наличия файла или папки</param>
        /// <returns></returns>
        private static string GetValidPath(string shortPath, Func<string, bool> func)
        {
            string path = FirstPath + shortPath;
            bool isDirectoryExist = func(path);
            if (!isDirectoryExist)
            {
                path = SecondPath + shortPath;
                isDirectoryExist = func(path);
            }
            if (!isDirectoryExist)
            {
                path = ThirdPath + shortPath;
            }

            return path;
        }

        /// <summary>
        /// Проверить, существет ли файл
        /// </summary>
        /// <param name="path">Полный путь до файла</param>
        /// <returns></returns>
        private static bool IsFileExist(string path)
        {
            return File.Exists(path);
        }

        /// <summary>
        /// ПРоверить, существет ли директория
        /// </summary>
        /// <param name="path">Полный путь до директории</param>
        /// <returns></returns>
        private static bool IsDirectoryExist(string path)
        {
            return Directory.Exists(path);
        }
    }
}
