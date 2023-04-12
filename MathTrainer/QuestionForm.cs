using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    /// <summary>
    /// Окно, в котором приведены подсказки по использованию программы
    /// </summary>
    public partial class QuestionForm : Form
    {
        /// <summary>
        /// Количество доступных страниц в окне подсказок
        /// </summary>
        private const int PagesCount = 13;

        /// <summary>
        /// Индекс текущей страница окна, моет иметь значения от 1 до <see cref="PagesCount"/>
        /// </summary>
        private int _pageId = 1;

        public QuestionForm()
        {
            InitializeComponent();
            buttonForward.Click += ButtonForwardClick;
            buttonBack.Click += ButtonBackClick;
        }

        /// <summary>
        /// Переместиться на прошлую страницу
        /// </summary>
        private void ButtonBackClick(object sender, EventArgs e)
        {
            if (_pageId > 1)
            {
                _pageId--;
                UpdatePage();
            }
        }

        /// <summary>
        /// Переместиться на следующую страницу
        /// </summary>
        private void ButtonForwardClick(object sender, EventArgs e)
        {
            if (_pageId < PagesCount)
            {
                _pageId++;
                UpdatePage();
            }
        }

        /// <summary>
        /// Обновить текущую страницу
        /// </summary>
        private void UpdatePage()
        {
            labelPage.Text = "Страница " + _pageId;
            string imageName = "../Resource/Help/Help" + _pageId + ".png";
            pictureBox1.Image = Image.FromFile(imageName);

            /// Изображения занимают много памяти, и если их вовремя не очищать, то происходит раздувание памяти, занимаемой приложением, поэтому вызов уборщика мусора решает данную проблему
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /// <summary>
        /// Изменить шритф элементов управления
        /// </summary>
        /// <param name="fnt">Новый шрифт</param>
        public void ChangeFont(Font fnt)
        {
            buttonBack.Font = fnt;
            buttonForward.Font = fnt;
            labelPage.Font = fnt;
        }
    }
}
