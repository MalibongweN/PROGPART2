using System.Drawing;
using System.Windows.Forms;

namespace CommunityCorner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       
 #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocalEvent = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnReqServStat = new System.Windows.Forms.Button();
            this.btnViewRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Community Corner";
            // 
            // btnLocalEvent
            // 
            this.btnLocalEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalEvent.Location = new System.Drawing.Point(289, 186);
            this.btnLocalEvent.Name = "btnLocalEvent";
            this.btnLocalEvent.Size = new System.Drawing.Size(187, 40);
            this.btnLocalEvent.TabIndex = 1;
            this.btnLocalEvent.Text = "Local Events";
            this.btnLocalEvent.UseVisualStyleBackColor = true;
            this.btnLocalEvent.Click += new System.EventHandler(this.btnLocalEvent_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(52, 186);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(187, 40);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report Issues";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReqServStat
            // 
            this.btnReqServStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqServStat.Location = new System.Drawing.Point(543, 186);
            this.btnReqServStat.Name = "btnReqServStat";
            this.btnReqServStat.Size = new System.Drawing.Size(187, 40);
            this.btnReqServStat.TabIndex = 1;
            this.btnReqServStat.Text = "Request Service Status";
            this.btnReqServStat.UseVisualStyleBackColor = true;
            this.btnReqServStat.Click += new System.EventHandler(this.btnReqServStat_Click);
            // 
            // btnViewRep
            // 
            this.btnViewRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRep.Location = new System.Drawing.Point(686, 12);
            this.btnViewRep.Name = "btnViewRep";
            this.btnViewRep.Size = new System.Drawing.Size(97, 23);
            this.btnViewRep.TabIndex = 2;
            this.btnViewRep.Text = "View Reports";
            this.btnViewRep.UseVisualStyleBackColor = true;
            this.btnViewRep.Click += new System.EventHandler(this.btnViewRep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(790, 463);
            this.Controls.Add(this.btnViewRep);
            this.Controls.Add(this.btnReqServStat);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnLocalEvent);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Community Corner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnLocalEvent;
        private Button btnReport;
        private Button btnReqServStat;
        private Button btnViewRep;
    }
}

