using System;
using System.IO;
using System.Windows.Forms;
using Mp3Mashup.Utilities;

namespace Mp3Mashup
{
    public partial class MainForm : Form
    {
        #region Properties

        private string InputFile1
        {
            get => Input1TextBox.Text;
            set => Input1TextBox.Text = value;
        }

        private string InputFile2 {
            get => Input2TextBox.Text;
            set => Input2TextBox.Text = value;
        }

        private string OutputFile {
            get => OutputTextBox.Text;
            set => OutputTextBox.Text = value;
        }

        #endregion

        #region Properties

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void BrowseInput1Button_Click(object sender, EventArgs e)
        {
            InputFile1 = GetMp3FileFromDialog() ?? InputFile1;
        }

        private void BrowseInput2Button_Click(object sender, EventArgs e)
        {
            InputFile2 = GetMp3FileFromDialog() ?? InputFile2;
        }

        private void BrowseOutputButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog
            {
                DefaultExt = "mp3",
                Filter = @".MP3 Files|*.mp3",
                FileName = "mashup"
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                OutputFile = dialog.FileName;
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputFile1) ||
                string.IsNullOrWhiteSpace(InputFile2) ||
                string.IsNullOrWhiteSpace(OutputFile) ||
                !File.Exists(InputFile1) ||
                !File.Exists(InputFile2))
            {
                MessageBox.Show(
                    @"One or more fields are empty or incorrect", 
                    @"Error", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Mp3Utilities.CreateMashup(OutputFile, InputFile1, InputFile2);

            MessageBox.Show(
                @"Done!",
                @"Information:",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion

        #region Utilities

        private static string GetMp3FileFromDialog()
        {
            using (var dialog = new OpenFileDialog
            {
                DefaultExt = "mp3",
                Filter = @".MP3 Files|*.mp3"
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return null;
                }

                return dialog.FileName;
            }
        }

        #endregion
    }
}
