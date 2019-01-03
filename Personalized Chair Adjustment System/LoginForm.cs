using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalized_Chair_Adjustment_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Settings.fTime = DateTime.Now;
            Settings.Username = txtUsername.Text;
            Settings.ID_Number = nudID.Value;
            string errorMessage = "Invalid Credentials!";
            databaseFunctions dfunc = new databaseFunctions();
            if (dfunc.authenticateLoginDetailsRegular(txtUsername, nudID) == true)
            {
                Home hme = new Home();
                this.Hide();
                hme.FormClosed += (s, args) => this.Close();
                hme.ShowDialog();
            }
            else if(dfunc.authenticateLoginDetailsSupervisor(txtUsername,nudID) == true)
            {
                supervisorHome shme = new supervisorHome();
                this.Hide();
                shme.FormClosed += (s, args) => this.Close();
                shme.ShowDialog();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
