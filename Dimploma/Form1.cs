using Dimploma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Image = System.Drawing.Image;

namespace Dimploma
{
    //1341; 755 form size
    public partial class Form1 : Form
    {
        private Button currentButton;
        PrivateFontCollection fonts = new PrivateFontCollection();

        bool menuExpanded = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addFonts();
            setFonts();
            int colorNumber = 0;
           for (int i=0; i<6; i++)
            {
                if (colorNumber == 3) colorNumber = 0;
                ThemeItemUserCont themeItem = new ThemeItemUserCont(colorNumber);
                colorNumber++;
                themeItemsPanel.Controls.Add(themeItem);
            }

            upperMenu.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
            menuPanel.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
          //  this.button1.Image = (Image)(new Bitmap(Dimploma.Properties.Resources.school_FILL0, new Size(30, 30)));
        }

        private void addFonts()
        {
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Light.ttf");
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Bold.ttf");
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Regular.ttf");
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Medium.ttf");
        }

        private void setFonts()
        {
            studyBtn.Font = new Font(fonts.Families[0], 16);
            menuBtn.Font = new Font(fonts.Families[0], 16);
            savedBtn.Font = new Font(fonts.Families[0], 16);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ColorTranslator.FromHtml(ThemeColor.LightBlue);
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font(fonts.Families[3], 17);
                }
            }
        }    
         private void DisableButton()
        {
            foreach(Control previousBtn in menuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    // = Color.FromArgb(x, x, x);
                    previousBtn.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
                    previousBtn.ForeColor = Color.Black;
                }
            }
            setFonts();
        }

        private void studyBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void savedBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void studyBtn_MouseHover(object sender, EventArgs e)
        {
          //  ActivateButton(sender);
        }

        private void studyBtn_MouseLeave(object sender, EventArgs e)
        {
           // DisableButton(sender);
        }

        private void savedBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void savedBtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            TimerMenu.Start();
        }

        private void SetTimer(object sender, EventArgs e)
        {
            if (menuExpanded)
            {
                menuPanel.Width -= 10;
                if (menuPanel.Width == menuPanel.MinimumSize.Width)
                {
                    menuExpanded = false;
                    TimerMenu.Stop();
                }
            }
            else
            {
                menuPanel.Width += 10;
                if (menuPanel.Width == menuPanel.MaximumSize.Width)
                {
                    menuExpanded = true;
                    TimerMenu.Stop();
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void upperMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
//currentButton.BackColor = ColorTranslator.FromHtml(ThemeColor.Blue);