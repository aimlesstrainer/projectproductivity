using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Productivity
{
    public partial class frmLogin : Form
    {
        string strPassword;
        string strPasswordToRead;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            using (StreamReader LoginReader = new StreamReader("login.txt"))
            {
                if ((strPasswordToRead = LoginReader.ReadLine()) == "")
                {
                    strPassword = "pass";
                }
                else
                {
                    strPassword = strPasswordToRead;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == strPassword)
            {
                Hide();
            }
            else
            {
                lblPassIncorrect.Visible = true;
            }
        }
    }
}
