namespace CommunityCorner
{
    partial class EventForm
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
            this.btnRecommend = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecommend
            // 
            this.btnRecommend.Location = new System.Drawing.Point(816, 44);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(115, 23);
            this.btnRecommend.TabIndex = 2;
            this.btnRecommend.Text = "Recommendations";
            this.btnRecommend.UseVisualStyleBackColor = true;
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(627, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(64, 47);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(564, 20);
            this.txtSearchCategory.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1195, 558);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(722, 45);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(953, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Location = new System.Drawing.Point(1060, 44);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(75, 23);
            this.btnNotifications.TabIndex = 8;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.BackgroundImage = global::CommunityCorner.Properties.Resources.thebackground;
            this.ClientSize = new System.Drawing.Size(1271, 660);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnRecommend);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.btnSearch);
            this.Name = "EventForm";
            this.Text = "Local Events and Announcements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRecommend;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNotifications;
    }
}