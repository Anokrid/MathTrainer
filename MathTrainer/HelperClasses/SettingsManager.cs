namespace MathTrainer
{
    /// <summary>
    /// Класс, осуществляющий загрузку и сохранение настроек приложения
    /// </summary>
    public static class SettingsManager
    {
        /// <summary>
        /// Загрузить настройки
        /// </summary>
        /// <returns></returns>
        public static Settings LoadSettings()
        {
            var settings = new Settings
            {
                ExamplesCount = Properties.Settings.Default.ExamplesCount,

                MainFontName = Properties.Settings.Default.MainFontName,
                MainFontSize = Properties.Settings.Default.MainFontSize,
                NotesFontName = Properties.Settings.Default.NotesFontName,
                NotesFontSize = Properties.Settings.Default.NotesFontSize,
                ExamplesFontName = Properties.Settings.Default.ExamplesFontName,
                ExamplesFontSize = Properties.Settings.Default.ExamplesFontSize,

                BackgroundId = Properties.Settings.Default.BackgroundId,
                StretchBackground = Properties.Settings.Default.StretchBackground
            };
            return settings;
        }

        /// <summary>
        /// Сохранить изменения в настройках
        /// </summary>
        /// <param name="settings">Обновлённые значения параметров настройки</param>
        public static void SaveSettings(Settings settings)
        {
            Properties.Settings.Default.ExamplesCount = settings.ExamplesCount;

            Properties.Settings.Default.MainFontName = settings.MainFontName;
            Properties.Settings.Default.MainFontSize = settings.MainFontSize;
            Properties.Settings.Default.NotesFontName = settings.NotesFontName;
            Properties.Settings.Default.NotesFontSize = settings.NotesFontSize;
            Properties.Settings.Default.ExamplesFontName = settings.ExamplesFontName;
            Properties.Settings.Default.ExamplesFontSize = settings.ExamplesFontSize;

            Properties.Settings.Default.BackgroundId = settings.BackgroundId;
            Properties.Settings.Default.StretchBackground = settings.StretchBackground;

            Properties.Settings.Default.Save();
        }
    }
}
