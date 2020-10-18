namespace Project_Productivity
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuLists = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReminderToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReminder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblMonitoringStatus = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lstboxCurrentReminders = new System.Windows.Forms.ListBox();
            this.lstboxToDoList = new System.Windows.Forms.ListBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLists,
            this.mnuMonitor,
            this.mnuReminderToDo,
            this.mnuStatistics,
            this.mnuCalendar,
            this.mnuSchedule,
            this.mnuOptions,
            this.mnuHelp,
            this.mnuQuit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(784, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuLists
            // 
            this.mnuLists.Name = "mnuLists";
            this.mnuLists.Size = new System.Drawing.Size(101, 20);
            this.mnuLists.Text = "Black/Whitelists";
            this.mnuLists.Click += new System.EventHandler(this.mnuLists_Click);
            // 
            // mnuMonitor
            // 
            this.mnuMonitor.Name = "mnuMonitor";
            this.mnuMonitor.Size = new System.Drawing.Size(133, 20);
            this.mnuMonitor.Text = "Start/Stop Monitoring";
            this.mnuMonitor.Click += new System.EventHandler(this.mnuMonitor_Click);
            // 
            // mnuReminderToDo
            // 
            this.mnuReminderToDo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReminder,
            this.mnuToDo});
            this.mnuReminderToDo.Name = "mnuReminderToDo";
            this.mnuReminderToDo.Size = new System.Drawing.Size(111, 20);
            this.mnuReminderToDo.Text = "Reminders/to-dos";
            // 
            // mnuReminder
            // 
            this.mnuReminder.Name = "mnuReminder";
            this.mnuReminder.Size = new System.Drawing.Size(128, 22);
            this.mnuReminder.Text = "Reminders";
            this.mnuReminder.Click += new System.EventHandler(this.mnuReminder_Click);
            // 
            // mnuToDo
            // 
            this.mnuToDo.Name = "mnuToDo";
            this.mnuToDo.Size = new System.Drawing.Size(128, 22);
            this.mnuToDo.Text = "To-dos";
            this.mnuToDo.Click += new System.EventHandler(this.mnuToDo_Click);
            // 
            // mnuStatistics
            // 
            this.mnuStatistics.Name = "mnuStatistics";
            this.mnuStatistics.Size = new System.Drawing.Size(64, 20);
            this.mnuStatistics.Text = "Statistics";
            this.mnuStatistics.Click += new System.EventHandler(this.mnuStatistics_Click);
            // 
            // mnuCalendar
            // 
            this.mnuCalendar.Name = "mnuCalendar";
            this.mnuCalendar.Size = new System.Drawing.Size(65, 20);
            this.mnuCalendar.Text = "Calendar";
            this.mnuCalendar.Click += new System.EventHandler(this.mnuCalendar_Click);
            // 
            // mnuSchedule
            // 
            this.mnuSchedule.Name = "mnuSchedule";
            this.mnuSchedule.Size = new System.Drawing.Size(97, 20);
            this.mnuSchedule.Text = "Schedule Times";
            this.mnuSchedule.Click += new System.EventHandler(this.mnuSchedule_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(43, 20);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(42, 20);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(235, 49);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(320, 38);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Project Productivity";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonitoringStatus
            // 
            this.lblMonitoringStatus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitoringStatus.Location = new System.Drawing.Point(270, 142);
            this.lblMonitoringStatus.Name = "lblMonitoringStatus";
            this.lblMonitoringStatus.Size = new System.Drawing.Size(250, 25);
            this.lblMonitoringStatus.TabIndex = 2;
            this.lblMonitoringStatus.Text = "Monitoring active";
            this.lblMonitoringStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(295, 170);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(200, 25);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "23:59:59 left";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToDo
            // 
            this.lblToDo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDo.Location = new System.Drawing.Point(36, 242);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(200, 25);
            this.lblToDo.TabIndex = 4;
            this.lblToDo.Text = "To-do list:";
            this.lblToDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReminder
            // 
            this.lblReminder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.Location = new System.Drawing.Point(442, 242);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(214, 25);
            this.lblReminder.TabIndex = 5;
            this.lblReminder.Text = "Today\'s Reminders:";
            this.lblReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(263, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(260, 21);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Wednesday, 30 September 2018, 12:59 AM";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstboxCurrentReminders
            // 
            this.lstboxCurrentReminders.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxCurrentReminders.FormattingEnabled = true;
            this.lstboxCurrentReminders.ItemHeight = 16;
            this.lstboxCurrentReminders.Location = new System.Drawing.Point(434, 270);
            this.lstboxCurrentReminders.Name = "lstboxCurrentReminders";
            this.lstboxCurrentReminders.Size = new System.Drawing.Size(320, 196);
            this.lstboxCurrentReminders.TabIndex = 7;
            // 
            // lstboxToDoList
            // 
            this.lstboxToDoList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxToDoList.FormattingEnabled = true;
            this.lstboxToDoList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstboxToDoList.ItemHeight = 16;
            this.lstboxToDoList.Location = new System.Drawing.Point(26, 270);
            this.lstboxToDoList.Name = "lstboxToDoList";
            this.lstboxToDoList.Size = new System.Drawing.Size(320, 196);
            this.lstboxToDoList.TabIndex = 8;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.lstboxToDoList);
            this.Controls.Add(this.lstboxCurrentReminders);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblMonitoringStatus);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Productivity";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuLists;
        private System.Windows.Forms.ToolStripMenuItem mnuMonitor;
        private System.Windows.Forms.ToolStripMenuItem mnuReminderToDo;
        private System.Windows.Forms.ToolStripMenuItem mnuReminder;
        private System.Windows.Forms.ToolStripMenuItem mnuToDo;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistics;
        private System.Windows.Forms.ToolStripMenuItem mnuCalendar;
        private System.Windows.Forms.ToolStripMenuItem mnuSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox lstboxCurrentReminders;
        private System.Windows.Forms.ListBox lstboxToDoList;
        private System.Windows.Forms.Timer tmrTime;
        public System.Windows.Forms.Label lblMonitoringStatus;
    }
}

