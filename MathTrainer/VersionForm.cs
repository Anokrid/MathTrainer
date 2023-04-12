using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    /// <summary>
    /// Окно, в котором представлена информация касательно выпущенных изменений данного ПО
    /// </summary>
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Изменить шрифт элементов управления окна
        /// </summary>
        /// <param name="font">Используемый шрифт</param>
        public void ChangeFont(Font font)
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Font = font;
            }
        }
    }
}
