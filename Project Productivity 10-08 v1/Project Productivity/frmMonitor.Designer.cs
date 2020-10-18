namespace Project_Productivity
{
    partial class frmMonitor
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkTimer = new System.Windows.Forms.CheckBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.btnMonitorStart = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnMonitorReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Start Monitoring";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkTimer
            // 
            this.chkTimer.AutoSize = true;
            this.chkTimer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimer.Location = new System.Drawing.Point(60, 58);
            this.chkTimer.Name = "chkTimer";
            this.chkTimer.Size = new System.Drawing.Size(125, 21);
            this.chkTimer.TabIndex = 5;
            this.chkTimer.Text = "Start with timer";
            this.chkTimer.UseVisualStyleBackColor = true;
            this.chkTimer.CheckedChanged += new System.EventHandler(this.chkTimer_CheckedChanged);
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(71, 85);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(40, 29);
            this.txtHour.TabIndex = 6;
            this.txtHour.Text = "00";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHour.Visible = false;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(126, 85);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(40, 29);
            this.txtMin.TabIndex = 7;
            this.txtMin.Text = "00";
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMin.Visible = false;
            // 
            // lblColon1
            // 
            this.lblColon1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon1.Location = new System.Drawing.Point(111, 85);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(15, 29);
            this.lblColon1.TabIndex = 9;
            this.lblColon1.Text = ":";
            this.lblColon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblColon1.Visible = false;
            // 
            // btnMonitorStart
            // 
            this.btnMonitorStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitorStart.Location = new System.Drawing.Point(6, 145);
            this.btnMonitorStart.Name = "btnMonitorStart";
            this.btnMonitorStart.Size = new System.Drawing.Size(80, 25);
            this.btnMonitorStart.TabIndex = 10;
            this.btnMonitorStart.Text = "Start";
            this.btnMonitorStart.UseVisualStyleBackColor = true;
            this.btnMonitorStart.Click += new System.EventHandler(this.btnMonitorStart_Click);
            // 
            // lblHour
            // 
            this.lblHour.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(71, 117);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(40, 15);
            this.lblHour.TabIndex = 13;
            this.lblHour.Text = "hr";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHour.Visible = false;
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(126, 117);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(40, 15);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "min";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMin.Visible = false;
            // 
            // btnMonitorReturn
            // 
            this.btnMonitorReturn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitorReturn.Location = new System.Drawing.Point(148, 145);
            this.btnMonitorReturn.Name = "btnMonitorReturn";
            this.btnMonitorReturn.Size = new System.Drawing.Size(80, 25);
            this.btnMonitorReturn.TabIndex = 16;
            this.btnMonitorReturn.Text = "Return";
            this.btnMonitorReturn.UseVisualStyleBackColor = true;
            this.btnMonitorReturn.Click += new System.EventHandler(this.btnMonitorReturn_Click);
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 177);
            this.Controls.Add(this.btnMonitorReturn);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.btnMonitorStart);
            this.Controls.Add(this.lblColon1);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.chkTimer);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Monitoring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkTimer;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.Button btnMonitorStart;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnMonitorReturn;
    }
}