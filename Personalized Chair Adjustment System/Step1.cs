using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Speech;
using System.Speech.Synthesis;

namespace Personalized_Chair_Adjustment_System
{
    public partial class Step1 : Form
    {
        public Step1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speaker = null;
        private void Step1_Load(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.getName(lbName);
            dfunc.getChairType(lbChairType);
            speaker = new SpeechSynthesizer();
            speaker.Volume = 100;
            speaker.Rate = 1;
            speaker.SpeakAsync(lb_Step1.Text);
            speaker.SpeakAsync(lb_InfoForStep1.Text);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Home hme = new Home();
            this.Hide();
            hme.FormClosed += (s, args) => this.Close();
            hme.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Settings.step1 = DateTime.Now;
            Step2A stp2a = new Step2A();
            this.Hide();
            stp2a.FormClosed += (s, args) => this.Close();
            stp2a.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.Time(lbTime);
        }
    }
}
