namespace Dimploma
{
    partial class Form1
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
            this.TimerMenu = new System.Windows.Forms.Timer(this.components);
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upperMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.themeItemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.studyBtn = new System.Windows.Forms.Button();
            this.savedBtn = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.upperMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerMenu
            // 
            this.TimerMenu.Interval = 15;
            this.TimerMenu.Tick += new System.EventHandler(this.SetTimer);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.menuBtn);
            this.menuPanel.Controls.Add(this.studyBtn);
            this.menuPanel.Controls.Add(this.savedBtn);
            this.menuPanel.Location = new System.Drawing.Point(2, 25);
            this.menuPanel.MaximumSize = new System.Drawing.Size(263, 620);
            this.menuPanel.MinimumSize = new System.Drawing.Size(55, 620);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(55, 620);
            this.menuPanel.TabIndex = 1;
            // 
            // upperMenu
            // 
            this.upperMenu.BackColor = System.Drawing.Color.Transparent;
            this.upperMenu.Controls.Add(this.panel2);
            this.upperMenu.Controls.Add(this.formNameLabel);
            this.upperMenu.Controls.Add(this.panel1);
            this.upperMenu.Controls.Add(this.exitAppBtn);
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
            this.formNameLabel.Size = new System.Drawing.Size(136, 33);
            this.formNameLabel.TabIndex = 6;
            this.formNameLabel.Text = "Разделы";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(214, 3);
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
            this.exitAppBtn.ForeColor = System.Drawing.Color.Red;
            this.exitAppBtn.Location = new System.Drawing.Point(1298, 3);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(22, 40);
            this.exitAppBtn.TabIndex = 11;
            this.exitAppBtn.Text = "x";
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
            this.upperPanel.Location = new System.Drawing.Point(2, -3);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1328, 29);
            this.upperPanel.TabIndex = 4;
            this.upperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upperMenu_MouseDown);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuBtn.Image = global::Dimploma.Properties.Resources.menu_FILL0;
            this.menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.Location = new System.Drawing.Point(3, 3);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(254, 60);
            this.menuBtn.TabIndex = 5;
            this.menuBtn.Text = "   Меню";
            this.menuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // studyBtn
            // 
            this.studyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.studyBtn.FlatAppearance.BorderSize = 0;
            this.studyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studyBtn.Image = global::Dimploma.Properties.Resources.student_learning;
            this.studyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studyBtn.Location = new System.Drawing.Point(3, 69);
            this.studyBtn.Name = "studyBtn";
            this.studyBtn.Size = new System.Drawing.Size(254, 60);
            this.studyBtn.TabIndex = 1;
            this.studyBtn.Text = "   Study";
            this.studyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.studyBtn.UseVisualStyleBackColor = false;
            this.studyBtn.Click += new System.EventHandler(this.studyBtn_Click);
            // 
            // savedBtn
            // 
            this.savedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.savedBtn.FlatAppearance.BorderSize = 0;
            this.savedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savedBtn.Image = global::Dimploma.Properties.Resources._1904655_add_bookmark_favorite_favourite_important_note_ribbon_122505__1_;
            this.savedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savedBtn.Location = new System.Drawing.Point(3, 135);
            this.savedBtn.Name = "savedBtn";
            this.savedBtn.Size = new System.Drawing.Size(254, 60);
            this.savedBtn.TabIndex = 2;
            this.savedBtn.Text = "   Saved";
            this.savedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savedBtn.UseVisualStyleBackColor = false;
            this.savedBtn.Click += new System.EventHandler(this.savedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1328, 716);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.upperMenu);
            this.Controls.Add(this.themeItemsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.upperMenu.ResumeLayout(false);
            this.upperMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button studyBtn;
        private System.Windows.Forms.Button savedBtn;
        private System.Windows.Forms.Timer TimerMenu;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private System.Windows.Forms.FlowLayoutPanel upperMenu;
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.FlowLayoutPanel themeItemsPanel;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel panel2;
    }
}

