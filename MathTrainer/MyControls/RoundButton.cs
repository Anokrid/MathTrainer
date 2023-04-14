using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MathTrainer
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(1, 1, ClientSize.Width - 3, ClientSize.Height - 3);
            Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
