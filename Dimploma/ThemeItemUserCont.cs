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
        private SolidBrush activeBackgroundBrush = new SolidBrush(SystemColors.Control);
        private SolidBrush innactiveBackgroundBrush = new SolidBrush(SystemColors.Control);
        int colorNumber;
        Image innactiveArrowimg;

        Graphics graphics;
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
        private void ThemeItemUserCont_Load(object sender, EventArgs e)
        {
            setFonts();
            setPicturesToBtn();
            setPictures();
        }

        private void setPicturesToBtn()
        {
          
        }
        private void setPictures()
        {
            switch (colorNumber)
            {
                case 0:
                     picturebox.Image = Properties.Resources.Hand_coding_bro_1;
                     arrowOpenBtn.Image = Properties.Resources.arrow_circle_lightblue;
                    break;

                case 1:
                     picturebox.Image = Properties.Resources.Hand_coding_bro_2;
                     arrowOpenBtn.Image = Properties.Resources.arrow_circle_lightviolet;

                    break;

                case 2:
                     picturebox.Image = Properties.Resources.Hand_coding_bro_3;
                      arrowOpenBtn.Image = Properties.Resources.arrow_circle_lightteal;
                    break;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //drawBorder(graphics);
            drawBackground(graphics);
        }
        private void drawBackground(Graphics graphics)
        {
            switch (colorNumber)
            {
                case 0:
                    activeBackgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightBlue));
                    descriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightBlue);
                    break;

                case 1:
                    activeBackgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightPurple));
                    descriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightPurple);

                    break;

                case 2:
                    activeBackgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightTeal));
                    descriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightTeal);
                    break;
        }
            graphics.FillRoundedRectangle(activeBackgroundBrush, 10, 0, Width - 10, Height - 10, _radius);
        }
      
        private void setFonts()
        {
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Light.ttf"); //0
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Bold.ttf");//1
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Regular.ttf");//2
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Medium.ttf");//3

            descriptionTextbox.ForeColor = ColorTranslator.FromHtml(ThemeColor.TextGray);
            descriptionTextbox.Font = new Font(fonts.Families[0], 16);
            themeLabel.Font = new Font(fonts.Families[3], 20);
            
        }  

        private void themeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            switch (colorNumber)
            {
                case 0:
                    themeLabel.ForeColor = ColorTranslator.FromHtml(ThemeColor.Blue);
                    break;  
                case 1:
                    themeLabel.ForeColor = ColorTranslator.FromHtml(ThemeColor.VioletDark);
                    break;
                case 2:
                    themeLabel.ForeColor = ColorTranslator.FromHtml(ThemeColor.Teal);
                    break;
            }
        }

        private void themeLabel_MouseLeave(object sender, EventArgs e)
        {
            themeLabel.ForeColor = Color.Black;
        }

        private void openLesson(object sender, EventArgs e)
        {
        }

        private void arrowOpenBtn_MouseLeave(object sender, EventArgs e)
        {
            //arrowOpenBtn.Image = innactiveArrowimg;
            setPictures();
        }

        private void arrowOpenBtn_MouseMove(object sender, MouseEventArgs e)
        {
            switch (colorNumber)
            {
                case 0:
                    innactiveArrowimg = Properties.Resources.arrow_circle_lightblue;
                    arrowOpenBtn.Image = Properties.Resources.arrow_circle3;
                    break;  
                case 1:
                    innactiveArrowimg = Properties.Resources.arrow_circle_lightviolet;
                    arrowOpenBtn.Image = Properties.Resources.arrow_circle2;
                    break;  
                case 2:
                    innactiveArrowimg = Properties.Resources.arrow_circle_lightteal;
                    arrowOpenBtn.Image = Properties.Resources.arrow_circle1;
                    break;
            }
        }

        private void arrowOpenBtn_Click(object sender, EventArgs e)
        {
        }

        private void ThemeItemUserCont_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void ThemeItemUserCont_MouseLeave(object sender, EventArgs e)
        {
/*            
 *          activeBackgroundBrush = innactiveBackgroundBrush;
            graphics.FillRoundedRectangle(activeBackgroundBrush, 10, 0, Width - 10, Height - 10, _radius);
*/
            // drawBackground(graphics);
        }
    }
}
