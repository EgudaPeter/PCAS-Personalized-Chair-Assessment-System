using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalized_Chair_Adjustment_System
{
    public partial class WelcomeWindowcs : Form
    {
        public WelcomeWindowcs()
        {
            InitializeComponent();
        }
        static string filePath = Application.StartupPath + "/config.txt";
        static string showSignUpDialog = Application.StartupPath + "/Show_SignUp_Dialog.txt";
        static string isSignUpDialog = "false";
        SignUpWindow suw = new SignUpWindow();
        LoginForm lg = new LoginForm();

        private void WelcomeWindowcs_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    while (!reader.EndOfStream)
                    {
                        Settings.connectionText = reader.ReadLine();
                    }
                }
                catch (Exception ex) { }
            }

            using (StreamReader reader = new StreamReader(showSignUpDialog))
            {
                try
                {
                    while (!reader.EndOfStream)
                    {
                        Settings.showSignUp = reader.ReadLine();
                    }
                }
                catch (Exception ex) { }
            }
            if (Settings.showSignUp == isSignUpDialog)
            {
                this.Hide();
                lg.FormClosed += (s, args) => this.Close();
                lg.ShowDialog();
            }
            else
            {
                this.Hide();
                suw.FormClosed += (s, args) => this.Close();
                suw.ShowDialog();
            }
        }
    }
}
