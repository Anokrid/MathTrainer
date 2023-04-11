using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class QuestionForm : Form
    {
        private int Page = 1;
        Image image;

        public QuestionForm()
        {
            InitializeComponent();
            buttonForward.Click += ButtonForward_Click;
            buttonBack.Click += ButtonBack_Click;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (Page > 1)
            {
                Page -= 1;
                UpdatePage();
            }
        }

        private void ButtonForward_Click(object sender, EventArgs e)
        {
            if (Page < 13)
            {
                Page += 1;
                UpdatePage();
            }
        }

        private void UpdatePage()
        {
            string txt = "Страница " + Page;
            labelPage.Text = txt;
            string imageName = "../Resource/Help/Help" + Page + ".png";
            image = Image.FromFile(imageName);
            pictureBox1.Image = image;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void ChangeFont(Font fnt)
        {
            buttonBack.Font = fnt;
            buttonForward.Font = fnt;
            labelPage.Font = fnt;
        }
    }
}
