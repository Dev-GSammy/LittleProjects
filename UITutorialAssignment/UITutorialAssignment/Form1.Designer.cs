
namespace UITutorialAssignment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GRIDBOX = new System.Windows.Forms.Label();
            this.btngridbox = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btncomputer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "GAME OF CHESS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(819, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(855, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.GRIDBOX);
            this.panel2.Controls.Add(this.btngridbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btncomputer);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnme);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 392);
            this.panel2.TabIndex = 1;
            // 
            // GRIDBOX
            // 
            this.GRIDBOX.AutoSize = true;
            this.GRIDBOX.BackColor = System.Drawing.Color.White;
            this.GRIDBOX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRIDBOX.Location = new System.Drawing.Point(87, 291);
            this.GRIDBOX.Name = "GRIDBOX";
            this.GRIDBOX.Size = new System.Drawing.Size(84, 19);
            this.GRIDBOX.TabIndex = 10;
            this.GRIDBOX.Text = "GRIDBOX";
            // 
            // btngridbox
            // 
            this.btngridbox.BackColor = System.Drawing.Color.White;
            this.btngridbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngridbox.BackgroundImage")));
            this.btngridbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btngridbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngridbox.ForeColor = System.Drawing.Color.White;
            this.btngridbox.Location = new System.Drawing.Point(59, 280);
            this.btngridbox.Name = "btngridbox";
            this.btngridbox.Size = new System.Drawing.Size(163, 100);
            this.btngridbox.TabIndex = 9;
            this.btngridbox.UseVisualStyleBackColor = false;
            this.btngridbox.Click += new System.EventHandler(this.btngridbox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "COMPUTER";
            // 
            // btncomputer
            // 
            this.btncomputer.BackColor = System.Drawing.Color.White;
            this.btncomputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncomputer.BackgroundImage")));
            this.btncomputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncomputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomputer.ForeColor = System.Drawing.Color.White;
            this.btncomputer.Location = new System.Drawing.Point(59, 161);
            this.btncomputer.Name = "btncomputer";
            this.btncomputer.Size = new System.Drawing.Size(163, 100);
            this.btncomputer.TabIndex = 7;
            this.btncomputer.UseVisualStyleBackColor = false;
            this.btncomputer.Click += new System.EventHandler(this.btncomputer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "ME";
            // 
            // btnme
            // 
            this.btnme.BackColor = System.Drawing.Color.White;
            this.btnme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnme.BackgroundImage")));
            this.btnme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnme.ForeColor = System.Drawing.Color.White;
            this.btnme.Location = new System.Drawing.Point(59, 39);
            this.btnme.Name = "btnme";
            this.btnme.Size = new System.Drawing.Size(163, 108);
            this.btnme.TabIndex = 4;
            this.btnme.UseVisualStyleBackColor = false;
            this.btnme.Click += new System.EventHandler(this.btnme_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Players";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(263, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 392);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 443);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncomputer;
        private System.Windows.Forms.Label GRIDBOX;
        private System.Windows.Forms.Button btngridbox;
    }
}

