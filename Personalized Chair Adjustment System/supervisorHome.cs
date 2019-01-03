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
    public partial class supervisorHome : Form
    {
        public supervisorHome()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speaker = new SpeechSynthesizer();
        Boolean isDisposed = false;
        private void btnGetRecords_Click(object sender, EventArgs e)
        {
            PickDate pd = new PickDate();
            if (pd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!bwGetRecords.IsBusy)
                {
                    bwGetRecords.RunWorkerAsync();
                }
            }
        }

        private void bwGetRecords_DoWork(object sender, DoWorkEventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dgvAllRecords.Invoke(new MethodInvoker(delegate{dfunc.getAllRecords(dgvAllRecords, lbAllRecords, Settings.startDate, Settings.endDate,txtDate);}));
            dgvActive.Invoke(new MethodInvoker(delegate { dfunc.getActiveRecords(dgvActive, lbActive, Settings.startDate, Settings.endDate); }));
            dgvDisabled.Invoke(new MethodInvoker(delegate { dfunc.getDisabledRecords(dgvDisabled, lbDisabled, Settings.startDate, Settings.endDate); }));
            dgvQuery.Invoke(new MethodInvoker(delegate { dfunc.getQueryRecords(dgvQuery, lbQuery, Settings.startDate, Settings.endDate); }));
            dgvComplied.Invoke(new MethodInvoker(delegate { dfunc.getCompliedRecords(dgvComplied, lbComplied, Settings.startDate, Settings.endDate); }));
            dgvSlow.Invoke(new MethodInvoker(delegate { dfunc.getSlowRecords(dgvSlow, lbSlow, Settings.startDate, Settings.endDate); }));
            e.Result = "Ready!";
        }

        private void bwGetRecords_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string errorMessage = "Oops! Something went wrong!";
            try
            {
                if (e.Cancelled)
                {
                    lbProcessing.Text = "Operation Cancelled!";
                }
                else if (e.Error != null)
                {
                    lbProcessing.Text = e.Error.Message;
                }
                else
                {
                    lbProcessing.Text = e.Result.ToString();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            if (txtSearch.Text != "")
            {
                dfunc.searchRecords(txtSearch, dgvAllRecords, lbAllRecords);
                dfunc.searchActiveRecords(txtSearch, dgvActive, lbActive);
                dfunc.searchDisabledRecords(txtSearch, dgvDisabled, lbDisabled);
                dfunc.searchQueryRecords(txtSearch, dgvQuery, lbQuery);
                dfunc.searchCompliedRecords(txtSearch, dgvComplied, lbComplied);
                dfunc.searchSlowRecords(txtSearch, dgvSlow, lbSlow);
            }
            else
            {
                if (!bwGetRecords.IsBusy)
                {
                    bwGetRecords.RunWorkerAsync();
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Settings.isQuery = true;
            Settings.isComplied = false;
            Settings.isSlow = false;
            Settings.isClear = false;
            string id = dgvAllRecords.SelectedRows[0].Cells[0].Value.ToString();
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.updateStatus(id);
            if (!bwGetRecords.IsBusy)
            {
                bwGetRecords.RunWorkerAsync();
            }
        }

        private void btnComplied_Click(object sender, EventArgs e)
        {
            Settings.isQuery = false;
            Settings.isComplied = true;
            Settings.isSlow = false;
            Settings.isClear = false;
            string id = dgvAllRecords.SelectedRows[0].Cells[0].Value.ToString();
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.updateStatus(id);
            if (!bwGetRecords.IsBusy)
            {
                bwGetRecords.RunWorkerAsync();
            }
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            Settings.isQuery = false;
            Settings.isComplied = false;
            Settings.isSlow = true;
            Settings.isClear = false;
            string id = dgvAllRecords.SelectedRows[0].Cells[0].Value.ToString();
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.updateStatus(id);
            if (!bwGetRecords.IsBusy)
            {
                bwGetRecords.RunWorkerAsync();
            }
        }

        private void btnClearStatus_Click(object sender, EventArgs e)
        {
            Settings.isQuery = false;
            Settings.isComplied = false;
            Settings.isSlow = false;
            Settings.isClear = true;
            string id = dgvAllRecords.SelectedRows[0].Cells[0].Value.ToString();
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.updateStatus(id);
            if (!bwGetRecords.IsBusy)
            {
                bwGetRecords.RunWorkerAsync();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Log-Out?";
            switch (MessageBox.Show(message, "Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case System.Windows.Forms.DialogResult.Yes:
                     LoginForm lg = new LoginForm();
            this.Hide();
            lg.FormClosed +=(s,args)=>this.Close();
            lg.ShowDialog();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    return;
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            string id = dgvAllRecords.SelectedRows[0].Cells[0].Value.ToString();
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.enableRecord(id);
            if (!bwGetRecords.IsBusy)
            {
                bwGetRecords.RunWorkerAsync();
            }
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            string id = dgvAllRecords.SelectedRows[0].Cells[0].Value.ToString();
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.disableRecord(id);
            if (!bwGetRecords.IsBusy)
            {
                bwGetRecords.RunWorkerAsync();
            }
        }

        private void supervisorHome_Load(object sender, EventArgs e)
        {
            databaseFunctions dfunc = new databaseFunctions();
            dfunc.getNameOfSupervisor(lbName);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            if (isDisposed == true)
            {
                speaker = new SpeechSynthesizer();
            }
            speaker.Volume = 100;
            speaker.Rate = 1;
            if (speaker.State != SynthesizerState.Speaking)
            {
                isDisposed = false;
                speaker.SpeakAsync(lbName.Text + ". I am Edi; your guide to using this window." + " This is the window for a supervisor. As your guide, my job is to educate you on how to go about using the elements of this window.");
                speaker.SpeakAsync("First of all, you should know that " + lb_NoteInfo.Text);
                speaker.SpeakAsync( "To view records, look to the center of your screen, you should see a somewhat container. This is known as a tab-control and is the place that houses the element that displays the records." + "\n"
                   + "You can navigate the tab-control by clicking on its tab-pages, that is, those grey button-like tabs with text written on them." + "\n" + " The All Records Page displays records that have been submitted."
                   + " The Active Records Page displays records that have been submitted and are active." + " The Disabled Records Page displays records that have been submitted and are disabled."
                   + " The Query, Complied and Slow pages display records that have been checked my you the supervisor." + " Now you know how to view records, let me guide you through using the control panel to your right."
                   + " The control panel consists of: "+ "\n" 
                   + " (1) Get Records button: This button helps to retrieve records submitted at a particular duration of time" + ". Clicking it brings up a window were you specify the duration of time to which you want records to be retrieved"
                   + ". The time duration you have specified will then be displayed in the Date control at the upper right corner of the window." + "\n"
                   + " (2) Query button: This button gives a record a status of Query when clicked." + "\n"
                   + " (3) Slow button: This button gives a record a status of Slow when clicked." + "\n"
                   + " (4) Complied button: This button gives a record a status of Complied when clicked." + "\n"
                   + " (5) Clear status button: This button clears the status of a record, giving it an empty status." + "\n"
                   + " (6) Enable button: This button enables a record." + "\n"
                   + " (7) Disable button: This button disables a record." + "\n"
                   + " (8) Log-out button: This button logs you out of this window and returns you to the login window.");
                speaker.SpeakAsync("Now you know how to use the control panel, you should take a look to the top-middle of the window where you should see a search control. This control helps you, the supervisor, in fishing out a particular record that belongs to a particular staff. To use this control"
                   + ", you just have to type the name of the staff that has that specific record and it should display at the center of the window." + "\n"
                   + " Now you know about the search control and how to use it, you should take a look at the bottom-left corner of the window. You should see a 'You Have Here Label'. This corner displays the number of records you, as a supervisor, are working with.");
                speaker.SpeakAsync("In summary, you should now be able to go about: " + "\n" 
                + " (1) Viewing records."
                + " (2) Using the control panel."
                + " (3) Using the search control."
                + " and (4) Knowing the elements of this window and their relevance.");
                speaker.SpeakAsync("Have a wonderful day! Good-Bye!");
                speaker.SpeakAsync("Polidane Softwares, Living Simplified!");
            }
            else
            {
                speaker.Dispose();
                isDisposed = true;
            }
        }
    }
}
