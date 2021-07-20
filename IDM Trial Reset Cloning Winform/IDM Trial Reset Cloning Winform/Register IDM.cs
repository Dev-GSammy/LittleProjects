using System;
using System.Threading;
using System.Windows.Forms;

namespace IDM_Trial_Reset_Cloning_Winform
{
    public partial class Register_IDM : Form
    {
        public Register_IDM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string name = textBox1.Text;
            Thread.Sleep(30000);
            MessageBox.Show("IDM is registered now.", "Register IDM");
            button1.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
