using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    public class Toggle : CheckBox
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 20;
                return cp;
            }
        }

        public Toggle()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Padding = new Padding(6);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = new GraphicsPath())
            {
                var d = Padding.All;
                var r = Height;

                path.AddArc(0, 0, r, r, 90, 180);
                path.AddArc(Width - r - 0, 0, r, r, -90, 180);
                path.CloseFigure();
                e.Graphics.FillPath(Checked ? Brushes.LightGreen : Brushes.LightGray, path);

                int ott = (int)(Height * 0.12);
                r = Height - ott * 2;
                var rect = Checked ? new Rectangle(Width - r - ott, ott, r, r)
                                   : new Rectangle(ott, ott, r, r);
                e.Graphics.FillEllipse(Checked ? Brushes.WhiteSmoke : Brushes.WhiteSmoke, rect);
            }
        }
    }
}
