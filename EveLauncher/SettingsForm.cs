using System;
using System.Windows.Forms;

namespace EveLauncher
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void launchRepairTool_Click(object sender, EventArgs e)
        {
            SharedVars.launchProc("repair.exe", launchRepairTool);
        }



        private void launchLogServer_Click(object sender, EventArgs e)
        {
            SharedVars.launchProc("logserver.exe", launchLogServer);
        }

        private void launchRescache_Click(object sender, EventArgs e)
        {
            SharedVars.launchProc("rescache.exe", launchRescache);
        }

        private void launchSisi_Click(object sender, EventArgs e)
        {
            SharedVars.launchProc("eve.exe", "/server:Singularity", launchSisi);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }


}
