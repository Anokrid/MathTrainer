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
            FontSetter.SetMainFont(Controls);
        }
    }
}
