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
        bool menuExpanded = false;
        public MainForm()
        {
            InitializeComponent();
            Global.ClearThemeItemsPanel = ClearThemeItemsPanel;
            Global.ShowLesson = ShowLesson;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Global.mainForm = this;
            Global.themeItemsPanel = themeItemsPanel;
            AddFonts();
            SetFontsToMenuBtns();
            SetFonts();

            ShowLessonTitles();

            MenuSetup();
            SetIconsToMenuBtns();

        }

        private void ShowLesson()
        {
            /*            for (int i = 0; i < 5; i++)
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

            /*            Label materialsLabel = new Label();
                        materialsLabel.Text = "gjjgjgjsjdfjsfshhsghsghsg sdjghsg suishdg sgisghs agaisag sa.pdf";
                        materialsLabel.Font = new Font(fonts.Families[2], 20);
                        materialsLabel.Height = 60;

                        themeItemsPanel.Controls.Add(docTitle);*/

            for (int i = 0; i < 15; i++)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Width = themeItemsPanel.Width - 10;
                Label docTitle = new Label();
                docTitle.Text = $"{i}  gjjgjgjsjdfjsfshhsghsghsg sdjghsg suishdg sgisghs agaisag sagjjgjgjsjdf.pdf";
                docTitle.Font = new Font(fonts.Families[2], 20);
                docTitle.Height = 60;
                docTitle.Width = themeItemsPanel.Width - 2;
                docTitle.Click += new EventHandler(this.OpenDocument);
                docTitle.MouseLeave += new EventHandler(this.DocTitle_MouseLeave);
                docTitle.MouseLeave += new EventHandler(this.DocTitle_MouseMove);

                PictureBox docIcon = new PictureBox();
                docIcon.Width = 30;
                docIcon.Height = 30;
                docIcon.Image = Properties.Resources.bookmark_FILL1_wght400_GRAD0_opsz24;
                docIcon.SizeMode = PictureBoxSizeMode.Zoom;

                flowLayoutPanel.Controls.Add(docIcon);
                flowLayoutPanel.Controls.Add(docTitle);
                themeItemsPanel.Controls.Add(flowLayoutPanel);
            }
        }

        private void DocTitle_MouseMove(object sender, EventArgs e)
        {
            
        }
        private void DocTitle_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void OpenDocument(object sender, EventArgs e)
        {
            MessageBox.Show("It will work soon");
        }

        private void ShowLessonTitles()
        {
            int colorNumber = 0;
            for (int i = 0; i < 6; i++)
            {
                if (colorNumber == 3) colorNumber = 0;
                ThemeItemUserCont themeItem = new ThemeItemUserCont(colorNumber);
                colorNumber++;
                themeItemsPanel.Controls.Add(themeItem);
            }
        }

        private void SetIconsToMenuBtns()
        {
            mainBtn.Image = (Image)(new Bitmap(Properties.Resources.home_FILL0_wght400_GRAD0_opsz241, new Size(30, 30)));
            savedBtn.Image = (Image)(new Bitmap(Properties.Resources.bookmark_FILL0_wght400_GRAD0_opsz24, new Size(30, 30)));
        }

        private void MenuSetup()
        {
            menuPanel.Width = menuPanel.MinimumSize.Width;
            menuPanel.Height = menuPanel.MinimumSize.Height;
            upperMenu.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
            menuPanel.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
            upperPanel.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);

            // set up menu icon and border
            menuBorder.BackColor = ColorTranslator.FromHtml(ThemeColor.ScrollBarGray);
            menuBtn.Image = (Image)(new Bitmap(Properties.Resources.menu_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
        }

        private void AddFonts()
        {
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Light.ttf");
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Bold.ttf");
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Regular.ttf");
            fonts.AddFontFile("Fonts/MPLUSRounded1c-Medium.ttf");
        }

        private void SetFonts()
        {
            formNameLabel.Font = new Font(fonts.Families[2], 20);
            exitAppBtn.Font = new Font(fonts.Families[2], 18);
            minimazeBtn.Font = new Font(fonts.Families[2], 18);
        }

        private void SetFontsToMenuBtns()
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
                    previousBtn.BackColor = ColorTranslator.FromHtml(ThemeColor.BackgroundGray);
                    previousBtn.ForeColor = Color.Black;
                }
            }
            SetFontsToMenuBtns();
            SetIconsToMenuBtns();
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            mainBtn.Image = (Image)(new Bitmap(Properties.Resources.home_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
        }

        private void SavedBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            savedBtn.Image = (Image)(new Bitmap(Properties.Resources.bookmark_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            //change menu icon, then change menu state
            if (menuExpanded)
                menuBtn.Image = (Image)(new Bitmap(Properties.Resources.menu_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
            else
                menuBtn.Image = (Image)(new Bitmap(Properties.Resources.menu_open_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
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

        private void ClearThemeItemsPanel()
        {
            List<Control> listControls = new List<Control>();

            foreach (Control control in themeItemsPanel.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                Controls.Remove(control);
                control.Dispose();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void UpperMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MinimazeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void ExitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
