namespace XYGetAlpha
{
    public partial class Form1 : Form
    {
        public string filePath;
        private static System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // when textbox changes
            filePath = textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // starts conversion of file to coordinates
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            // get all coordinates
            List<Coord> coordList = Program.GetCoordinates(filePath);
            // add it to a string
            string coordListString = "";
            foreach (Coord coord in coordList)
            {
                coordListString += coord.ToString();
            }

            // print string on outputTextBox
            outputBox.Text = coordListString;
            pictureBox1.Image = Image.FromFile(filePath);
        }

        private void button2_Click(object sender, EventArgs e)
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
                    // tell user invalid search path
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // sets clipboard to desired coordinates
            Clipboard.SetText(outputBox.Text);
            MessageBox.Show("Coordinates copied to clipboard.");
        }

        private void comboBoxColorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // color filter select
            if (comboBoxColorSelect.SelectedIndex == 0) // 0 is black 1 is white
            {
                Program.highpass = false;
            } else
            {
                Program.highpass = true;
            }
        }

        
    }
}