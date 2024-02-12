namespace Dimploma
{
    partial class ThemeItemUserCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeItemUserCont));
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.themeLabel = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.arrowOpenBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowOpenBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.descriptionTextbox.Enabled = false;
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.descriptionTextbox.Location = new System.Drawing.Point(237, 77);
            this.descriptionTextbox.MaxLength = 2000;
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ReadOnly = true;
            this.descriptionTextbox.Size = new System.Drawing.Size(736, 90);
            this.descriptionTextbox.TabIndex = 6;
            this.descriptionTextbox.Text = resources.GetString("descriptionTextbox.Text");
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.BackColor = System.Drawing.Color.Transparent;
            this.themeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeLabel.Location = new System.Drawing.Point(232, 29);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(270, 25);
            this.themeLabel.TabIndex = 4;
            this.themeLabel.Text = "Поразрядные операции";
            this.themeLabel.Click += new System.EventHandler(this.ShowLesson_Click);
            this.themeLabel.MouseLeave += new System.EventHandler(this.ThemeLabel_MouseLeave);
            this.themeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThemeLabel_MouseMove);
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.ErrorImage = null;
            this.picturebox.InitialImage = null;
            this.picturebox.Location = new System.Drawing.Point(33, 29);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(150, 150);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 5;
            this.picturebox.TabStop = false;
            // 
            // arrowOpenBtn
            // 
            this.arrowOpenBtn.BackColor = System.Drawing.Color.Transparent;
            this.arrowOpenBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.arrowOpenBtn.Image = global::Dimploma.Properties.Resources.arrow_circle_lightblue1;
            this.arrowOpenBtn.Location = new System.Drawing.Point(1041, 139);
            this.arrowOpenBtn.Margin = new System.Windows.Forms.Padding(0);
            this.arrowOpenBtn.Name = "arrowOpenBtn";
            this.arrowOpenBtn.Size = new System.Drawing.Size(52, 52);
            this.arrowOpenBtn.TabIndex = 7;
            this.arrowOpenBtn.TabStop = false;
            this.arrowOpenBtn.Click += new System.EventHandler(this.ShowLesson_Click);
            this.arrowOpenBtn.MouseLeave += new System.EventHandler(this.ArrowOpenBtn_MouseLeave);
            this.arrowOpenBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ArrowOpenBtn_MouseMove);
            // 
            // ThemeItemUserCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.arrowOpenBtn);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.themeLabel);
            this.Name = "ThemeItemUserCont";
            this.Size = new System.Drawing.Size(1126, 220);
            this.Load += new System.EventHandler(this.ThemeItemUserCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowOpenBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arrowOpenBtn;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Label themeLabel;
    }
}
