using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimploma
{
    public partial class LessonUserCont : UserControl
    {
        private int _radius = 10;
        private SolidBrush backgroundBrush = new SolidBrush(SystemColors.Control);
        private SolidBrush innactiveBackgroundBrush = new SolidBrush(SystemColors.Control);
        int colorNumber;

        public LessonUserCont(int colorNumber)
        {
            this.colorNumber = colorNumber;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //drawBorder(graphics);
            drawBackground(graphics);
        }

        private void drawBackground(Graphics graphics)
        {
            switch (colorNumber)
            {
                case 0:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightBlue));
                    break;

                case 1:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightPurple));

                    break;

                case 2:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightTeal));
                    break;
            }
            graphics.FillRoundedRectangle(backgroundBrush, 10, 0, Width - 10, Height - 10, _radius);
        }

        private void bindingNavigator1_PaddingChanged(object sender, EventArgs e)
        {

        }
    }
}
