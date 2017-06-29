namespace Quack_
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMins = new System.Windows.Forms.ComboBox();
            this.cmbHrs = new System.Windows.Forms.ComboBox();
            this.chkTimerEnable = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLogout = new System.Windows.Forms.CheckBox();
            this.cmbTeleportLocation = new System.Windows.Forms.ComboBox();
            this.chkTeleport = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTimeLeft);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMins);
            this.groupBox1.Controls.Add(this.cmbHrs);
            this.groupBox1.Controls.Add(this.chkTimerEnable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Time:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(102, 52);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 16);
            this.lblTimeLeft.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours:";
            // 
            // cmbMins
            // 
            this.cmbMins.FormattingEnabled = true;
            this.cmbMins.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cmbMins.Location = new System.Drawing.Point(145, 23);
            this.cmbMins.Name = "cmbMins";
            this.cmbMins.Size = new System.Drawing.Size(41, 21);
            this.cmbMins.TabIndex = 2;
            this.cmbMins.Text = "0";
            // 
            // cmbHrs
            // 
            this.cmbHrs.FormattingEnabled = true;
            this.cmbHrs.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbHrs.Location = new System.Drawing.Point(51, 23);
            this.cmbHrs.Name = "cmbHrs";
            this.cmbHrs.Size = new System.Drawing.Size(35, 21);
            this.cmbHrs.TabIndex = 1;
            this.cmbHrs.Text = "1";
            // 
            // chkTimerEnable
            // 
            this.chkTimerEnable.AutoSize = true;
            this.chkTimerEnable.Location = new System.Drawing.Point(69, 75);
            this.chkTimerEnable.Name = "chkTimerEnable";
            this.chkTimerEnable.Size = new System.Drawing.Size(65, 17);
            this.chkTimerEnable.TabIndex = 0;
            this.chkTimerEnable.Text = "Enabled";
            this.chkTimerEnable.UseVisualStyleBackColor = true;
            this.chkTimerEnable.CheckedChanged += new System.EventHandler(this.chkTimerEnable_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkLogout);
            this.groupBox2.Controls.Add(this.cmbTeleportLocation);
            this.groupBox2.Controls.Add(this.chkTeleport);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 77);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What to do";
            // 
            // chkLogout
            // 
            this.chkLogout.AutoSize = true;
            this.chkLogout.Location = new System.Drawing.Point(14, 52);
            this.chkLogout.Name = "chkLogout";
            this.chkLogout.Size = new System.Drawing.Size(84, 17);
            this.chkLogout.TabIndex = 9;
            this.chkLogout.Text = "Close FFXIV";
            this.chkLogout.UseVisualStyleBackColor = true;
            this.chkLogout.CheckedChanged += new System.EventHandler(this.chkLogout_CheckedChanged);
            // 
            // cmbTeleportLocation
            // 
            this.cmbTeleportLocation.FormattingEnabled = true;
            this.cmbTeleportLocation.Location = new System.Drawing.Point(85, 27);
            this.cmbTeleportLocation.Name = "cmbTeleportLocation";
            this.cmbTeleportLocation.Size = new System.Drawing.Size(101, 21);
            this.cmbTeleportLocation.TabIndex = 8;
            this.cmbTeleportLocation.SelectedIndexChanged += new System.EventHandler(this.cmbTeleportLocation_SelectedIndexChanged);
            // 
            // chkTeleport
            // 
            this.chkTeleport.AutoSize = true;
            this.chkTeleport.Location = new System.Drawing.Point(14, 29);
            this.chkTeleport.Name = "chkTeleport";
            this.chkTeleport.Size = new System.Drawing.Size(65, 17);
            this.chkTeleport.TabIndex = 7;
            this.chkTeleport.Text = "Teleport";
            this.chkTeleport.UseVisualStyleBackColor = true;
            this.chkTeleport.CheckedChanged += new System.EventHandler(this.chkTeleport_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 203);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Quack! ...";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTimerEnable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMins;
        private System.Windows.Forms.ComboBox cmbHrs;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTeleportLocation;
        private System.Windows.Forms.CheckBox chkTeleport;
        private System.Windows.Forms.CheckBox chkLogout;
    }
}