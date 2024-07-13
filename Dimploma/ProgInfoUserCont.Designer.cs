namespace Dimploma
{
    partial class ProgInfoUserCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgInfoUserCont));
            this.aboutLessonPanel = new System.Windows.Forms.Panel();
            this.devLabel = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.aboutLessonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutLessonPanel
            // 
            this.aboutLessonPanel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLessonPanel.Controls.Add(this.devLabel);
            this.aboutLessonPanel.Controls.Add(this.picturebox);
            this.aboutLessonPanel.Controls.Add(this.infoTextBox);
            this.aboutLessonPanel.Location = new System.Drawing.Point(3, 3);
            this.aboutLessonPanel.Name = "aboutLessonPanel";
            this.aboutLessonPanel.Size = new System.Drawing.Size(1126, 609);
            this.aboutLessonPanel.TabIndex = 13;
            // 
            // devLabel
            // 
            this.devLabel.AutoSize = true;
            this.devLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.devLabel.Location = new System.Drawing.Point(66, 446);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(815, 120);
            this.devLabel.TabIndex = 10;
            this.devLabel.Text = resources.GetString("devLabel.Text");
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.ErrorImage = null;
            this.picturebox.InitialImage = null;
            this.picturebox.Location = new System.Drawing.Point(959, 41);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(110, 116);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 8;
            this.picturebox.TabStop = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.infoTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoTextBox.Location = new System.Drawing.Point(70, 10);
            this.infoTextBox.MaxLength = 2000;
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(825, 420);
            this.infoTextBox.TabIndex = 9;
            this.infoTextBox.Text = resources.GetString("infoTextBox.Text");
            // 
            // ProgInfoUserCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aboutLessonPanel);
            this.Name = "ProgInfoUserCont";
            this.Size = new System.Drawing.Size(1233, 615);
            this.Load += new System.EventHandler(this.ProgInfoUserCont_Load);
            this.aboutLessonPanel.ResumeLayout(false);
            this.aboutLessonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aboutLessonPanel;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label devLabel;
    }
}
