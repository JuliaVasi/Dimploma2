using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
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
        PrivateFontCollection fonts;
        public LessonUserCont(int colorNumber)
        {
            this.colorNumber = colorNumber;
            InitializeComponent();
        }
        private void LessonUserCont_Load(object sender, EventArgs e)
        {
            addFonts();
            SetFonts();
/*            for(int i = 0; i<5; i++)
            {
                FlowLayoutPanel itemPanel = new FlowLayoutPanel();
                Label docTitle = new Label();
                PictureBox docIcon = new PictureBox();

                docTitle.Text = "gjjgjgjsjdfjsfshhsghsghsg sdjghsg suishdg sgisghs agaisag sa.pdf";
                docTitle.Font = new Font(fonts.Families[2], 20);
                docTitle.Height = 60;

                itemPanel.Width = aboutLessonPanel.Width;
                itemPanel.Height = MaterialLabel.Height;
                
                docIcon.Width = 30;
                docIcon.Height = 30;
                docIcon.Image = Properties.Resources.bookmark_FILL1_wght400_GRAD0_opsz24;
                docIcon.SizeMode = PictureBoxSizeMode.Zoom;

                itemPanel.Controls.Add(docIcon);
                itemPanel.Controls.Add(docTitle);

                materialsPanel.Controls.Add(itemPanel);
            }*/
        }

        private void addFonts()
        {
           fonts = new PrivateFontCollection();
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Light.ttf"); //0
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Bold.ttf");//1
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Regular.ttf");//2
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Medium.ttf");//3
        }
        private void SetFonts()
        {
            DescriptionTextbox.ForeColor = ColorTranslator.FromHtml(ThemeColor.TextGray);
            DescriptionTextbox.Font = new Font(fonts.Families[0], 16);
            ThemeLabel.Font = new Font(fonts.Families[3], 20);
            MaterialLabel.Font = new Font(fonts.Families[3], 20);
            MaterialLabel.ForeColor = ColorTranslator.FromHtml(ThemeColor.Blue);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //drawBorder(graphics);
            DrawBackground(graphics);
        }

        private void DrawBackground(Graphics graphics)
        {
            switch (colorNumber)
            {
                case 0:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightBlue));
                    DescriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightBlue);
                    break;

                case 1:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightPurple));
                    DescriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightPurple);

                    break;

                case 2:
                    backgroundBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.LightTeal));
                    DescriptionTextbox.BackColor = ColorTranslator.FromHtml(ThemeColor.LightTeal);
                    break;
            }
            graphics.FillRoundedRectangle(backgroundBrush, 10, 0, aboutLessonPanel.Width - 10, aboutLessonPanel.Height - 10, _radius);
        }




    }
}
