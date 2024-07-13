using Dimploma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        LecturesDB lecturesDB = new LecturesDB();

        List<Lecture> lectures, presenDocList, wordDocList, pdfDocList;
        FlowLayoutPanel docFlowLayoutPanel;
        
        Label docTitle;
        List<Lecture> lectureFiles;
        PictureBox docIcon;
        public MainForm()
        {
            InitializeComponent();
            Global.ClearThemeItemsPanel = ClearThemeItemsPanel;
            Global.ShowLesson = ShowLesson;
            Global.mainForm = this;
            Global.themeItemsPanel = themeItemsPanel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Application.Run(new KeyEvents());
            AddFonts();
            SetFonts();
            SetFontsToMenuBtns();
            MenuSetup();
            SetIconsToMenuBtns();

            lectures = lecturesDB.GetLecturesList();
            ShowLessonTitles();
        }

        private void ShowLesson()
        {
            ClearThemeItemsPanel();
            ShowLessonUserCont();
            ShowLessonDocs();
            SetSaveIcon();
            saveLessonPicBox.Visible = true;
            slashLabel.Text = "/";
            themeLabelMainForm.Text = Global.currentLecture.title;
        }

        private void ShowLessonUserCont()
        {
            LessonUserCont lessonUserCont = new LessonUserCont(fonts);
            themeItemsPanel.Controls.Add(lessonUserCont);
        }

        private void ShowLessonDocs()
        {              
            lectureFiles = lecturesDB.GetLectureData();
            GroupFilesByType();

            if (presenDocList.Count > 0)
            {
                themeItemsPanel.Controls.Add(SetGroupName("Презентации"));
                ShowFilesGroup(presenDocList);
            }
             if (presenDocList.Count > 0)
            {
                themeItemsPanel.Controls.Add(SetGroupName("Документы"));
                ShowFilesGroup(wordDocList);
            }
            if (pdfDocList.Count > 0)
            {
                themeItemsPanel.Controls.Add(SetGroupName("pdf"));
                ShowFilesGroup(pdfDocList);
            }
            AddBottomSpace();
            SetPicToBox();
        }

        private void SetPicToBox()
        {
            switch (Global.ColorNumber)
            {
                case 0:
                    Global.picturebox.Image = Dimploma.Properties.Resources.Code_typing_bro_blue;
                    break;

                case 1:
                    Global.picturebox.Image = Properties.Resources.Code_typing_bro_violet;
                    break;

                case 2:
                    Global.picturebox.Image = Properties.Resources.Code_typing_bro_teal;
                    break;
            }
        }

        private void ShowFilesGroup(List<Lecture> filesList)
        {
             for(int i = 0; i< filesList.Count; i++)
            {
                docFlowLayoutPanel = new FlowLayoutPanel();
                SetDocFlowLPanel();
                SetDocTitle(filesList[i].file);
                SetDocIcon();
                docFlowLayoutPanel.Controls.Add(docIcon);
                docFlowLayoutPanel.Controls.Add(docTitle);
                themeItemsPanel.Controls.Add(docFlowLayoutPanel);
            }
        }

        private Label SetGroupName(string name)
        {
            Label groupLabel = new Label();
            groupLabel.BackColor = Color.White;
            groupLabel.ForeColor = Color.Gray;
            groupLabel.BorderStyle = BorderStyle.None;
            groupLabel.Text = name;
            groupLabel.Height = 50;
            groupLabel.Width = themeItemsPanel.Width - 30;
            groupLabel.Font = new Font(fonts.Families[3], 16);
            return groupLabel;
        }

        private void GroupFilesByType()
        {
            presenDocList = new List<Lecture>();
            wordDocList = new List<Lecture>();
            pdfDocList = new List<Lecture>();
            for(int i =0; i<lectureFiles.Count; i++)
            {
                Lecture lecture = lectureFiles[i];
                if (lecture.file.Contains(".pdf")) pdfDocList.Add(lecture);
                else if  (lecture.file.Contains(".pptx")) presenDocList.Add(lecture);
                else wordDocList.Add(lecture);
            }
        }

        private void AddBottomSpace()
        {
            FlowLayoutPanel bottomSpace = new FlowLayoutPanel();
            bottomSpace.Width = 30;
            themeItemsPanel.Controls.Add(bottomSpace);
        }

        private void SetDocIcon()
        {
            docIcon = new PictureBox();
            docIcon.Width = 40;
            docIcon.Height = 40;
            docIcon.Image = Properties.Resources.description_FILL0_wght400_GRAD0_opsz24;
            docIcon.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void SetDocFlowLPanel()
        {
            docFlowLayoutPanel.Height = 75;
            docFlowLayoutPanel.Width = 1126;
            docFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            docFlowLayoutPanel.AutoScroll = false;
        }

        private void SetDocTitle(string fileName)
        {
            docTitle = new Label();
            docTitle.BackColor = Color.White;
            docTitle.BorderStyle = BorderStyle.None;
            docTitle.Text = fileName;
            docTitle.Height = 75;
            docTitle.Width = docFlowLayoutPanel.Width - 60;
            docTitle.Font = new Font(fonts.Families[0], 16);
            docTitle.Cursor = Cursors.Hand;
            docTitle.Click += new EventHandler(this.OpenDocument);
            docTitle.MouseLeave += new EventHandler(this.DocTitle_MouseLeave);
            docTitle.MouseMove += new MouseEventHandler(this.DocTitle_MouseMove);
        }

        private void DocTitle_MouseMove(object sender, EventArgs e)
        {
            Label textbox = (Label ) sender;
            textbox.ForeColor = ColorTranslator.FromHtml(ThemeColor.Blue);
        }

        private void DocTitle_MouseLeave(object sender, EventArgs e)
        {
            Label textbox = (Label)sender;
            textbox.ForeColor = Color.Black;
        }

        private void OpenDocument(object sender, EventArgs e)
        {
            Label docTitle = (Label)sender;
            Process.Start($"Lectures\\{docTitle.Text}");
        }

        private void ShowLessonTitles()
        {
            saveLessonPicBox.Visible = false;
            int colorNumber = 0;
            for (int i = 0; i < lectures.Count; i++)
            {
                if (colorNumber == 3) colorNumber = 0;
                ThemeItemUserCont themeItem = new ThemeItemUserCont(colorNumber, lectures[i], fonts);
                colorNumber++;
                themeItemsPanel.Controls.Add(themeItem);
            }
        }

        private void SetIconsToMenuBtns()
        {
            mainBtn.Image = (Image)(new Bitmap(Properties.Resources.home_FILL0_wght400_GRAD0_opsz241, new Size(30, 30)));
            savedBtn.Image = (Image)(new Bitmap(Properties.Resources.bookmark_FILL0_wght400_GRAD0_opsz24, new Size(30, 30)));
            progInfoBtn.Image = (Image)(new Bitmap(Properties.Resources.info_FILL0_wght400_GRAD0_opsz, new Size(30, 30)));
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
            slashLabel.Font = new Font(fonts.Families[2], 20);
            themeLabelMainForm.Font = new Font(fonts.Families[2], 20);
            exitAppBtn.Font = new Font(fonts.Families[2], 18);
            minimazeBtn.Font = new Font(fonts.Families[2], 18);
        }

        private void SetFontsToMenuBtns()
        {
            mainBtn.Font = new Font(fonts.Families[0], 16);
            menuBtn.Font = new Font(fonts.Families[0], 16);
            savedBtn.Font = new Font(fonts.Families[0], 16);
            progInfoBtn.Font = new Font(fonts.Families[0], 16);
        }
        
        private void ActivateButton(object btnSender)
        {
            ResetThemeLabel();
            if (btnSender != null)
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
            formNameLabel.Text = "Главная";
            ClearThemeItemsPanel();
            lectures = lecturesDB.GetLecturesList();
            ShowLessonTitles();
        }

        private void SavedBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            savedBtn.Image = (Image)(new Bitmap(Properties.Resources.bookmark_FILL1_wght400_GRAD0_opsz24, new Size(30, 30)));
            formNameLabel.Text = "Сохраненное";
            ClearThemeItemsPanel();
            ShowSavedLessonTitles();
        }

        private void ShowSavedLessonTitles()
        {
            lectures = lecturesDB.GetSavedLectList();
            ShowLessonTitles();
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

        private void SaveLessonPicBox_Click(object sender, EventArgs e)
        {
            ChangeSaveIcon();
        }

        private void ChangeSaveIcon()
        {
            if (Global.currentLecture.saved)
            {
                saveLessonPicBox.Image = Properties.Resources.bookmark_FILL0_wght400_GRAD0_opsz24;
                Global.currentLecture.saved = false;
                lecturesDB.UpdateLecture();
            }
            else
            {
                saveLessonPicBox.Image = Properties.Resources.bookmark_FILL1_wght400_GRAD0_opsz24;
                Global.currentLecture.saved = true;
                lecturesDB.UpdateLecture();
            }
        }
        private void SetSaveIcon()
        {
            if (Global.currentLecture.saved)
                saveLessonPicBox.Image = Properties.Resources.bookmark_FILL1_wght400_GRAD0_opsz24;
            else
                saveLessonPicBox.Image = Properties.Resources.bookmark_FILL0_wght400_GRAD0_opsz24;
        }

        private void FormNameLabel_Click(object sender, EventArgs e)
        {
            if (!formNameLabel.Text.Equals("О программе"))
            {
            ClearThemeItemsPanel();
            GetLecturesListFromDB();
            ShowLessonTitles();
            ResetFormNameLabel();
            ResetThemeLabel();
            }
        }
        private void GetLecturesListFromDB()
        {
            if (formNameLabel.Text.Equals("Главная"))
            {
                lectures = lecturesDB.GetLecturesList();
            }
            else if (formNameLabel.Text.Equals("Сохраненное"))
            {
                lectures = lecturesDB.GetSavedLectList();
            }  
        }

        private void ResetThemeLabel()
        {
            slashLabel.Text = "";
            themeLabelMainForm.Text = "";
        }

        private void ResetTopBar()
        {
            ResetFormNameLabel();
        }

        private void progInfoBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            progInfoBtn.Image = (Image)(new Bitmap(Properties.Resources.info_FILL1_wght400_GRAD0_opsz, new Size(30, 30)));
            formNameLabel.Text = "О программе";
            ClearThemeItemsPanel();
            ProgInfoUserCont infoUserCont = new ProgInfoUserCont(fonts);
            Global.infoTextBox.ForeColor = Color.Black;
            themeItemsPanel.Controls.Add(infoUserCont);
        }

        private void ResetFormNameLabel()
        {
            formNameLabel.ForeColor = Color.Black;
            formNameLabel.Font = new Font(fonts.Families[2], 20);
        }

        private void formNameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            formNameLabel.ForeColor = ColorTranslator.FromHtml(ThemeColor.Blue);
            formNameLabel.Font = new Font(fonts.Families[3], 20);
        }

        private void formNameLabel_MouseLeave(object sender, EventArgs e)
        {
            ResetFormNameLabel();
        }
    }
}