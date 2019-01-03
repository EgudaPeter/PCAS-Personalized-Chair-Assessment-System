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
    public partial class Step2B : Form
    {
        public Step2B()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speaker = null;
        private void Step2B_Load(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.getName(lbName);
            dfunc.getChairType(lbChairType);
            speaker = new SpeechSynthesizer();
            speaker.Volume = 100;
            speaker.Rate = 1;
            speaker.SpeakAsync(lb_Step2B.Text);
            speaker.SpeakAsync(lb_Info.Text);
            speaker.SpeakAsync(lb_Dial.Text);
            speaker.SpeakAsync(lb_DialInfo.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Settings.step2b = DateTime.Now;
            Step2C stp2c = new Step2C();
            this.Hide();
            stp2c.FormClosed += (s, args) => this.Close();
            stp2c.ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
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
