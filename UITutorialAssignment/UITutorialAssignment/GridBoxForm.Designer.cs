
namespace UITutorialAssignment
{
    partial class GridBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.availablecourses = new System.Windows.Forms.Label();
            this.Selectedcourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(412, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 160);
            this.listBox1.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(9, 322);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(116, 53);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(131, 321);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(147, 53);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "SUBTRACT";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(284, 321);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 53);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(412, 217);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(229, 160);
            this.listBox2.TabIndex = 5;
            // 
            // availablecourses
            // 
            this.availablecourses.AutoSize = true;
            this.availablecourses.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablecourses.Location = new System.Drawing.Point(409, 5);
            this.availablecourses.Name = "availablecourses";
            this.availablecourses.Size = new System.Drawing.Size(147, 23);
            this.availablecourses.TabIndex = 6;
            this.availablecourses.Text = "Available Courses";
            // 
            // Selectedcourses
            // 
            this.Selectedcourses.AutoSize = true;
            this.Selectedcourses.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectedcourses.Location = new System.Drawing.Point(409, 191);
            this.Selectedcourses.Name = "Selectedcourses";
            this.Selectedcourses.Size = new System.Drawing.Size(142, 28);
            this.Selectedcourses.TabIndex = 7;
            this.Selectedcourses.Text = "Selected Courses";
            this.Selectedcourses.UseCompatibleTextRendering = true;
            // 
            // GridBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 386);
            this.Controls.Add(this.Selectedcourses);
            this.Controls.Add(this.availablecourses);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridBoxForm";
            this.Text = "Grid Box";
            this.Load += new System.EventHandler(this.GridBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label availablecourses;
        private System.Windows.Forms.Label Selectedcourses;
    }
}