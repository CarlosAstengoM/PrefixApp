namespace PrefixApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    folderTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void prefixButton_Click(object sender, EventArgs e)
        {
            string folderPath = folderTextBox.Text;
            string prefix = prefixTextBox.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The selected folder does not exist.");
                return;
            }

            try
            {
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    string fileName = Path.GetFileName(file);
                    string newFileName = prefix + fileName;
                    string newFilePath = Path.Combine(folderPath, newFileName);

                    File.Move(file, newFilePath);
                }

                MessageBox.Show("File names successfully prefixed.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access to the selected folder or files is denied.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error renaming files: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            prefixTextBox.Text = "";
        }

        private void suffixBtn_Click(object sender, EventArgs e)
        {
            string folderPath = folderTextBox.Text;
            string suffix = suffixTextBox.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The selected folder does not exist.");
                return;
            }

            try
            {
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    string fileName = Path.GetFileName(file);
                    string newFileName = Path.GetFileNameWithoutExtension(file) + suffix + Path.GetExtension(file);
                    string newFilePath = Path.Combine(folderPath, newFileName);

                    File.Move(file, newFilePath);
                }

                MessageBox.Show("File names successfully suffixed.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access to the selected folder or files is denied.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error renaming files: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            suffixTextBox.Text = "";
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string folderPath = folderTextBox.Text;
            string searchText = searchTextBox.Text;
            string replaceText = replaceTextBox.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The selected folder does not exist.");
                return;
            }

            try
            {
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    string fileName = Path.GetFileName(file);
                    string newFileName = fileName.Replace(searchText, replaceText);
                    string newFilePath = Path.Combine(folderPath, newFileName);

                    File.Move(file, newFilePath);
                }

                MessageBox.Show("File names successfully renamed with replaced text.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access to the selected folder or files is denied.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error renaming files: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            searchTextBox.Text = "";
            replaceTextBox.Text = "";
        }
    }
}