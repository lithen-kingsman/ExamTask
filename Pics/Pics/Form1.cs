using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace ImageViewer
{
    public partial class MainForm : Form
    {
        private string selectedDirectory;
        private List<string> imageFiles;
        private Image currentImage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Отключаем возможность максимизации окна
            MaximizeBox = false;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                // Запрещаем создание новых каталогов
                folderBrowserDialog.ShowNewFolderButton = false;

                var result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    selectedDirectory = folderBrowserDialog.SelectedPath;
                    directoryLabel.Text = selectedDirectory;

                    UpdateImageList();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateImageList();
        }

        private void imageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageListBox.SelectedItem != null)
            {
                var selectedImageFile = imageListBox.SelectedItem.ToString();
                var imagePath = Path.Combine(selectedDirectory, selectedImageFile);

                currentImage?.Dispose();
                currentImage = Image.FromFile(imagePath);
                imagePictureBox.Image = currentImage;
                imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void UpdateImageList()
        {
            imageListBox.Items.Clear();

            if (!string.IsNullOrEmpty(selectedDirectory))
            {
                var selectedFormat = GetSelectedFormat();

                imageFiles = Directory.GetFiles(selectedDirectory)
                .Where(file => selectedFormat.Contains(Path.GetExtension(file).ToLower()))
                .OrderBy(file => file)
                .Select(file => Path.GetFileName(file))
                .ToList();

                imageListBox.Items.AddRange(imageFiles.ToArray());
            }
        }

        private List<string> GetSelectedFormat()
        {
            var selectedFormat = new List<string>();

            if (jpegRadioButton.Checked)
            {
                selectedFormat.Add(".jpeg");
                selectedFormat.Add(".jpg");
            }
            else if (pngRadioButton.Checked)
            {
                selectedFormat.Add(".png");
            }
            else if (bmpRadioButton.Checked)
            {
                selectedFormat.Add(".bmp");
            }

            return selectedFormat;
        }

    }
}