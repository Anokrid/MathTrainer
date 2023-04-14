using System.Collections.Generic;
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
        /// Установить шрифт всем контролам окна, кроме тех, которых необходимо исключить
        /// </summary>
        /// <param name="font">Шрифт, который необходимо установить</param>
        /// <param name="controls">Перечень контролов окна</param>
        /// <param name="controlsToExclude">Контролы, которым шрифт устанавливать ненужно</param>
        public static void SetFontWithExeptions(Font font, Control.ControlCollection controls, List<Control> controlsToExclude)
        {
            foreach (Control control in controls)
            {
                if (controlsToExclude.Contains(control)) continue;

                control.Font = font;
            }
        }
        
        /// <summary>
        /// Установить основной шрифт приложения всем контролам окна
        /// </summary>
        /// <param name="controls">Перечень контролов окна</param>
        public static void SetMainFont(Control.ControlCollection controls)
        {
            Font mainFont = GetMainFont();
            foreach (Control ctrl in controls)
            {
                ctrl.Font = mainFont;
            }
        }

        /// <summary>
        /// Установить перечню элементов управления определённый шрифт
        /// </summary>
        /// <param name="font">Шрифт, который необходимо установить</param>
        /// <param name="controls">Перечень элементов управления, которым необходимо установить шрифт</param>
        public static void SetFontToControls(Font font, List<Control> controls)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Font = font;
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
