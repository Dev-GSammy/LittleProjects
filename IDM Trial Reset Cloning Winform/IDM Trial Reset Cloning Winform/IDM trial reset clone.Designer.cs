
namespace IDM_Trial_Reset_Cloning_Winform
{
    partial class TrialResetWF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrialResetWF));
            this.Trialreset = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.autocheckbox = new System.Windows.Forms.CheckBox();
            this.btnResetTrial = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregisternow = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.TabPage();
            this.btncheckupdates = new System.Windows.Forms.Button();
            this.btnchat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Trialreset.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Register.SuspendLayout();
            this.Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // Trialreset
            // 
            this.Trialreset.Controls.Add(this.tabPage1);
            this.Trialreset.Controls.Add(this.Register);
            this.Trialreset.Controls.Add(this.Help);
            this.Trialreset.Location = new System.Drawing.Point(-1, 0);
            this.Trialreset.Name = "Trialreset";
            this.Trialreset.SelectedIndex = 0;
            this.Trialreset.Size = new System.Drawing.Size(336, 115);
            this.Trialreset.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.autocheckbox);
            this.tabPage1.Controls.Add(this.btnResetTrial);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 87);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trial Reset";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // autocheckbox
            // 
            this.autocheckbox.AutoSize = true;
            this.autocheckbox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autocheckbox.Location = new System.Drawing.Point(108, 56);
            this.autocheckbox.Name = "autocheckbox";
            this.autocheckbox.Size = new System.Drawing.Size(95, 19);
            this.autocheckbox.TabIndex = 1;
            this.autocheckbox.Text = "Automatically";
            this.autocheckbox.UseVisualStyleBackColor = true;
            this.autocheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnResetTrial
            // 
            this.btnResetTrial.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetTrial.Location = new System.Drawing.Point(63, 12);
            this.btnResetTrial.Name = "btnResetTrial";
            this.btnResetTrial.Size = new System.Drawing.Size(176, 38);
            this.btnResetTrial.TabIndex = 0;
            this.btnResetTrial.Text = "Reset the IDM trial now";
            this.btnResetTrial.UseVisualStyleBackColor = true;
            this.btnResetTrial.Click += new System.EventHandler(this.btnResetTrial_Click);
            // 
            // Register
            // 
            this.Register.Controls.Add(this.label1);
            this.Register.Controls.Add(this.btnregisternow);
            this.Register.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register.Location = new System.Drawing.Point(4, 24);
            this.Register.Name = "Register";
            this.Register.Padding = new System.Windows.Forms.Padding(3);
            this.Register.Size = new System.Drawing.Size(328, 87);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "If IDM will be blocked, then Register again or use Trial reset.";
            // 
            // btnregisternow
            // 
            this.btnregisternow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnregisternow.Location = new System.Drawing.Point(67, 25);
            this.btnregisternow.Name = "btnregisternow";
            this.btnregisternow.Size = new System.Drawing.Size(176, 30);
            this.btnregisternow.TabIndex = 1;
            this.btnregisternow.Text = "Register IDM now";
            this.btnregisternow.UseVisualStyleBackColor = true;
            this.btnregisternow.Click += new System.EventHandler(this.btnregisternow_Click);
            // 
            // Help
            // 
            this.Help.Controls.Add(this.btncheckupdates);
            this.Help.Controls.Add(this.btnchat);
            this.Help.Controls.Add(this.label3);
            this.Help.Controls.Add(this.label2);
            this.Help.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Help.Location = new System.Drawing.Point(4, 24);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3);
            this.Help.Size = new System.Drawing.Size(328, 87);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // btncheckupdates
            // 
            this.btncheckupdates.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncheckupdates.Location = new System.Drawing.Point(165, 54);
            this.btncheckupdates.Name = "btncheckupdates";
            this.btncheckupdates.Size = new System.Drawing.Size(114, 23);
            this.btncheckupdates.TabIndex = 6;
            this.btncheckupdates.Text = "Check for updates";
            this.btncheckupdates.UseVisualStyleBackColor = true;
            this.btncheckupdates.Click += new System.EventHandler(this.btncheckupdates_Click);
            // 
            // btnchat
            // 
            this.btnchat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnchat.Location = new System.Drawing.Point(45, 54);
            this.btnchat.Name = "btnchat";
            this.btnchat.Size = new System.Drawing.Size(114, 23);
            this.btnchat.TabIndex = 5;
            this.btnchat.Text = "Chat about this  tool";
            this.btnchat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Register    ---> Register IDM ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trial reset ---> Reset the IDM Trial, fix blocked, fake serial...";
            // 
            // TrialResetWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.Trialreset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrialResetWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDM Trial Reset WF";
            this.Trialreset.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Trialreset;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Register;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.CheckBox autocheckbox;
        private System.Windows.Forms.Button btnResetTrial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregisternow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncheckupdates;
        private System.Windows.Forms.Button btnchat;
        private System.Windows.Forms.Label label3;
    }
}

