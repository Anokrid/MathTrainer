using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();
        }

        public void ChangeFont(Font font)
        {
            labelMain.Font = font;

            label100.Font = font;
            label101.Font = font;
            label102.Font = font;

            textBox1.Font = font;
            textBox2.Font = font;
            textBox3.Font = font;
        }
    }
}
