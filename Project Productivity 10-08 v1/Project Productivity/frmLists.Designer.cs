namespace Project_Productivity
{
    partial class frmLists
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
            this.lblHeading1 = new System.Windows.Forms.Label();
            this.lblHeading3 = new System.Windows.Forms.Label();
            this.lstboxAppBlacklist = new System.Windows.Forms.ListBox();
            this.lstboxWebsites = new System.Windows.Forms.ListBox();
            this.txtSearchBlacklist = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.btnWebsiteRemove = new System.Windows.Forms.Button();
            this.btnWebsiteAdd = new System.Windows.Forms.Button();
            this.btnListsReturn = new System.Windows.Forms.Button();
            this.btnBlacklistRemove = new System.Windows.Forms.Button();
            this.btnBlacklistAdd = new System.Windows.Forms.Button();
            this.txtBlacklist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading1
            // 
            this.lblHeading1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading1.Location = new System.Drawing.Point(12, 9);
            this.lblHeading1.Name = "lblHeading1";
            this.lblHeading1.Size = new System.Drawing.Size(300, 25);
            this.lblHeading1.TabIndex = 0;
            this.lblHeading1.Text = "Application Blacklist";
            this.lblHeading1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeading3
            // 
            this.lblHeading3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading3.Location = new System.Drawing.Point(472, 9);
            this.lblHeading3.Name = "lblHeading3";
            this.lblHeading3.Size = new System.Drawing.Size(300, 25);
            this.lblHeading3.TabIndex = 1;
            this.lblHeading3.Text = "Website Whitelist";
            this.lblHeading3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstboxAppBlacklist
            // 
            this.lstboxAppBlacklist.FormattingEnabled = true;
            this.lstboxAppBlacklist.Location = new System.Drawing.Point(12, 37);
            this.lstboxAppBlacklist.Name = "lstboxAppBlacklist";
            this.lstboxAppBlacklist.Size = new System.Drawing.Size(300, 316);
            this.lstboxAppBlacklist.TabIndex = 3;
            // 
            // lstboxWebsites
            // 
            this.lstboxWebsites.FormattingEnabled = true;
            this.lstboxWebsites.Location = new System.Drawing.Point(472, 37);
            this.lstboxWebsites.Name = "lstboxWebsites";
            this.lstboxWebsites.Size = new System.Drawing.Size(300, 277);
            this.lstboxWebsites.TabIndex = 5;
            // 
            // txtSearchBlacklist
            // 
            this.txtSearchBlacklist.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBlacklist.Location = new System.Drawing.Point(12, 353);
            this.txtSearchBlacklist.Name = "txtSearchBlacklist";
            this.txtSearchBlacklist.Size = new System.Drawing.Size(300, 32);
            this.txtSearchBlacklist.TabIndex = 6;
            this.txtSearchBlacklist.Text = "Search...";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(472, 352);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(300, 32);
            this.txtWebsite.TabIndex = 7;
            // 
            // btnWebsiteRemove
            // 
            this.btnWebsiteRemove.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebsiteRemove.Location = new System.Drawing.Point(472, 314);
            this.btnWebsiteRemove.Name = "btnWebsiteRemove";
            this.btnWebsiteRemove.Size = new System.Drawing.Size(300, 30);
            this.btnWebsiteRemove.TabIndex = 9;
            this.btnWebsiteRemove.Text = "Remove Website";
            this.btnWebsiteRemove.UseVisualStyleBackColor = true;
            this.btnWebsiteRemove.Click += new System.EventHandler(this.btnWebsiteRemove_Click);
            // 
            // btnWebsiteAdd
            // 
            this.btnWebsiteAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebsiteAdd.Location = new System.Drawing.Point(472, 384);
            this.btnWebsiteAdd.Name = "btnWebsiteAdd";
            this.btnWebsiteAdd.Size = new System.Drawing.Size(300, 30);
            this.btnWebsiteAdd.TabIndex = 10;
            this.btnWebsiteAdd.Text = "Add Website";
            this.btnWebsiteAdd.UseVisualStyleBackColor = true;
            this.btnWebsiteAdd.Click += new System.EventHandler(this.btnWebsiteAdd_Click);
            // 
            // btnListsReturn
            // 
            this.btnListsReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListsReturn.Location = new System.Drawing.Point(672, 420);
            this.btnListsReturn.Name = "btnListsReturn";
            this.btnListsReturn.Size = new System.Drawing.Size(100, 30);
            this.btnListsReturn.TabIndex = 11;
            this.btnListsReturn.Text = "Return";
            this.btnListsReturn.UseVisualStyleBackColor = true;
            this.btnListsReturn.Click += new System.EventHandler(this.btnListsReturn_Click);
            // 
            // btnBlacklistRemove
            // 
            this.btnBlacklistRemove.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlacklistRemove.Location = new System.Drawing.Point(162, 416);
            this.btnBlacklistRemove.Name = "btnBlacklistRemove";
            this.btnBlacklistRemove.Size = new System.Drawing.Size(150, 25);
            this.btnBlacklistRemove.TabIndex = 15;
            this.btnBlacklistRemove.Text = "Remove Selected";
            this.btnBlacklistRemove.UseVisualStyleBackColor = true;
            this.btnBlacklistRemove.Click += new System.EventHandler(this.btnBlacklistRemove_Click);
            // 
            // btnBlacklistAdd
            // 
            this.btnBlacklistAdd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlacklistAdd.Location = new System.Drawing.Point(12, 416);
            this.btnBlacklistAdd.Name = "btnBlacklistAdd";
            this.btnBlacklistAdd.Size = new System.Drawing.Size(150, 25);
            this.btnBlacklistAdd.TabIndex = 14;
            this.btnBlacklistAdd.Text = "Add Application";
            this.btnBlacklistAdd.UseVisualStyleBackColor = true;
            this.btnBlacklistAdd.Click += new System.EventHandler(this.btnBlacklistAdd_Click);
            // 
            // txtBlacklist
            // 
            this.txtBlacklist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlacklist.Location = new System.Drawing.Point(12, 391);
            this.txtBlacklist.Name = "txtBlacklist";
            this.txtBlacklist.Size = new System.Drawing.Size(300, 25);
            this.txtBlacklist.TabIndex = 13;
            // 
            // frmLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btnBlacklistRemove);
            this.Controls.Add(this.btnBlacklistAdd);
            this.Controls.Add(this.txtBlacklist);
            this.Controls.Add(this.btnListsReturn);
            this.Controls.Add(this.btnWebsiteAdd);
            this.Controls.Add(this.btnWebsiteRemove);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtSearchBlacklist);
            this.Controls.Add(this.lstboxWebsites);
            this.Controls.Add(this.lstboxAppBlacklist);
            this.Controls.Add(this.lblHeading3);
            this.Controls.Add(this.lblHeading1);
            this.Name = "frmLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black and Whitelists";
            this.Load += new System.EventHandler(this.frmLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading1;
        private System.Windows.Forms.Label lblHeading3;
        private System.Windows.Forms.ListBox lstboxAppBlacklist;
        private System.Windows.Forms.ListBox lstboxWebsites;
        private System.Windows.Forms.TextBox txtSearchBlacklist;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Button btnWebsiteRemove;
        private System.Windows.Forms.Button btnWebsiteAdd;
        private System.Windows.Forms.Button btnListsReturn;
        private System.Windows.Forms.Button btnBlacklistRemove;
        private System.Windows.Forms.Button btnBlacklistAdd;
        private System.Windows.Forms.TextBox txtBlacklist;
    }
}