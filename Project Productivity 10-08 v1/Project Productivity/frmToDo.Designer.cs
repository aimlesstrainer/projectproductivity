namespace Project_Productivity
{
    partial class frmToDo
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
            this.btnToDoReturn = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lstboxToDos = new System.Windows.Forms.ListBox();
            this.btnToDoRemove = new System.Windows.Forms.Button();
            this.btnToDoAdd = new System.Windows.Forms.Button();
            this.txtToDo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnToDoReturn
            // 
            this.btnToDoReturn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDoReturn.Location = new System.Drawing.Point(322, 349);
            this.btnToDoReturn.Name = "btnToDoReturn";
            this.btnToDoReturn.Size = new System.Drawing.Size(150, 25);
            this.btnToDoReturn.TabIndex = 16;
            this.btnToDoReturn.Text = "Return";
            this.btnToDoReturn.UseVisualStyleBackColor = true;
            this.btnToDoReturn.Click += new System.EventHandler(this.btnToDoReturn_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(130, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(220, 23);
            this.lblHeading.TabIndex = 14;
            this.lblHeading.Text = "Manage To-dos";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstboxToDos
            // 
            this.lstboxToDos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxToDos.FormattingEnabled = true;
            this.lstboxToDos.ItemHeight = 16;
            this.lstboxToDos.Location = new System.Drawing.Point(-1, 40);
            this.lstboxToDos.Name = "lstboxToDos";
            this.lstboxToDos.Size = new System.Drawing.Size(486, 196);
            this.lstboxToDos.TabIndex = 13;
            // 
            // btnToDoRemove
            // 
            this.btnToDoRemove.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDoRemove.Location = new System.Drawing.Point(165, 240);
            this.btnToDoRemove.Name = "btnToDoRemove";
            this.btnToDoRemove.Size = new System.Drawing.Size(150, 25);
            this.btnToDoRemove.TabIndex = 12;
            this.btnToDoRemove.Text = "Remove Selected";
            this.btnToDoRemove.UseVisualStyleBackColor = true;
            this.btnToDoRemove.Click += new System.EventHandler(this.btnToDoRemove_Click);
            // 
            // btnToDoAdd
            // 
            this.btnToDoAdd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDoAdd.Location = new System.Drawing.Point(322, 318);
            this.btnToDoAdd.Name = "btnToDoAdd";
            this.btnToDoAdd.Size = new System.Drawing.Size(150, 25);
            this.btnToDoAdd.TabIndex = 11;
            this.btnToDoAdd.Text = "Add to-do";
            this.btnToDoAdd.UseVisualStyleBackColor = true;
            this.btnToDoAdd.Click += new System.EventHandler(this.btnToDoAdd_Click);
            // 
            // txtToDo
            // 
            this.txtToDo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDo.Location = new System.Drawing.Point(12, 318);
            this.txtToDo.Name = "txtToDo";
            this.txtToDo.Size = new System.Drawing.Size(299, 25);
            this.txtToDo.TabIndex = 10;
            // 
            // frmToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 386);
            this.Controls.Add(this.btnToDoReturn);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lstboxToDos);
            this.Controls.Add(this.btnToDoRemove);
            this.Controls.Add(this.btnToDoAdd);
            this.Controls.Add(this.txtToDo);
            this.Name = "frmToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-dos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToDoReturn;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ListBox lstboxToDos;
        private System.Windows.Forms.Button btnToDoRemove;
        private System.Windows.Forms.Button btnToDoAdd;
        private System.Windows.Forms.TextBox txtToDo;
    }
}