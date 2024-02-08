namespace Dimploma
{
    partial class LessonUserCont
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonUserCont));
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.Picturebox = new System.Windows.Forms.PictureBox();
            this.aboutLessonPanel = new System.Windows.Forms.Panel();
            this.MaterialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).BeginInit();
            this.aboutLessonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DescriptionTextbox.Enabled = false;
            this.DescriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DescriptionTextbox.Location = new System.Drawing.Point(68, 99);
            this.DescriptionTextbox.MaxLength = 2000;
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.ReadOnly = true;
            this.DescriptionTextbox.Size = new System.Drawing.Size(713, 96);
            this.DescriptionTextbox.TabIndex = 9;
            this.DescriptionTextbox.Text = resources.GetString("DescriptionTextbox.Text");
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeLabel.Location = new System.Drawing.Point(63, 41);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(270, 25);
            this.ThemeLabel.TabIndex = 7;
            this.ThemeLabel.Text = "Поразрядные операции";
            // 
            // Picturebox
            // 
            this.Picturebox.BackColor = System.Drawing.Color.Transparent;
            this.Picturebox.ErrorImage = null;
            this.Picturebox.Image = global::Dimploma.Properties.Resources.пикча__1_;
            this.Picturebox.InitialImage = null;
            this.Picturebox.Location = new System.Drawing.Point(856, 41);
            this.Picturebox.Name = "Picturebox";
            this.Picturebox.Size = new System.Drawing.Size(213, 208);
            this.Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picturebox.TabIndex = 8;
            this.Picturebox.TabStop = false;
            // 
            // aboutLessonPanel
            // 
            this.aboutLessonPanel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLessonPanel.Controls.Add(this.Picturebox);
            this.aboutLessonPanel.Controls.Add(this.ThemeLabel);
            this.aboutLessonPanel.Controls.Add(this.DescriptionTextbox);
            this.aboutLessonPanel.Location = new System.Drawing.Point(1, 1);
            this.aboutLessonPanel.Name = "aboutLessonPanel";
            this.aboutLessonPanel.Size = new System.Drawing.Size(1126, 287);
            this.aboutLessonPanel.TabIndex = 10;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(3, 300);
            this.MaterialLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(65, 13);
            this.MaterialLabel.TabIndex = 12;
            this.MaterialLabel.Text = "Материалы";
            // 
            // LessonUserCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.aboutLessonPanel);
            this.Name = "LessonUserCont";
            this.Size = new System.Drawing.Size(1249, 347);
            this.Load += new System.EventHandler(this.LessonUserCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).EndInit();
            this.aboutLessonPanel.ResumeLayout(false);
            this.aboutLessonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.PictureBox Picturebox;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Panel aboutLessonPanel;
        private System.Windows.Forms.Label MaterialLabel;
    }
}
