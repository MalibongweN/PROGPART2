using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CommunityCorner
{
    public partial class Report : Form
    {
        private string selectedFilePath = string.Empty;

        public Report()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Sanitation", "Roads", "Utilities", "Other" });
        }

        private void bthMedia_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = fileDialog.FileName;
                MessageBox.Show("File selected: " + selectedFilePath);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem.ToString();
            if (selectedCategory == "Other")
            {
                MessageBox.Show("Please provide a clear description of the issue.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string location = textBox1.Text;
            string category = comboBox1.SelectedItem?.ToString() ?? "";
            string description = richTextBox1.Text;

            //Checks if all required fields are filled
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            //Confirms submission
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit this issue?", "Confirm Submission", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //Adds issue to the LinkedList
            IssueReport newIssue = new IssueReport(location, category, description, selectedFilePath);
            Form1.issueReports.AddLast(newIssue);

            MessageBox.Show("Issue submitted successfully!");

            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
}
