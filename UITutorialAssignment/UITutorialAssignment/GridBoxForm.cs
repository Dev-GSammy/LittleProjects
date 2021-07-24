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
    /*
        Developer: Samuel Taiwo Fatunmbi
        Environment: .Net Core
        Technology used: Windows Forms
    */
    public partial class GridBoxForm : Form
    {
        private DataTable dtCourses = new DataTable();
        private DataTable dtSelectedCourses = new DataTable();
        public GridBoxForm()
        {
            InitializeComponent();
        }
        private void GridBoxForm_Load(object sender, EventArgs e)
        {
            //invoking methods
            fillCourses();
            fillSelectedCourses();
            //implementing datasource and list display members
            listBox1.DataSource = dtCourses;
            listBox1.DisplayMember = "Course name";
            listBox2.DataSource = dtSelectedCourses;
            listBox2.DisplayMember = "Course name";
        }

        private void fillCourses()
        {
            dtCourses.Columns.Add("Course ID", typeof(int));
            dtCourses.Columns.Add("Course Name");
            dtCourses.Columns.Add("Course Duration");

            dtCourses.Rows.Add(1, "Object Oriented Programming", "2 months");
            dtCourses.Rows.Add(2, "Data Structure and Algorithm", "3 months");
            dtCourses.Rows.Add(3, "Operating Systems", "2 months");
            dtCourses.Rows.Add(4, "Software Quality", "6 months");
            dtCourses.Rows.Add(5, "Comparative Programming with C", "12 months");
            dtCourses.Rows.Add(6, "PHP", "6 months");
            dtCourses.Rows.Add(7, "Software Testing", "3 months");
            dtCourses.Rows.Add(8, "Software Engineering I", "2 months");
            dtCourses.Rows.Add(9, "Software Engineering II", "4 months");
            dtCourses.Rows.Add(10, "Assembly Language", "5 months");
            dtCourses.Rows.Add(11, "Enterprise Architecture", "6 months");
            dtCourses.Rows.Add(12, "Database Management", "6 months");
            dtCourses.Rows.Add(13, "Integrative programming and Technologies", "3 months");
            dtCourses.Rows.Add(14, "Compiler Construction", "18 months");
            dtCourses.Rows.Add(15, "Data Networks", "3 months");
            dtCourses.Rows.Add(16, "Computer Graphics", "9 months");
            dtCourses.Rows.Add(17, "Computer Networks", "10 months");
            dtCourses.Rows.Add(18, "Web Application Development", "6 months");
        }
        private void fillSelectedCourses()
        {
            dtSelectedCourses.Columns.Add("Course ID", typeof(int));
            dtSelectedCourses.Columns.Add("Course Name");
            dtSelectedCourses.Columns.Add("Course Duration");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dtSelectedCourses.ImportRow(dtCourses.Rows[listBox1.SelectedIndex]);
                dtCourses.Rows[listBox1.SelectedIndex].Delete();
            }
            else
            {
                MessageBox.Show("List Exhausted!!!", "Warning!!!");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dtCourses.ImportRow(dtSelectedCourses.Rows[listBox2.SelectedIndex]);
                dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
            }
            else
            {
                MessageBox.Show("List Exhausted!!!", "Warning!!!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //condition to confirm if any course is selected
            if (dtSelectedCourses.Rows.Count > 0)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    //dataGridView1.Enabled = false;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DataSource = dtSelectedCourses; //import data from dtSelectedCourses table
                    //column width allocation
                    dataGridView1.Columns[0].Width = 95;
                    dataGridView1.Columns[1].Width = 200;
                    dataGridView1.Columns[2].Width = 95;
                }
                else
                {
                    MessageBox.Show("Please confirm your selected courses.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Choose at least one course.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
