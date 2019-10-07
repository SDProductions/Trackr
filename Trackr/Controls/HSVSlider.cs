using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Trackr.Controls
{
    public partial class HSVSlider : UserControl
    {
        public HSVSlider()
        {
            InitializeComponent();
        }

        private void SelectorHueBackground_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush br = new LinearGradientBrush((sender as Control).ClientRectangle, Color.Black, Color.Black, 0, false);
            ColorBlend cb = new ColorBlend
            {
                Positions = new[] { 0, 1 / 6f, 2 / 6f, 3 / 6f, 4 / 6f, 5 / 6f, 1 },
                Colors = new[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet }
            };
            br.InterpolationColors = cb;
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }
    }
}
