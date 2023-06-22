namespace ImageViewer
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
            this.browseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.jpegRadioButton = new System.Windows.Forms.RadioButton();
            this.pngRadioButton = new System.Windows.Forms.RadioButton();
            this.bmpRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(282, 526);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(129, 27);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Выбор каталога";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(282, 560);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(129, 27);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imagePictureBox.Location = new System.Drawing.Point(2, 2);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(427, 430);
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(12, 435);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(35, 13);
            this.directoryLabel.TabIndex = 3;
            this.directoryLabel.Text = "label1";
            this.directoryLabel.Click += new System.EventHandler(this.imageListBox_SelectedIndexChanged);
            // 
            // jpegRadioButton
            // 
            this.jpegRadioButton.AutoSize = true;
            this.jpegRadioButton.Location = new System.Drawing.Point(8, 16);
            this.jpegRadioButton.Name = "jpegRadioButton";
            this.jpegRadioButton.Size = new System.Drawing.Size(45, 17);
            this.jpegRadioButton.TabIndex = 4;
            this.jpegRadioButton.TabStop = true;
            this.jpegRadioButton.Text = "jpeg";
            this.jpegRadioButton.UseVisualStyleBackColor = true;
            this.jpegRadioButton.Click += new System.EventHandler(this.formatRadioButton_CheckedChanged);
            // 
            // pngRadioButton
            // 
            this.pngRadioButton.AutoSize = true;
            this.pngRadioButton.Location = new System.Drawing.Point(8, 39);
            this.pngRadioButton.Name = "pngRadioButton";
            this.pngRadioButton.Size = new System.Drawing.Size(43, 17);
            this.pngRadioButton.TabIndex = 5;
            this.pngRadioButton.TabStop = true;
            this.pngRadioButton.Text = "png";
            this.pngRadioButton.UseVisualStyleBackColor = true;
            this.pngRadioButton.Click += new System.EventHandler(this.formatRadioButton_CheckedChanged);
            // 
            // bmpRadioButton
            // 
            this.bmpRadioButton.AutoSize = true;
            this.bmpRadioButton.Location = new System.Drawing.Point(8, 62);
            this.bmpRadioButton.Name = "bmpRadioButton";
            this.bmpRadioButton.Size = new System.Drawing.Size(45, 17);
            this.bmpRadioButton.TabIndex = 6;
            this.bmpRadioButton.TabStop = true;
            this.bmpRadioButton.Text = "bmp";
            this.bmpRadioButton.UseVisualStyleBackColor = true;
            this.bmpRadioButton.Click += new System.EventHandler(this.formatRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bmpRadioButton);
            this.groupBox1.Controls.Add(this.pngRadioButton);
            this.groupBox1.Controls.Add(this.jpegRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(282, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формат";
            // 
            // imageListBox
            // 
            this.imageListBox.FormattingEnabled = true;
            this.imageListBox.Location = new System.Drawing.Point(12, 451);
            this.imageListBox.Name = "imageListBox";
            this.imageListBox.Size = new System.Drawing.Size(264, 134);
            this.imageListBox.TabIndex = 8;
            this.imageListBox.Click += new System.EventHandler(this.imageListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 592);
            this.Controls.Add(this.imageListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.browseButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.RadioButton jpegRadioButton;
        private System.Windows.Forms.RadioButton pngRadioButton;
        private System.Windows.Forms.RadioButton bmpRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox imageListBox;
    }
}

