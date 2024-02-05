namespace Dimploma
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TimerMenu = new System.Windows.Forms.Timer(this.components);
            this.upperMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.themeItemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.minimazeBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuBorder = new System.Windows.Forms.Panel();
            this.savedBtn = new System.Windows.Forms.Button();
            this.mainBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.upperMenu.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerMenu
            // 
            this.TimerMenu.Interval = 15;
            this.TimerMenu.Tick += new System.EventHandler(this.SetTimer);
            // 
            // upperMenu
            // 
            this.upperMenu.BackColor = System.Drawing.Color.Transparent;
            this.upperMenu.Controls.Add(this.panel2);
            this.upperMenu.Controls.Add(this.formNameLabel);
            this.upperMenu.Controls.Add(this.panel1);
            this.upperMenu.Location = new System.Drawing.Point(2, 23);
            this.upperMenu.Name = "upperMenu";
            this.upperMenu.Size = new System.Drawing.Size(1323, 46);
            this.upperMenu.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 40);
            this.panel2.TabIndex = 12;
            // 
            // formNameLabel
            // 
            this.formNameLabel.AutoSize = true;
            this.formNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formNameLabel.Location = new System.Drawing.Point(72, 0);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.formNameLabel.Size = new System.Drawing.Size(127, 33);
            this.formNameLabel.TabIndex = 6;
            this.formNameLabel.Text = "Главная";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(205, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 40);
            this.panel1.TabIndex = 10;
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitAppBtn.FlatAppearance.BorderSize = 0;
            this.exitAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.exitAppBtn.ForeColor = System.Drawing.Color.Black;
            this.exitAppBtn.Location = new System.Drawing.Point(1303, -4);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(22, 38);
            this.exitAppBtn.TabIndex = 11;
            this.exitAppBtn.Text = "✕";
            this.exitAppBtn.UseVisualStyleBackColor = false;
            this.exitAppBtn.Click += new System.EventHandler(this.exitAppBtn_Click);
            // 
            // themeItemsPanel
            // 
            this.themeItemsPanel.AutoScroll = true;
            this.themeItemsPanel.Location = new System.Drawing.Point(58, 72);
            this.themeItemsPanel.Name = "themeItemsPanel";
            this.themeItemsPanel.Size = new System.Drawing.Size(1249, 663);
            this.themeItemsPanel.TabIndex = 3;
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.minimazeBtn);
            this.upperPanel.Controls.Add(this.exitAppBtn);
            this.upperPanel.Location = new System.Drawing.Point(2, -3);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1328, 29);
            this.upperPanel.TabIndex = 4;
            this.upperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upperMenu_MouseDown);
            // 
            // minimazeBtn
            // 
            this.minimazeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimazeBtn.FlatAppearance.BorderSize = 0;
            this.minimazeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimazeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minimazeBtn.ForeColor = System.Drawing.Color.Black;
            this.minimazeBtn.Location = new System.Drawing.Point(1270, -9);
            this.minimazeBtn.Name = "minimazeBtn";
            this.minimazeBtn.Size = new System.Drawing.Size(22, 43);
            this.minimazeBtn.TabIndex = 12;
            this.minimazeBtn.Text = "__";
            this.minimazeBtn.UseVisualStyleBackColor = false;
            this.minimazeBtn.Click += new System.EventHandler(this.minimazeBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuPanel.Controls.Add(this.menuBorder);
            this.menuPanel.Controls.Add(this.savedBtn);
            this.menuPanel.Controls.Add(this.mainBtn);
            this.menuPanel.Controls.Add(this.menuBtn);
            this.menuPanel.Location = new System.Drawing.Point(-1, 65);
            this.menuPanel.MaximumSize = new System.Drawing.Size(265, 649);
            this.menuPanel.MinimumSize = new System.Drawing.Size(45, 649);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(265, 649);
            this.menuPanel.TabIndex = 0;
            // 
            // menuBorder
            // 
            this.menuBorder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuBorder.Location = new System.Drawing.Point(258, 4);
            this.menuBorder.Name = "menuBorder";
            this.menuBorder.Size = new System.Drawing.Size(5, 645);
            this.menuBorder.TabIndex = 6;
            // 
            // savedBtn
            // 
            this.savedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.savedBtn.FlatAppearance.BorderSize = 0;
            this.savedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savedBtn.Image = global::Dimploma.Properties.Resources.bookmark_FILL0_wght400_GRAD0_opsz24;
            this.savedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savedBtn.Location = new System.Drawing.Point(3, 126);
            this.savedBtn.Name = "savedBtn";
            this.savedBtn.Size = new System.Drawing.Size(254, 60);
            this.savedBtn.TabIndex = 2;
            this.savedBtn.Text = "   Сохраненное";
            this.savedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savedBtn.UseVisualStyleBackColor = false;
            this.savedBtn.Click += new System.EventHandler(this.savedBtn_Click);
            // 
            // mainBtn
            // 
            this.mainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.mainBtn.FlatAppearance.BorderSize = 0;
            this.mainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainBtn.Location = new System.Drawing.Point(3, 64);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(254, 60);
            this.mainBtn.TabIndex = 1;
            this.mainBtn.Text = "   Главная";
            this.mainBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainBtn.UseVisualStyleBackColor = false;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.Location = new System.Drawing.Point(3, 2);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(254, 60);
            this.menuBtn.TabIndex = 5;
            this.menuBtn.Text = "   Меню";
            this.menuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1328, 716);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.upperMenu);
            this.Controls.Add(this.themeItemsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изучение языка программирования C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.upperMenu.ResumeLayout(false);
            this.upperMenu.PerformLayout();
            this.upperPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel upperMenu;
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.FlowLayoutPanel themeItemsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimazeBtn;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel menuBorder;
        private System.Windows.Forms.Button savedBtn;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Timer TimerMenu;
    }
}

