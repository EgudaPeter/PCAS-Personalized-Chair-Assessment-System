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
    public partial class SignUpWindow : Form
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        static string filePath = Application.StartupPath + "/Show_SignUp_Dialog.txt";
        LoginForm lg = new LoginForm();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string errorMessageName = "Name is Required!";
            string errorMessageGender = "Gender is Required!";
            string errorMessagePhone = "Phone number is Required!";
            string errorMessageUsername = "Username is not set!";
            if (txtName.Text == "")
            {
                MessageBox.Show(errorMessageName, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbGender.Text == "" || cmbGender.SelectedItem.ToString() == "")
            {
                MessageBox.Show(errorMessageGender, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudPhone.Text == "" || nudPhone.Value <= 0)
            {
                MessageBox.Show(errorMessagePhone, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUsername.Text == "")
            {
                MessageBox.Show(errorMessageUsername, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chkSupervisor.Checked == true)
            {
                Settings.isSupervisor = true;
                databaseFunctions dfunc = new databaseFunctions();
                if (dfunc.authenticateUsername(txtUsername) == true && dfunc.authenticateID(nudID) == true)
                {
                    lbInfoUsername.Text = "Acquired!";
                    lbInfoID.Text = "Acquired!";
                    return;
                }
                if (dfunc.authenticateUsername(txtUsername) == true)
                {
                    lbInfoUsername.Text = "Acquired!";
                    return;
                }
                else
                {
                    lbInfoUsername.Text = "";
                }
                if (dfunc.authenticateID(nudID) == true)
                {
                    lbInfoID.Text = "Acquired!";
                    return;
                }
                else
                {
                    lbInfoID.Text = "";
                }
                if (lbInfoUsername.Text == "" && lbInfoID.Text == "")
                {
                    dfunc.insertIntoSupervisorTable(txtName, cmbGender, nudPhone, txtUsername, nudID);
                    this.Hide();
                    lg.FormClosed += (s, args) => this.Close();
                    lg.ShowDialog();
                }
                else
                {
                    return;
                }
            
            }
            else if (chkSupervisor.Checked == false)
            {
                Settings.isSupervisor = false;
                databaseFunctions dfunc = new databaseFunctions();
                if (dfunc.authenticateUsername(txtUsername) == true && dfunc.authenticateID(nudID) == true)
                {
                    lbInfoUsername.Text = "Acquired!";
                    lbInfoID.Text = "Acquired!";
                    return;
                }
                if (dfunc.authenticateUsername(txtUsername) == true)
                {
                    lbInfoUsername.Text = "Acquired!";
                }
                else
                {
                    lbInfoUsername.Text = "";
                }
                if (dfunc.authenticateID(nudID) == true)
                {
                    lbInfoID.Text = "Acquired!";
                }
                else
                {
                    lbInfoID.Text = "";
                }
                if (lbInfoUsername.Text == "" && lbInfoID.Text == "")
                {
                    dfunc.insertIntoStaffTable(txtName, cmbGender, nudPhone, txtUsername, nudID);
                    this.Hide();
                    lg.FormClosed += (s, args) => this.Close();
                    lg.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            if (chkDialog.Checked == true)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine("false");
                    }
                    catch (Exception exception) { }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Exit?";
            switch (MessageBox.Show(message, "PCAS", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    Application.Exit();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    return;
            }
        }
    }
}
              