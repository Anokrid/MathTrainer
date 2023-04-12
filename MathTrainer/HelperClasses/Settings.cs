namespace MathTrainer
{
    /// <summary>
    /// Основные настройки приложжения
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Число одновременно выводимых примеров
        /// </summary>
        public int ExamplesCount { get; set; }
    
        /// <summary>
        /// Наименование основного шритфа приложения
        /// </summary>
        public string MainFontName { get; set; }

        /// <summary>
        /// Размер основного шрифта приложения
        /// </summary>
        public int MainFontSize { get; set; }
    
        /// <summary>
        /// Наименование фона заметок
        /// </summary>
        public string NotesFontName { get; set; }
        
        /// <summary>
        /// Размер шрифта заметок
        /// </summary>
        public int NotesFontSize { get; set; }
    
        /// <summary>
        /// Шрифт примеров
        /// </summary>
        public string ExamplesFontName { get; set; }

        /// <summary>
        /// Размер шрифта примеров
        /// </summary>
        public int ExamplesFontSize { get; set; }

        /// <summary>
        /// Номер заднего фона приложения
        /// </summary>
        public int BackgroundId { get; set; }

        /// <summary>
        /// Растягивать ли изображение?
        /// </summary>
        public bool StretchBackground { get; set; }
    }  
}
