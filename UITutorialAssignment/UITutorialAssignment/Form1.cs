using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITutorialAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonclickevent(Form form)
        {
            form.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnme_Click(object sender, EventArgs e)
        {
            formforme formforme = new formforme();
            buttonclickevent(formforme);
        }

        private void btncomputer_Click(object sender, EventArgs e)
        {
            formforcomputer formforcomputer = new formforcomputer();
            buttonclickevent(formforcomputer);
        }

        private void btngridbox_Click(object sender, EventArgs e)
        {
            GridBoxForm gridBoxForm = new GridBoxForm();
            buttonclickevent(gridBoxForm);
        }
    }
}
