using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityCorner
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }//nd of main method

    }//end of program class


    public class IssueReport
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaFilePath { get; set; }
        public DateTime ReportedOn { get; set; }

        public IssueReport(string location, string category, string description, string mediaFilePath)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaFilePath = mediaFilePath;
            ReportedOn = DateTime.Now;
        }//end of method

    }//end of issuereport class

}


//Code Attributes

//ProgrammingKnowledge2(2023) Create Your First C# Windows Forms Application using Visual Studio. https://www.youtube.com/watch?v=JSJ1JI2alJg.

//Dotnet-Bot (no date) LinkedList Class (System.Collections.Generic). https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-8.0.
