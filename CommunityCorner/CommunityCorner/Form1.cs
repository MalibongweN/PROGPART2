using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityCorner
{
    public partial class Form1 : Form
    {
        public static LinkedList<IssueReport> issueReports = new LinkedList<IssueReport>();

        public Form1()
        {
            InitializeComponent();
            
            
        }

        //to open report form
        private void btnReport_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report(); 
            reportForm.Show();
            this.Close();
        }

        //to open view reports 
        private void btnViewRep_Click(object sender, EventArgs e)
        {
            ViewReports viewReportsForm = new ViewReports(); 
            viewReportsForm.Show();
            this.Hide();
        }

        private void btnReqServStat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is coming soon!!");
        }

        private void btnLocalEvent_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Show();
            this.Hide();
        }


    }

}


//Attributions

//Ironsoftware. 2024. C# Priority Queue (How It Works For Developers). Iron Software LLC. Available from: https://ironpdf.com/blog/net-help/csharp-priority-queue-guide/ [Accessed 15 October 2024].
//Joe, B. 2020. Priority Queue with C# - Basilin Joe - Medium. Available from: https://medium.com/@basilin/priority-queue-with-c-7089f4898c8d [Accessed 15 October 2024].