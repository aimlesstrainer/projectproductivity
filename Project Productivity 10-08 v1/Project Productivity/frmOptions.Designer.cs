namespace Project_Productivity
{
    partial class frmOptions
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.chkMonthPos = new System.Windows.Forms.CheckBox();
            this.chkYearPos = new System.Windows.Forms.CheckBox();
            this.chkYearLength = new System.Windows.Forms.CheckBox();
            this.chkDateLength = new System.Windows.Forms.CheckBox();
            this.chkTimeFormat = new System.Windows.Forms.CheckBox();
            this.tolMonthPos = new System.Windows.Forms.ToolTip(this.components);
            this.radDateDash = new System.Windows.Forms.RadioButton();
            this.radDateDot = new System.Windows.Forms.RadioButton();
            this.radDateSlash = new System.Windows.Forms.RadioButton();
            this.tolDateLength = new System.Windows.Forms.ToolTip(this.components);
            this.tolYearLength = new System.Windows.Forms.ToolTip(this.components);
            this.tolYearPos = new System.Windows.Forms.ToolTip(this.components);
            this.lblSubheading1 = new System.Windows.Forms.Label();
            this.btnOptionsReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.lblPassChanged = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(90, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(100, 23);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Options";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkMonthPos
            // 
            this.chkMonthPos.AutoSize = true;
            this.chkMonthPos.Enabled = false;
            this.chkMonthPos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonthPos.Location = new System.Drawing.Point(12, 190);
            this.chkMonthPos.Name = "chkMonthPos";
            this.chkMonthPos.Size = new System.Drawing.Size(141, 21);
            this.chkMonthPos.TabIndex = 1;
            this.chkMonthPos.Text = "Month before Day";
            this.chkMonthPos.UseVisualStyleBackColor = true;
            this.chkMonthPos.MouseHover += new System.EventHandler(this.chkMonthPos_MouseHover);
            // 
            // chkYearPos
            // 
            this.chkYearPos.AutoSize = true;
            this.chkYearPos.Enabled = false;
            this.chkYearPos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYearPos.Location = new System.Drawing.Point(12, 244);
            this.chkYearPos.Name = "chkYearPos";
            this.chkYearPos.Size = new System.Drawing.Size(160, 21);
            this.chkYearPos.TabIndex = 2;
            this.chkYearPos.Text = "Year in First Position";
            this.chkYearPos.UseVisualStyleBackColor = true;
            this.chkYearPos.MouseHover += new System.EventHandler(this.chkYearPos_MouseHover);
            // 
            // chkYearLength
            // 
            this.chkYearLength.AutoSize = true;
            this.chkYearLength.Enabled = false;
            this.chkYearLength.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYearLength.Location = new System.Drawing.Point(12, 217);
            this.chkYearLength.Name = "chkYearLength";
            this.chkYearLength.Size = new System.Drawing.Size(161, 21);
            this.chkYearLength.TabIndex = 3;
            this.chkYearLength.Text = "Shorten Year in Date";
            this.chkYearLength.UseVisualStyleBackColor = true;
            this.chkYearLength.CheckedChanged += new System.EventHandler(this.chkYearLength_CheckedChanged);
            this.chkYearLength.MouseHover += new System.EventHandler(this.chkYearLength_MouseHover);
            // 
            // chkDateLength
            // 
            this.chkDateLength.AutoSize = true;
            this.chkDateLength.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateLength.Location = new System.Drawing.Point(12, 47);
            this.chkDateLength.Name = "chkDateLength";
            this.chkDateLength.Size = new System.Drawing.Size(259, 21);
            this.chkDateLength.TabIndex = 4;
            this.chkDateLength.Text = "Use shorthand date on main screen";
            this.chkDateLength.UseVisualStyleBackColor = true;
            this.chkDateLength.CheckedChanged += new System.EventHandler(this.chkDateLength_CheckedChanged);
            this.chkDateLength.MouseHover += new System.EventHandler(this.chkDateLength_MouseHover);
            // 
            // chkTimeFormat
            // 
            this.chkTimeFormat.AutoSize = true;
            this.chkTimeFormat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimeFormat.Location = new System.Drawing.Point(12, 271);
            this.chkTimeFormat.Name = "chkTimeFormat";
            this.chkTimeFormat.Size = new System.Drawing.Size(158, 21);
            this.chkTimeFormat.TabIndex = 5;
            this.chkTimeFormat.Text = "Enable 24-hour time";
            this.chkTimeFormat.UseVisualStyleBackColor = true;
            // 
            // radDateDash
            // 
            this.radDateDash.AutoSize = true;
            this.radDateDash.Enabled = false;
            this.radDateDash.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDateDash.Location = new System.Drawing.Point(32, 97);
            this.radDateDash.Name = "radDateDash";
            this.radDateDash.Size = new System.Drawing.Size(98, 21);
            this.radDateDash.TabIndex = 6;
            this.radDateDash.Text = "DD-MM-YY";
            this.radDateDash.UseVisualStyleBackColor = true;
            // 
            // radDateDot
            // 
            this.radDateDot.AutoSize = true;
            this.radDateDot.Enabled = false;
            this.radDateDot.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDateDot.Location = new System.Drawing.Point(32, 124);
            this.radDateDot.Name = "radDateDot";
            this.radDateDot.Size = new System.Drawing.Size(96, 21);
            this.radDateDot.TabIndex = 7;
            this.radDateDot.Text = "DD.MM.YY";
            this.radDateDot.UseVisualStyleBackColor = true;
            // 
            // radDateSlash
            // 
            this.radDateSlash.AutoSize = true;
            this.radDateSlash.Enabled = false;
            this.radDateSlash.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDateSlash.Location = new System.Drawing.Point(32, 151);
            this.radDateSlash.Name = "radDateSlash";
            this.radDateSlash.Size = new System.Drawing.Size(96, 21);
            this.radDateSlash.TabIndex = 8;
            this.radDateSlash.Text = "DD/MM/YY";
            this.radDateSlash.UseVisualStyleBackColor = true;
            // 
            // lblSubheading1
            // 
            this.lblSubheading1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubheading1.Location = new System.Drawing.Point(9, 71);
            this.lblSubheading1.Name = "lblSubheading1";
            this.lblSubheading1.Size = new System.Drawing.Size(181, 23);
            this.lblSubheading1.TabIndex = 9;
            this.lblSubheading1.Text = "Shorthand Date Format:";
            this.lblSubheading1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOptionsReturn
            // 
            this.btnOptionsReturn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionsReturn.Location = new System.Drawing.Point(90, 497);
            this.btnOptionsReturn.Name = "btnOptionsReturn";
            this.btnOptionsReturn.Size = new System.Drawing.Size(100, 30);
            this.btnOptionsReturn.TabIndex = 11;
            this.btnOptionsReturn.Text = "Return";
            this.btnOptionsReturn.UseVisualStyleBackColor = true;
            this.btnOptionsReturn.Click += new System.EventHandler(this.btnOptionsReturn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.Location = new System.Drawing.Point(40, 326);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCurrentPass.Size = new System.Drawing.Size(200, 26);
            this.txtCurrentPass.TabIndex = 13;
            this.txtCurrentPass.Text = "Current Password";
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(40, 384);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConfirmPass.Size = new System.Drawing.Size(200, 26);
            this.txtConfirmPass.TabIndex = 14;
            this.txtConfirmPass.Text = "Confirm Password";
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(40, 355);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewPass.Size = new System.Drawing.Size(200, 26);
            this.txtNewPass.TabIndex = 15;
            this.txtNewPass.Text = "New Password";
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(60, 446);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(160, 30);
            this.btnChangePass.TabIndex = 16;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // lblPassChanged
            // 
            this.lblPassChanged.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassChanged.Location = new System.Drawing.Point(40, 413);
            this.lblPassChanged.Name = "lblPassChanged";
            this.lblPassChanged.Size = new System.Drawing.Size(200, 20);
            this.lblPassChanged.TabIndex = 17;
            this.lblPassChanged.Text = "Password changed.";
            this.lblPassChanged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPassChanged.Visible = false;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 537);
            this.Controls.Add(this.lblPassChanged);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOptionsReturn);
            this.Controls.Add(this.lblSubheading1);
            this.Controls.Add(this.radDateSlash);
            this.Controls.Add(this.radDateDot);
            this.Controls.Add(this.radDateDash);
            this.Controls.Add(this.chkTimeFormat);
            this.Controls.Add(this.chkDateLength);
            this.Controls.Add(this.chkYearLength);
            this.Controls.Add(this.chkYearPos);
            this.Controls.Add(this.chkMonthPos);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.CheckBox chkMonthPos;
        private System.Windows.Forms.CheckBox chkYearPos;
        private System.Windows.Forms.CheckBox chkYearLength;
        private System.Windows.Forms.CheckBox chkDateLength;
        private System.Windows.Forms.CheckBox chkTimeFormat;
        private System.Windows.Forms.ToolTip tolMonthPos;
        private System.Windows.Forms.RadioButton radDateDash;
        private System.Windows.Forms.RadioButton radDateDot;
        private System.Windows.Forms.RadioButton radDateSlash;
        private System.Windows.Forms.ToolTip tolDateLength;
        private System.Windows.Forms.ToolTip tolYearLength;
        private System.Windows.Forms.ToolTip tolYearPos;
        private System.Windows.Forms.Label lblSubheading1;
        private System.Windows.Forms.Button btnOptionsReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblPassChanged;
    }
}