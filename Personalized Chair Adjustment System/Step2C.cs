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
    public partial class Step2C : Form
    {
        public Step2C()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speaker = null;
        private void Step2C_Load(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.getName(lbName);
            dfunc.getChairType(lbChairType);
            speaker = new SpeechSynthesizer();
            speaker.Volume = 100;
            speaker.Rate = 1;
            speaker.SpeakAsync(lb_Step2C.Text);
            speaker.SpeakAsync(lb_Info.Text);
            speaker.SpeakAsync(lb_Rachet.Text);
            speaker.SpeakAsync(lb_RachetInfo.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Settings.step2c = DateTime.Now;
            Step3 stp3 = new Step3();
            this.Hide();
            stp3.FormClosed += (s, args) => this.Close();
            stp3.ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
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
