using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Personalized_Chair_Adjustment_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speaker = null;
        private void Home_Load(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.getNameOfUser(lbWelcome);
            speaker = new SpeechSynthesizer();
            speaker.Volume = 100;
            speaker.Rate = 1;
            speaker.SpeakAsync(lbWelcome.Text);
            speaker.SpeakAsync(lb_Info.Text);
            speaker.SpeakAsync(rbtnChairWithArmRest.Text);
            speaker.SpeakAsync("or,");
            speaker.SpeakAsync(rbtnChairWithoutArmRest.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            if (rbtnChairWithArmRest.Checked == true)
            {
                Settings.typeOfChair = 1;
            }
            else if (rbtnChairWithoutArmRest.Checked == true)
            {
                Settings.typeOfChair = 2;
            }
            Step1 stp1 = new Step1();
            this.Hide();
            stp1.FormClosed += (s, args) => this.Close();
            stp1.ShowDialog();
        }
    }
}
