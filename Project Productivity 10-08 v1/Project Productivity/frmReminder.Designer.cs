namespace Project_Productivity
{
    partial class frmReminder
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
            this.dtpickerReminder = new System.Windows.Forms.DateTimePicker();
            this.txtReminder = new System.Windows.Forms.TextBox();
            this.btnReminderAdd = new System.Windows.Forms.Button();
            this.btnReminderRemove = new System.Windows.Forms.Button();
            this.lstboxReminders = new System.Windows.Forms.ListBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnReminderReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpickerReminder
            // 
            this.dtpickerReminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerReminder.Location = new System.Drawing.Point(56, 346);
            this.dtpickerReminder.Name = "dtpickerReminder";
            this.dtpickerReminder.Size = new System.Drawing.Size(255, 25);
            this.dtpickerReminder.TabIndex = 0;
            // 
            // txtReminder
            // 
            this.txtReminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReminder.Location = new System.Drawing.Point(12, 318);
            this.txtReminder.Name = "txtReminder";
            this.txtReminder.Size = new System.Drawing.Size(299, 25);
            this.txtReminder.TabIndex = 1;
            // 
            // btnReminderAdd
            // 
            this.btnReminderAdd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminderAdd.Location = new System.Drawing.Point(317, 318);
            this.btnReminderAdd.Name = "btnReminderAdd";
            this.btnReminderAdd.Size = new System.Drawing.Size(80, 53);
            this.btnReminderAdd.TabIndex = 2;
            this.btnReminderAdd.Text = "Add Reminder";
            this.btnReminderAdd.UseVisualStyleBackColor = true;
            this.btnReminderAdd.Click += new System.EventHandler(this.btnReminderAdd_Click);
            // 
            // btnReminderRemove
            // 
            this.btnReminderRemove.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminderRemove.Location = new System.Drawing.Point(165, 240);
            this.btnReminderRemove.Name = "btnReminderRemove";
            this.btnReminderRemove.Size = new System.Drawing.Size(150, 25);
            this.btnReminderRemove.TabIndex = 3;
            this.btnReminderRemove.Text = "Remove Selected";
            this.btnReminderRemove.UseVisualStyleBackColor = true;
            this.btnReminderRemove.Click += new System.EventHandler(this.btnReminderRemove_Click);
            // 
            // lstboxReminders
            // 
            this.lstboxReminders.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxReminders.FormattingEnabled = true;
            this.lstboxReminders.ItemHeight = 16;
            this.lstboxReminders.Location = new System.Drawing.Point(-1, 40);
            this.lstboxReminders.Name = "lstboxReminders";
            this.lstboxReminders.Size = new System.Drawing.Size(486, 196);
            this.lstboxReminders.TabIndex = 4;
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(130, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(220, 23);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "Manage Reminders";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(12, 346);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(43, 25);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Date:";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReminderReturn
            // 
            this.btnReminderReturn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminderReturn.Location = new System.Drawing.Point(403, 318);
            this.btnReminderReturn.Name = "btnReminderReturn";
            this.btnReminderReturn.Size = new System.Drawing.Size(75, 53);
            this.btnReminderReturn.TabIndex = 8;
            this.btnReminderReturn.Text = "Return";
            this.btnReminderReturn.UseVisualStyleBackColor = true;
            this.btnReminderReturn.Click += new System.EventHandler(this.btnReminderReturn_Click);
            // 
            // frmReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 386);
            this.Controls.Add(this.btnReminderReturn);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lstboxReminders);
            this.Controls.Add(this.btnReminderRemove);
            this.Controls.Add(this.btnReminderAdd);
            this.Controls.Add(this.txtReminder);
            this.Controls.Add(this.dtpickerReminder);
            this.Name = "frmReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpickerReminder;
        private System.Windows.Forms.TextBox txtReminder;
        private System.Windows.Forms.Button btnReminderAdd;
        private System.Windows.Forms.Button btnReminderRemove;
        private System.Windows.Forms.ListBox lstboxReminders;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnReminderReturn;
    }
}