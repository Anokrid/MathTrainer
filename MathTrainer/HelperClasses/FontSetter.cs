using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    /// <summary>
    /// Класс устанавливает шрифты для элементов управления различных окон
    /// </summary>
    public static class FontSetter
    {
        /// <summary>
        /// Установить основной шрифт приложения всем контролам окна
        /// </summary>
        /// <param name="controls">Перечень контролов окна</param>
        public static void SetMainFont(Control.ControlCollection controls)
        {
            string mainFontName = Properties.Settings.Default.MainFontName;
            int mainFontSize = Properties.Settings.Default.MainFontSize;
            Font mainFont = new Font(mainFontName, mainFontSize);

            foreach (Control ctrl in controls)
            {
                ctrl.Font = mainFont;
            }
        }

        /// <summary>
        /// Получить основной шрифт приложения
        /// </summary>
        /// <returns></returns>
        public static Font GetMainFont()
        {
            string fontName = Properties.Settings.Default.MainFontName;
            int fontSize = Properties.Settings.Default.MainFontSize;
            Font font = new Font(fontName, fontSize);
            return font;
        }

        /// <summary>
        /// Получить шрифт заметок
        /// </summary>
        /// <returns></returns>
        public static Font GetNotesFont()
        {
            string fontName = Properties.Settings.Default.NotesFontName;
            int fontSize = Properties.Settings.Default.NotesFontSize;
            Font font = new Font(fontName, fontSize);
            return font;
        }

        /// <summary>
        /// Получить шрифт задач/примеров
        /// </summary>
        /// <returns></returns>
        public static Font GetProblemsFont()
        {
            string fontName = Properties.Settings.Default.ExamplesFontName;
            int fontSize = Properties.Settings.Default.ExamplesFontSize;
            Font font = new Font(fontName, fontSize);
            return font;
        }
    }
}
