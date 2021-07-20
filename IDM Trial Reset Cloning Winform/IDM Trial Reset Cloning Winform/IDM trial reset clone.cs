using System;
using System.Threading;
using System.Windows.Forms;

namespace IDM_Trial_Reset_Cloning_Winform
{
    public partial class TrialResetWF : Form
    {
        public TrialResetWF()
        {
            InitializeComponent();
        }
        private void btnResetTrial_Click(object sender, EventArgs e)
        {
            btnResetTrial.Text = "Please wait...";
            btnResetTrial.Enabled = false;
            Thread.Sleep(30000);
            MessageBox.Show("You have 30 day trial now!", "Reset IDM trial");
            btnResetTrial.Text = "Reset the IDM trial now";
            btnResetTrial.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(autocheckbox.Checked == true)
            {
                btnResetTrial.Text = "Please wait...";
                btnResetTrial.Enabled = false;
                Thread.Sleep(30000);
                MessageBox.Show("The IDM trial will be reset automatically.", "Auto reset");
                btnResetTrial.Text = "Reset the IDM trial now";
                btnResetTrial.Enabled = true;
            }
            else
            {
                btnResetTrial.Text = "Please wait...";
                btnResetTrial.Enabled = false;
                MessageBox.Show("The IDM trial will NOT be reset automatically.", "Auto reset");
                btnResetTrial.Text = "Reset the IDM trial now";
                btnResetTrial.Enabled = true;
            }
        }

        private void btnregisternow_Click(object sender, EventArgs e)
        {
            Register_IDM register_IDM = new Register_IDM();
            btnregisternow.Text = "Please wait...";
            register_IDM.ShowDialog();
            btnregisternow.Text = "Register IDM now";
        }

        private void btncheckupdates_Click(object sender, EventArgs e)
        {
            btncheckupdates.Text = "Please wait...";
            btncheckupdates.Enabled = false;
            Thread.Sleep(15000);
            MessageBox.Show("No update was found.", "Check updates");
            btncheckupdates.Text = "Check for updates";
            btncheckupdates.Enabled = true;
        }
    }
}
