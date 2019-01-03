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
    public partial class Step2A : Form
    {
        public Step2A()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speaker = null;
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Step1 stp1 = new Step1();
            this.Hide();
            stp1.FormClosed += (s, args) => this.Close();
            stp1.ShowDialog();
        }

        private void Step2A_Load(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.getName(lbName);
            dfunc.getChairType(lbChairType);
            speaker = new SpeechSynthesizer();
            speaker.Volume = 100;
            speaker.Rate = 1;
            speaker.SpeakAsync(lb_Step2.Text);
            speaker.SpeakAsync(lb_Info.Text);
            speaker.SpeakAsync(lb_Tab.Text);
            speaker.SpeakAsync(lb_TabInfo.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Settings.step2a = DateTime.Now;
            Step2B stp2b = new Step2B();
            this.Hide();
            stp2b.FormClosed += (s, args) => this.Close();
            stp2b.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.Time(lbTime);
        }
    }
}
