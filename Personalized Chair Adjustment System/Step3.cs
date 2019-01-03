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
    public partial class Step3 : Form
    {
        public Step3()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speaker = null;
        private void Step3_Load(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.getName(lbName);
            dfunc.getChairType(lbChairType);
            speaker = new SpeechSynthesizer();
            speaker.Volume = 100;
            speaker.Rate = 1;
            speaker.SpeakAsync(lb_Step3.Text);
            speaker.SpeakAsync(lb_Info.Text);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Settings.eTime = DateTime.Now;
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.insertIntoAuditTable();
            GoodBye gb = new GoodBye();
            this.Hide();
            gb.FormClosed += (s, args) => this.Close();
            gb.ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            speaker.Dispose();
            Step2C stp2c = new Step2C();
            this.Hide();
            stp2c.FormClosed += (s, args) => this.Close();
            stp2c.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.Time(lbTime);
        }
    }
}
