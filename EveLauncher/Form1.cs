using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace EveLauncher
{

    public partial class MainWindow : Form
    {
        readonly Color highlightColor = Color.FromArgb(128, 70, 194, 255);

        public MainWindow()
        {
            InitializeComponent();
            updateMainBackground();

            //makes pictureboxes transparent
            mainBackground.Controls.Add(ccpLogo);
            mainBackground.Controls.Add(eveonlineLogo);
            mainBackground.Controls.Add(settingsButton);
            mainBackground.Controls.Add(tqLabel);
            mainBackground.Controls.Add(tqStatus);
            mainBackground.Controls.Add(onlinePlayers);

            API_Interface.formManage(this);
            SharedVars.setDefaults();
        }

        void updateMainBackground()
        {
            Image img = Properties.Resources.BackgroundMain;
            Rectangle newRect = ImageHandling.GetScaledRectangle(img, mainBackground.ClientRectangle);
            mainBackground.Image = ImageHandling.GetResizedImage(img, newRect);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            updateMainBackground();
        }

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.BackColor = highlightColor;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.Transparent;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();        
        }

        private void thirtySecondTimer_Tick(object sender, EventArgs e)
        {
            API_Interface.getSeverStatus();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            API_Interface.getSeverStatus();
        }

        private void playGame_Click(object sender, EventArgs e)
        {
            SharedVars.launchProc(@"bin\exefile.exe", playGame);
        }
    }
}
