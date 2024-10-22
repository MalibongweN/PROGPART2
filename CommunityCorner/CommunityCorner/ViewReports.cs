using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics; 
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CommunityCorner
{
    public partial class ViewReports : Form
    {
        public ViewReports()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            //Adds data to necessary columns
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Columns.Add("Description", "Description");
            DataGridViewButtonColumn mediaColumn = new DataGridViewButtonColumn();
            mediaColumn.Name = "Media";
            mediaColumn.HeaderText = "View Media";
            mediaColumn.Text = "View";
            mediaColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(mediaColumn);

            foreach (var issue in Form1.issueReports)
            {
                dataGridView1.Rows.Add(issue.Location, issue.Category, issue.Description, "View");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Checks if the click is on the media button column
            if (e.ColumnIndex == 3) 
            {
                string filePath = Form1.issueReports.ElementAt(e.RowIndex).MediaFilePath;
                if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
                {
                    Process.Start(filePath); 
                }
                else
                {
                    MessageBox.Show("No media attached for this issue or file not found.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
}
