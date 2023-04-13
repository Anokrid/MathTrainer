using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathTrainer
{
    /// <summary>
    /// Окно, в котором рассказано о примерах, которые может гененрировать программа
    /// </summary>
    public partial class AboutProgrammForm : Form
    {

        public AboutProgrammForm()
        {
            InitializeComponent();

            ChangeFont();
            FillText();
            SetBackGround();
        }

        /// <summary>
        /// Изменить шрифт элементов управления
        /// </summary>
        /// <param name="fnt">Используемый шрифт</param>
        private void ChangeFont()
        {
            Font fnt = FontSetter.GetMainFont();

            headerLabel.Font = new Font(fnt.Name, fnt.Size + 2);
            descriptionLabel.Font = fnt;
        }

        /// <summary>
        /// Заполнить текстовое поле описанием текущего функционала программы
        /// </summary>
        private void FillText()
        {
            var builder = new StringBuilder(1024);
            builder.Append("1) Сложение:   2,3,4,5,6,7-значные числа с 2,3,4,5,6,7-значными числами\n");
            builder.Append("2) Вычитание:  2,3,4,5,6,7-значные числа с 2,3,4,5,6,7-значными числами\n");
            builder.Append("3) Умножение:  2,3,4,5,6,7-значные числа на 2,3,4,5,6,7-значные числа\n");
            builder.Append("4) Деление:    2,3,4,5,6,7-значные числа на 2,3,4,5,6,7-значные числа\n");
            builder.Append("5) Возведение в степень: \n");
            builder.Append("    5.1) 2-значные числа в степень 2/3/4/5/6/7\n");
            builder.Append("    5.2) 3-значные числа в степень 2/3/4/5/6\n");
            builder.Append("    5.3) 4-значные числа в степень 2/3/4/5\n");
            builder.Append("    5.4) 5-значные числа в степень 2/3/4\n");
            builder.Append("    5.5) 6-значные числа в степень 2/3\n");
            builder.Append("    5.6) 7-значные числа в степень 2\n");
            builder.Append("6) Извлечение из 2,3,4,5,6,7-значных числел корней степени 2,3,4,5,6,7");
            descriptionLabel.Text = builder.ToString();
        }

        /// <summary>
        /// Установить задний фон окна
        /// </summary>
        private void SetBackGround()
        {
            string imageName = "../Resource/Backgrounds/1.jpg";
            BackgroundImage = Image.FromFile(imageName);
            BackgroundImageLayout = ImageLayout.Stretch;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
    }
}
