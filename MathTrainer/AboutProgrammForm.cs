using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class AboutProgrammForm : Form
    {

        public AboutProgrammForm()
        {
            InitializeComponent();

            #region Заполнение текста
            labelAbout.Text = "1) Сложение:     2,3,4,5,6,7-значные числа с 2,3,4,5,6,7-значными числами\n";
            labelAbout.Text += "2) Вычитание:   2,3,4,5,6,7-значные числа с 2,3,4,5,6,7-значными числами\n";
            labelAbout.Text += "3) Умножение:  2,3,4,5,6,7-значные числа на 2,3,4,5,6,7-значные числа\n";
            labelAbout.Text += "4) Деление:      2,3,4,5,6,7-значные числа на 2,3,4,5,6,7-значные числа\n";
            labelAbout.Text += "5) Возведение в степень: \n";
            labelAbout.Text += "    5.1) 2-значные числа в степень 2/3/4/5/6/7\n";
            labelAbout.Text += "    5.2) 3-значные числа в степень 2/3/4/5/6\n";
            labelAbout.Text += "    5.3) 4-значные числа в степень 2/3/4/5\n";
            labelAbout.Text += "    5.4) 5-значные числа в степень 2/3/4\n";
            labelAbout.Text += "    5.5) 6-значные числа в степень 2/3\n";
            labelAbout.Text += "    5.6) 7-значные числа в степень 2\n";
            labelAbout.Text += "6) Извлечение из 2,3,4,5,6,7-значных числел корней степени 2,3,4,5,6,7";
            #endregion

            // Смена бэкграунда
            string imageName = "../Resource/Backgrounds/1.jpg";
            BackgroundImage = Image.FromFile(imageName);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void ChangeFont(Font fnt)
        {
            label1.Font = new Font(fnt.Name, fnt.Size + 2);
            labelAbout.Font = fnt;
        }
    }
}
