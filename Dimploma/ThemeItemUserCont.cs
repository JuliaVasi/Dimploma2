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
using Guna.UI2;

namespace Dimploma
{
    public partial class ThemeItemUserCont : UserControl
    {
        private int _radius = 10;
        private SolidBrush activeBackgroundBrush = new SolidBrush(SystemColors.Control);
        private SolidBrush innactiveBackgroundBrush = new SolidBrush(SystemColors.Control);
        Image innactiveArrowimg;
        int colorNumber;
        LessonUserCont lessonUserCont;
        Lecture lecture;
        PrivateFontCollection fonts;
        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                Invalidate();
            }
        }
        public ThemeItemUserCont(int colorNumber, Lecture lecture, PrivateFontCollection fonts)
        {
            this.lecture = lecture;
            this.colorNumber = colorNumber;
            this.fonts = fonts;
            InitializeComponent();
        }

        private void ThemeItemUserCont_Load(object sender, EventArgs e)
        {
            SetFonts();
            SetPictures();
            SetLectureData();
        }

        private void SetLectureData()
        {
            themeLabel.Text = lecture.title;
            descriptionTextbox.Text = lecture.description;
        }

        private void SetPictures()
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
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawBackground(graphics);
        }

        private void DrawBackground(Graphics graphics)
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
      
        private void SetFonts()
        {
            descriptionTextbox.ForeColor = ColorTranslator.FromHtml(ThemeColor.TextGray);
            descriptionTextbox.Font = new Font(fonts.Families[0], 16);
            themeLabel.Font = new Font(fonts.Families[3], 20);
        }  

        private void ThemeLabel_MouseMove(object sender, MouseEventArgs e)
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

        private void ThemeLabel_MouseLeave(object sender, EventArgs e)
        {
            themeLabel.ForeColor = Color.Black;
        }

        private void ArrowOpenBtn_MouseLeave(object sender, EventArgs e)
        {
            arrowOpenBtn.Image = innactiveArrowimg;
        }

        private void ArrowOpenBtn_MouseMove(object sender, MouseEventArgs e)
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

        private void ShowLesson_Click(object sender, EventArgs e)
        {
            Global.ColorNumber = colorNumber;
            Global.currentLecture = lecture;
            //Global.lectureNumber = lecture.lectureNumber;
            Global.ShowLesson();
        }
    }
}
