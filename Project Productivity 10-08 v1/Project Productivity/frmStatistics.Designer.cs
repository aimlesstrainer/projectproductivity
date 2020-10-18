namespace Project_Productivity
{
    partial class frmStatistics
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
            this.components = new System.ComponentModel.Container();
            this.lblMonitoring = new System.Windows.Forms.Label();
            this.btnStatisticsReturn = new System.Windows.Forms.Button();
            this.lblCategory1 = new System.Windows.Forms.Label();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.lblCategory4 = new System.Windows.Forms.Label();
            this.lblCategory3 = new System.Windows.Forms.Label();
            this.lblCategory5 = new System.Windows.Forms.Label();
            this.lblCategory6 = new System.Windows.Forms.Label();
            this.lblCategory7 = new System.Windows.Forms.Label();
            this.lblCategory8 = new System.Windows.Forms.Label();
            this.lblCategory11 = new System.Windows.Forms.Label();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.lblTimeProductive = new System.Windows.Forms.Label();
            this.lblTimeUnproductive = new System.Windows.Forms.Label();
            this.lblAttemptUnproductive = new System.Windows.Forms.Label();
            this.lblTimeMonitored = new System.Windows.Forms.Label();
            this.lblBreakPeriodsUsed = new System.Windows.Forms.Label();
            this.lblTimeOnBreak = new System.Windows.Forms.Label();
            this.lblToDosMade = new System.Windows.Forms.Label();
            this.lblRemindersMade = new System.Windows.Forms.Label();
            this.lblDaysSinceUse = new System.Windows.Forms.Label();
            this.tmrStatsUpdater = new System.Windows.Forms.Timer(this.components);
            this.lblCategory12 = new System.Windows.Forms.Label();
            this.lblSessionLength = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCategory13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMonitoring
            // 
            this.lblMonitoring.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitoring.Location = new System.Drawing.Point(115, 9);
            this.lblMonitoring.Name = "lblMonitoring";
            this.lblMonitoring.Size = new System.Drawing.Size(150, 25);
            this.lblMonitoring.TabIndex = 3;
            this.lblMonitoring.Text = "Statistics";
            this.lblMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStatisticsReturn
            // 
            this.btnStatisticsReturn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticsReturn.Location = new System.Drawing.Point(150, 325);
            this.btnStatisticsReturn.Name = "btnStatisticsReturn";
            this.btnStatisticsReturn.Size = new System.Drawing.Size(80, 25);
            this.btnStatisticsReturn.TabIndex = 5;
            this.btnStatisticsReturn.Text = "Return";
            this.btnStatisticsReturn.UseVisualStyleBackColor = true;
            this.btnStatisticsReturn.Click += new System.EventHandler(this.btnStatisticsReturn_Click);
            // 
            // lblCategory1
            // 
            this.lblCategory1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory1.Location = new System.Drawing.Point(12, 44);
            this.lblCategory1.Name = "lblCategory1";
            this.lblCategory1.Size = new System.Drawing.Size(165, 15);
            this.lblCategory1.TabIndex = 6;
            this.lblCategory1.Text = "Time spent being productive:";
            this.lblCategory1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory2
            // 
            this.lblCategory2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory2.Location = new System.Drawing.Point(12, 59);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(180, 15);
            this.lblCategory2.TabIndex = 7;
            this.lblCategory2.Text = "Time spent being unproductive:";
            this.lblCategory2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory4
            // 
            this.lblCategory4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory4.Location = new System.Drawing.Point(12, 89);
            this.lblCategory4.Name = "lblCategory4";
            this.lblCategory4.Size = new System.Drawing.Size(196, 15);
            this.lblCategory4.TabIndex = 8;
            this.lblCategory4.Text = "Time spent while monitoring is on:";
            this.lblCategory4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory3
            // 
            this.lblCategory3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory3.Location = new System.Drawing.Point(12, 74);
            this.lblCategory3.Name = "lblCategory3";
            this.lblCategory3.Size = new System.Drawing.Size(161, 15);
            this.lblCategory3.TabIndex = 9;
            this.lblCategory3.Text = "Attempts to be unproductive:";
            this.lblCategory3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory5
            // 
            this.lblCategory5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory5.Location = new System.Drawing.Point(12, 116);
            this.lblCategory5.Name = "lblCategory5";
            this.lblCategory5.Size = new System.Drawing.Size(118, 15);
            this.lblCategory5.TabIndex = 11;
            this.lblCategory5.Text = "Break periods used:";
            this.lblCategory5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory6
            // 
            this.lblCategory6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory6.Location = new System.Drawing.Point(12, 131);
            this.lblCategory6.Name = "lblCategory6";
            this.lblCategory6.Size = new System.Drawing.Size(123, 15);
            this.lblCategory6.TabIndex = 12;
            this.lblCategory6.Text = "Time spent on break:";
            this.lblCategory6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory7
            // 
            this.lblCategory7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory7.Location = new System.Drawing.Point(12, 163);
            this.lblCategory7.Name = "lblCategory7";
            this.lblCategory7.Size = new System.Drawing.Size(107, 15);
            this.lblCategory7.TabIndex = 13;
            this.lblCategory7.Text = "Reminders made:";
            this.lblCategory7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory8
            // 
            this.lblCategory8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory8.Location = new System.Drawing.Point(12, 178);
            this.lblCategory8.Name = "lblCategory8";
            this.lblCategory8.Size = new System.Drawing.Size(83, 15);
            this.lblCategory8.TabIndex = 14;
            this.lblCategory8.Text = "To-dos made:";
            this.lblCategory8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory11
            // 
            this.lblCategory11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory11.Location = new System.Drawing.Point(12, 210);
            this.lblCategory11.Name = "lblCategory11";
            this.lblCategory11.Size = new System.Drawing.Size(213, 15);
            this.lblCategory11.TabIndex = 16;
            this.lblCategory11.Text = "Days since initial use of this program:";
            this.lblCategory11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.Location = new System.Drawing.Point(15, 285);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(350, 30);
            this.lblDisclaimer.TabIndex = 17;
            this.lblDisclaimer.Text = "Productive/unproductive and application/website times are only calculated when mo" +
    "nitoring is on.";
            this.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeProductive
            // 
            this.lblTimeProductive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeProductive.Location = new System.Drawing.Point(174, 44);
            this.lblTimeProductive.Name = "lblTimeProductive";
            this.lblTimeProductive.Size = new System.Drawing.Size(75, 15);
            this.lblTimeProductive.TabIndex = 18;
            this.lblTimeProductive.Text = "00:00:00";
            this.lblTimeProductive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeUnproductive
            // 
            this.lblTimeUnproductive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeUnproductive.Location = new System.Drawing.Point(189, 59);
            this.lblTimeUnproductive.Name = "lblTimeUnproductive";
            this.lblTimeUnproductive.Size = new System.Drawing.Size(75, 15);
            this.lblTimeUnproductive.TabIndex = 19;
            this.lblTimeUnproductive.Text = "00:00:00";
            this.lblTimeUnproductive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttemptUnproductive
            // 
            this.lblAttemptUnproductive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttemptUnproductive.Location = new System.Drawing.Point(170, 74);
            this.lblAttemptUnproductive.Name = "lblAttemptUnproductive";
            this.lblAttemptUnproductive.Size = new System.Drawing.Size(75, 15);
            this.lblAttemptUnproductive.TabIndex = 20;
            this.lblAttemptUnproductive.Text = "0";
            this.lblAttemptUnproductive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeMonitored
            // 
            this.lblTimeMonitored.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeMonitored.Location = new System.Drawing.Point(205, 89);
            this.lblTimeMonitored.Name = "lblTimeMonitored";
            this.lblTimeMonitored.Size = new System.Drawing.Size(75, 15);
            this.lblTimeMonitored.TabIndex = 21;
            this.lblTimeMonitored.Text = "00:00:00";
            this.lblTimeMonitored.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBreakPeriodsUsed
            // 
            this.lblBreakPeriodsUsed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakPeriodsUsed.Location = new System.Drawing.Point(127, 116);
            this.lblBreakPeriodsUsed.Name = "lblBreakPeriodsUsed";
            this.lblBreakPeriodsUsed.Size = new System.Drawing.Size(75, 15);
            this.lblBreakPeriodsUsed.TabIndex = 22;
            this.lblBreakPeriodsUsed.Text = "0";
            this.lblBreakPeriodsUsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeOnBreak
            // 
            this.lblTimeOnBreak.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOnBreak.Location = new System.Drawing.Point(132, 131);
            this.lblTimeOnBreak.Name = "lblTimeOnBreak";
            this.lblTimeOnBreak.Size = new System.Drawing.Size(75, 15);
            this.lblTimeOnBreak.TabIndex = 23;
            this.lblTimeOnBreak.Text = "00:00:00";
            this.lblTimeOnBreak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToDosMade
            // 
            this.lblToDosMade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDosMade.Location = new System.Drawing.Point(92, 178);
            this.lblToDosMade.Name = "lblToDosMade";
            this.lblToDosMade.Size = new System.Drawing.Size(75, 15);
            this.lblToDosMade.TabIndex = 24;
            this.lblToDosMade.Text = "0";
            this.lblToDosMade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemindersMade
            // 
            this.lblRemindersMade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemindersMade.Location = new System.Drawing.Point(116, 163);
            this.lblRemindersMade.Name = "lblRemindersMade";
            this.lblRemindersMade.Size = new System.Drawing.Size(75, 15);
            this.lblRemindersMade.TabIndex = 25;
            this.lblRemindersMade.Text = "0";
            this.lblRemindersMade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDaysSinceUse
            // 
            this.lblDaysSinceUse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysSinceUse.Location = new System.Drawing.Point(222, 210);
            this.lblDaysSinceUse.Name = "lblDaysSinceUse";
            this.lblDaysSinceUse.Size = new System.Drawing.Size(75, 15);
            this.lblDaysSinceUse.TabIndex = 28;
            this.lblDaysSinceUse.Text = "0";
            this.lblDaysSinceUse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrStatsUpdater
            // 
            this.tmrStatsUpdater.Interval = 250;
            this.tmrStatsUpdater.Tick += new System.EventHandler(this.tmrStatsUpdater_Tick);
            // 
            // lblCategory12
            // 
            this.lblCategory12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory12.Location = new System.Drawing.Point(12, 242);
            this.lblCategory12.Name = "lblCategory12";
            this.lblCategory12.Size = new System.Drawing.Size(136, 15);
            this.lblCategory12.TabIndex = 29;
            this.lblCategory12.Text = "Current session length:";
            this.lblCategory12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSessionLength
            // 
            this.lblSessionLength.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionLength.Location = new System.Drawing.Point(145, 242);
            this.lblSessionLength.Name = "lblSessionLength";
            this.lblSessionLength.Size = new System.Drawing.Size(75, 15);
            this.lblSessionLength.TabIndex = 30;
            this.lblSessionLength.Text = "00:00:00";
            this.lblSessionLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Location = new System.Drawing.Point(245, 257);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(75, 15);
            this.lblTotalTime.TabIndex = 32;
            this.lblTotalTime.Text = "00:00:00";
            this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory13
            // 
            this.lblCategory13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory13.Location = new System.Drawing.Point(12, 257);
            this.lblCategory13.Name = "lblCategory13";
            this.lblCategory13.Size = new System.Drawing.Size(236, 15);
            this.lblCategory13.TabIndex = 31;
            this.lblCategory13.Text = "Total time spent using Project Productivity:";
            this.lblCategory13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblCategory13);
            this.Controls.Add(this.lblSessionLength);
            this.Controls.Add(this.lblCategory12);
            this.Controls.Add(this.lblDaysSinceUse);
            this.Controls.Add(this.lblRemindersMade);
            this.Controls.Add(this.lblToDosMade);
            this.Controls.Add(this.lblTimeOnBreak);
            this.Controls.Add(this.lblBreakPeriodsUsed);
            this.Controls.Add(this.lblTimeMonitored);
            this.Controls.Add(this.lblAttemptUnproductive);
            this.Controls.Add(this.lblTimeUnproductive);
            this.Controls.Add(this.lblTimeProductive);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.lblCategory11);
            this.Controls.Add(this.lblCategory8);
            this.Controls.Add(this.lblCategory7);
            this.Controls.Add(this.lblCategory6);
            this.Controls.Add(this.lblCategory5);
            this.Controls.Add(this.lblCategory3);
            this.Controls.Add(this.lblCategory4);
            this.Controls.Add(this.lblCategory2);
            this.Controls.Add(this.lblCategory1);
            this.Controls.Add(this.btnStatisticsReturn);
            this.Controls.Add(this.lblMonitoring);
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMonitoring;
        private System.Windows.Forms.Button btnStatisticsReturn;
        private System.Windows.Forms.Label lblCategory1;
        private System.Windows.Forms.Label lblCategory2;
        private System.Windows.Forms.Label lblCategory4;
        private System.Windows.Forms.Label lblCategory3;
        private System.Windows.Forms.Label lblCategory5;
        private System.Windows.Forms.Label lblCategory6;
        private System.Windows.Forms.Label lblCategory7;
        private System.Windows.Forms.Label lblCategory8;
        private System.Windows.Forms.Label lblCategory11;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.Label lblTimeProductive;
        private System.Windows.Forms.Label lblTimeUnproductive;
        private System.Windows.Forms.Label lblAttemptUnproductive;
        private System.Windows.Forms.Label lblTimeMonitored;
        private System.Windows.Forms.Label lblBreakPeriodsUsed;
        private System.Windows.Forms.Label lblTimeOnBreak;
        private System.Windows.Forms.Label lblToDosMade;
        private System.Windows.Forms.Label lblRemindersMade;
        private System.Windows.Forms.Label lblDaysSinceUse;
        private System.Windows.Forms.Timer tmrStatsUpdater;
        private System.Windows.Forms.Label lblCategory12;
        private System.Windows.Forms.Label lblSessionLength;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblCategory13;
    }
}