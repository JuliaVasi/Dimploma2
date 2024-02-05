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
    public partial class MainForm : Form
    {
        private Button currentButton;
        PrivateFontCollection fonts = new PrivateFontCollection();
        bool menuExpanded = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addFonts();
            setFontsToMenuBtns();
            setFonts();
            int colorNumber = 0;
            int selectedBtn = 1;
           for (int i=0; i<6; i++)
            {
                if (colorNumber == 3) colorNumber = 0;
                ThemeItemUserCont themeItem = new ThemeItemUserCont(colorNumber);
                colorNumber++;
                themeItemsPanel.Controls.Add(themeItem);
            }
            menuBorder.BackColor = ColorTranslator.FromHtml(ThemeColor.ScrollBarGray);
            Global.mainForm = this;
            MenuSetup();
            SetIconsToMenuBtns();
        }

        private void SetIconsToMenuBtns()
        {
            this.menuBtn.Image = (Image)(new Bitmap(Properties.Resources.menu_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
            this.mainBtn.Image = (Image)(new Bitmap(Properties.Resources.home_FILL0_wght400_GRAD0_opsz241, new Size(30, 30)));
            this.savedBtn.Image = (Image)(new Bitmap(Properties.Resources.bookmark_FILL0_wght400_GRAD0_opsz24, new Size(30, 30)));
        }

        private void MenuSetup()
        {
            menuPanel.Width = menuPanel.MinimumSize.Width;
            menuPanel.Height = menuPanel.MinimumSize.Height;
            upperMenu.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
            menuPanel.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
            upperPanel.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
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
            formNameLabel.Font = new Font(fonts.Families[2], 20);
            exitAppBtn.Font = new Font(fonts.Families[2], 18);
            minimazeBtn.Font = new Font(fonts.Families[2], 18);
        }

        private void setFontsToMenuBtns()
        {
            mainBtn.Font = new Font(fonts.Families[0], 16);
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
                    currentButton.BackColor = ColorTranslator.FromHtml(ThemeColor.SelectedMenu0);
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
            setFontsToMenuBtns();
            SetIconsToMenuBtns();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            mainBtn.Image = (Image)(new Bitmap(Properties.Resources.home_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
        }

        private void savedBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            savedBtn.Image = (Image)(new Bitmap(Properties.Resources.bookmark_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            TimerMenu.Start();
            if(!menuExpanded)
            menuBtn.Image = (Image)(new Bitmap(Properties.Resources.menu_open_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
            else 
                menuBtn.Image = (Image)(new Bitmap(Properties.Resources.menu_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
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

        private void minimazeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
