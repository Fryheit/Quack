using System;
using System.Windows.Forms;
using Quack.Settings;
using ff14bot;
using ff14bot.Managers;

namespace Quack_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            chkLogout.Checked = Quack.settings.Logout;
            chkTeleport.Checked = Quack.settings.Teleport;

            foreach(var item in WorldManager.AvailableLocations)
            {
                cmbTeleportLocation.Items.Add(item.Name);
            }

            cmbTeleportLocation.Text = Quack.settings.TeleportLocation;
        }

        #region Variables

        public DateTime StartTime;
        public DateTime EndTime;
        #endregion
        private void chkTimerEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimerEnable.Checked)
            {
                Quack.settings.Enabled = true;
                Quack.settings.TimeStart = DateTime.Now;
                Quack.settings.TimeEnd = Quack.settings.TimeStart.AddHours(int.Parse(cmbHrs.Text));
                Quack.settings.TimeEnd = Quack.settings.TimeEnd.AddMinutes(int.Parse(cmbMins.Text));
                StartTime = Quack.settings.TimeStart;
                EndTime = Quack.settings.TimeEnd;
                lblTimeLeft.Text = Quack.settings.TimeEnd.ToShortTimeString();
            }

            if (!chkTimerEnable.Checked)
            {
                Quack.settings.Enabled = false;
                lblTimeLeft.Text = "";
            }
        }

        private void chkTeleport_CheckedChanged(object sender, EventArgs e)
        {
            Quack.settings.Teleport = chkTeleport.Checked;
        }

        private void chkLogout_CheckedChanged(object sender, EventArgs e)
        {
            Quack.settings.Logout = chkLogout.Checked;
        }

        private void cmbTeleportLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quack.settings.TeleportLocation = cmbTeleportLocation.Text;
        }
    }
}
