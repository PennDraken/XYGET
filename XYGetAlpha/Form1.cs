using System.Text;

namespace XYGetAlpha
{
    public partial class Form1 : Form
    {
        public string filePath;
        public StringBuilder formattedOutputCoords = new StringBuilder();
        int progressBarMaxWidth = 848;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxWithFilePath(object sender, EventArgs e)
        {
            // when textbox changes
            filePath = textBox1.Text;
        }

        private async void buttonGetCoordinates_Click(object sender, EventArgs e)
        {
            // starts conversion of file to coordinates
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            // get all coordinates to a string
            Bitmap img = Program.GetBitmapFromFilepath(filePath);
            Task task1 = new Task(() => formattedOutputCoords = Program.GetCoordinatesOfImage(img));
            task1.Start();

            while (!task1.IsCompleted)
            {
                // doesn't show updates
                progressBar.Width = Program.pixelsProcessedInImage / Program.totalPixelsInImage * progressBarMaxWidth;
            }

            // print string on outputTextBox
            if (formattedOutputCoords.Length > outputBoxContainingCoords.MaxLength)
                outputBoxContainingCoords.Text = formattedOutputCoords.ToString().Substring(0, outputBoxContainingCoords.MaxLength);
            else
                outputBoxContainingCoords.Text = formattedOutputCoords.ToString();

            progressBar.Width = 0;
            pictureBoxPreview.Image = Image.FromFile(filePath);
        }

        private void buttonOpenFileWindow_Click(object sender, EventArgs e)
        {
            // opens explorer to find file
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    textBox1.Text = file;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error: Likely invalid search path.");
                }
            }
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            // sets clipboard to desired coordinates
            Clipboard.SetText(formattedOutputCoords.ToString());
            MessageBox.Show("Coordinates copied to clipboard.");
        }

        private void comboBoxColorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // color filter select
            if (comboBoxColorSelect.SelectedIndex == 0) // 0 is dark, 1 is bright
            {
                Program.highpass = false;
            } else
            {
                Program.highpass = true;
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}