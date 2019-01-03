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
    public partial class GoodBye : Form
    {
        public GoodBye()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speaker = null;
        private void GoodBye_Load(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.getNameForGoodBye(lb_Name);
            speaker = new SpeechSynthesizer();
            speaker.Volume = 100;
            speaker.Rate = 1;
            speaker.SpeakAsync(lb_Name.Text);
            speaker.SpeakAsync(lb_Messsage.Text);
            speaker.SpeakAsync(lb_Poli.Text + ", Living Simplified!");

        }

        private void btn_Okay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
