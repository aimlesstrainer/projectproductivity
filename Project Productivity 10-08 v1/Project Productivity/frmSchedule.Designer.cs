namespace Project_Productivity
{
    partial class frmSchedule
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
            this.btnScheduleReturn = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lstboxScheduled = new System.Windows.Forms.ListBox();
            this.btnScheduleRemove = new System.Windows.Forms.Button();
            this.btnScheduleAdd = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.comDay = new System.Windows.Forms.ComboBox();
            this.radWork = new System.Windows.Forms.RadioButton();
            this.radBreak = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnScheduleReturn
            // 
            this.btnScheduleReturn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleReturn.Location = new System.Drawing.Point(272, 349);
            this.btnScheduleReturn.Name = "btnScheduleReturn";
            this.btnScheduleReturn.Size = new System.Drawing.Size(150, 25);
            this.btnScheduleReturn.TabIndex = 22;
            this.btnScheduleReturn.Text = "Return";
            this.btnScheduleReturn.UseVisualStyleBackColor = true;
            this.btnScheduleReturn.Click += new System.EventHandler(this.btnScheduleReturn_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(43, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(350, 23);
            this.lblHeading.TabIndex = 21;
            this.lblHeading.Text = "Schedule work and break times";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstboxScheduled
            // 
            this.lstboxScheduled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxScheduled.FormattingEnabled = true;
            this.lstboxScheduled.ItemHeight = 18;
            this.lstboxScheduled.Location = new System.Drawing.Point(-1, 42);
            this.lstboxScheduled.Name = "lstboxScheduled";
            this.lstboxScheduled.Size = new System.Drawing.Size(436, 202);
            this.lstboxScheduled.TabIndex = 20;
            // 
            // btnScheduleRemove
            // 
            this.btnScheduleRemove.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleRemove.Location = new System.Drawing.Point(140, 250);
            this.btnScheduleRemove.Name = "btnScheduleRemove";
            this.btnScheduleRemove.Size = new System.Drawing.Size(150, 25);
            this.btnScheduleRemove.TabIndex = 19;
            this.btnScheduleRemove.Text = "Remove Selected";
            this.btnScheduleRemove.UseVisualStyleBackColor = true;
            this.btnScheduleRemove.Click += new System.EventHandler(this.btnScheduleRemove_Click);
            // 
            // btnScheduleAdd
            // 
            this.btnScheduleAdd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleAdd.Location = new System.Drawing.Point(272, 321);
            this.btnScheduleAdd.Name = "btnScheduleAdd";
            this.btnScheduleAdd.Size = new System.Drawing.Size(150, 25);
            this.btnScheduleAdd.TabIndex = 18;
            this.btnScheduleAdd.Text = "Schedule Time";
            this.btnScheduleAdd.UseVisualStyleBackColor = true;
            this.btnScheduleAdd.Click += new System.EventHandler(this.btnScheduleAdd_Click);
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(12, 297);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(38, 25);
            this.lblDay.TabIndex = 23;
            this.lblDay.Text = "Day: ";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comDay
            // 
            this.comDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDay.FormattingEnabled = true;
            this.comDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comDay.Location = new System.Drawing.Point(56, 297);
            this.comDay.Name = "comDay";
            this.comDay.Size = new System.Drawing.Size(171, 25);
            this.comDay.TabIndex = 24;
            this.comDay.Text = "Monday";
            // 
            // radWork
            // 
            this.radWork.AutoSize = true;
            this.radWork.Checked = true;
            this.radWork.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWork.Location = new System.Drawing.Point(15, 353);
            this.radWork.Name = "radWork";
            this.radWork.Size = new System.Drawing.Size(107, 21);
            this.radWork.TabIndex = 25;
            this.radWork.TabStop = true;
            this.radWork.Text = "Work Period";
            this.radWork.UseVisualStyleBackColor = true;
            // 
            // radBreak
            // 
            this.radBreak.AutoSize = true;
            this.radBreak.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBreak.Location = new System.Drawing.Point(128, 353);
            this.radBreak.Name = "radBreak";
            this.radBreak.Size = new System.Drawing.Size(110, 21);
            this.radBreak.TabIndex = 26;
            this.radBreak.TabStop = true;
            this.radBreak.Text = "Break Period";
            this.radBreak.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 325);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 25);
            this.lblTime.TabIndex = 27;
            this.lblTime.Text = "Time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(56, 325);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(75, 25);
            this.txtStartTime.TabIndex = 28;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.Location = new System.Drawing.Point(152, 325);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(75, 25);
            this.txtEndTime.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "to";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.radBreak);
            this.Controls.Add(this.radWork);
            this.Controls.Add(this.comDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.btnScheduleReturn);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lstboxScheduled);
            this.Controls.Add(this.btnScheduleRemove);
            this.Controls.Add(this.btnScheduleAdd);
            this.Name = "frmSchedule";
            this.Text = "Schedule Times";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScheduleReturn;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ListBox lstboxScheduled;
        private System.Windows.Forms.Button btnScheduleRemove;
        private System.Windows.Forms.Button btnScheduleAdd;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox comDay;
        private System.Windows.Forms.RadioButton radWork;
        private System.Windows.Forms.RadioButton radBreak;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label1;
    }
}