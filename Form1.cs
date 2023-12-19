
namespace HealthyME2
{
    public partial class Form1 : Form
    {
        private const string FileExtension = ".txt";
        private string DefaultDirectory => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SavedTextFiles");

        private string GetFileNamefordate()
        {
            // Use the current date to generate a filename
            string date = DateTime.Now.ToString("yyyyMMdd");
            return Path.Combine(DefaultDirectory, $"{date}{FileExtension}");
        }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the contents of the textbox to a file with the current date as the filename
            string fileName = GetFileNamefordate();
            Directory.CreateDirectory(Path.GetDirectoryName(fileName)); // Create directory if it doesn't exist
            File.WriteAllText(fileName, textBox1.Text);
            MessageBox.Show($"Text saved successfully to {fileName}");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Open a file dialog to choose the file to load
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = DefaultDirectory;
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the contents from the selected file into the textbox
                    string fileName = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(fileName);
                    MessageBox.Show($"Text loaded successfully from {fileName}");
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            string checkboxName = checkbox.Name;

            // Show a message box with the current checkbox state
            string state = checkbox.Checked ? "checked" : "unchecked";
            MessageBox.Show($"Checkbox '{checkboxName}' is {state}.");
        }

        

        private void btnSaves_Click_1(object sender, EventArgs e)
        {
            // Save the message box contents to a text file
            string fileName = GetFileNamefordate();
            File.WriteAllText(fileName, MessageBox.Show(this, "Enter text to save:", "Save Text", MessageBoxButtons.OKCancel) == DialogResult.OK ? MessageBox.Show(this, "Enter text to save:", "Save Text", MessageBoxButtons.OKCancel).ToString() : "");
            MessageBox.Show("Text saved to file successfully!");
        }

        private void btnLoads_Click_1(object sender, EventArgs e)
        {
            // Load the contents from the text file into the message box
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = DefaultDirectory;
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the contents from the selected file into the textbox
                    string fileName = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(fileName);
                    MessageBox.Show($"Text loaded successfully from {fileName}");
                }
            }
        }
    }
}