using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dimploma.GraphicsExtension;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Environment;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Reflection.Emit;

namespace Dimploma
{
    public partial class ThemeItemUserCont : UserControl
    {
        private int _radius = 10;
        private SolidBrush backgroundBrush = new SolidBrush(SystemColors.Control);
        private Color backgroundColor = SystemColors.Control;
        int colorNumber;

        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                Invalidate();
            }
        }
        public ThemeItemUserCont(int colorNumber)
        {
            this.colorNumber = colorNumber;
            InitializeComponent();
        }


        private void drawBackground(Graphics graphics)
        {
            switch (colorNumber)
            {
                case 0:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightBlue));
                    descriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightBlue);
                    picturebox.BackgroundImage = Properties.Resources.Hand_coding_bro_1;
                    arrowOpenBtn.Image = Properties.Resources.arrow_circle3;
                    break;

                case 1:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightPurple));
                    descriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightPurple);
                    picturebox.BackgroundImage = Properties.Resources.Hand_coding_bro_2;
                    arrowOpenBtn.BackgroundImage = Properties.Resources.arrow_circle2;

                    break;

                case 2:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightTeal));
                    descriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightTeal);
                    picturebox.BackgroundImage = Properties.Resources.Hand_coding_bro_3;
                    arrowOpenBtn.BackgroundImage = Properties.Resources.arrow_circle1;
                    break;
        }
            graphics.FillRoundedRectangle(backgroundBrush, 0, 0, Width , Height - 10, _radius);

        }
      

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //drawBorder(graphics);
            drawBackground(graphics);
        }

        private void arrowOpenBtn_Click(object sender, EventArgs e)
        {

        }

        private void ThemeItemUserCont_Load(object sender, EventArgs e)
        {
            setFonts();
        }

        private void setFonts()
        {
            
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Light.ttf"); //0

            fonts.AddFontFile("Fonts/MPLUSRounded1c-Bold.ttf");//1
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Regular.ttf");//2
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Medium.ttf");//3

            descriptionTextbox.ForeColor = ColorTranslator.FromHtml(ThemeColor.TextGray);
            themeLabel.Font = new Font(fonts.Families[3], 20);
            descriptionTextbox.Font = new Font(fonts.Families[0], 16);

       /*     if (colorNumber == 0)
            {
                themeLabel.Font = new Font(fonts.Families[1], 24);
                descriptionTextbox.Font = new Font(fonts.Families[0], 16);
            }
            else if  (colorNumber == 1) {
           
            }
            else if (colorNumber == 1)
            {
                themeLabel.Font = new Font(fonts.Families[1], 16);
                descriptionTextbox.Font = new Font(fonts.Families[0], 14);
            }
            else if (colorNumber == 1)
            {
                themeLabel.Font = new Font(fonts.Families[1], 16);
                descriptionTextbox.Font = new Font(fonts.Families[0], 14);
            }
            else
            {
                themeLabel.Font = new Font(fonts.Families[3], 16);
                descriptionTextbox.Font = new Font(fonts.Families[2], 14);
            }*/

        }

        private void picturebox_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
