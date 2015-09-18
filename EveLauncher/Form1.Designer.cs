namespace EveLauncher
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.ccpLogo = new System.Windows.Forms.PictureBox();
            this.eveonlineLogo = new System.Windows.Forms.PictureBox();
            this.mainBackground = new System.Windows.Forms.PictureBox();
            this.playGame = new System.Windows.Forms.Button();
            this.tqLabel = new System.Windows.Forms.Label();
            this.thirtySecondTimer = new System.Windows.Forms.Timer(this.components);
            this.tqStatus = new System.Windows.Forms.Label();
            this.onlinePlayers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccpLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveonlineLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Image = global::EveLauncher.Properties.Resources.two185;
            this.settingsButton.Location = new System.Drawing.Point(12, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(47, 39);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsButton.TabIndex = 3;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.settingsButton_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            // 
            // ccpLogo
            // 
            this.ccpLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ccpLogo.BackColor = System.Drawing.Color.Transparent;
            this.ccpLogo.Image = global::EveLauncher.Properties.Resources.ccplogo;
            this.ccpLogo.Location = new System.Drawing.Point(12, 431);
            this.ccpLogo.Name = "ccpLogo";
            this.ccpLogo.Size = new System.Drawing.Size(94, 58);
            this.ccpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ccpLogo.TabIndex = 2;
            this.ccpLogo.TabStop = false;
            // 
            // eveonlineLogo
            // 
            this.eveonlineLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eveonlineLogo.BackColor = System.Drawing.Color.Transparent;
            this.eveonlineLogo.Image = global::EveLauncher.Properties.Resources.EVE_online_logo_svg;
            this.eveonlineLogo.Location = new System.Drawing.Point(382, 106);
            this.eveonlineLogo.Name = "eveonlineLogo";
            this.eveonlineLogo.Size = new System.Drawing.Size(181, 76);
            this.eveonlineLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eveonlineLogo.TabIndex = 1;
            this.eveonlineLogo.TabStop = false;
            // 
            // mainBackground
            // 
            this.mainBackground.BackColor = System.Drawing.SystemColors.Desktop;
            this.mainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBackground.InitialImage = null;
            this.mainBackground.Location = new System.Drawing.Point(0, 0);
            this.mainBackground.Name = "mainBackground";
            this.mainBackground.Size = new System.Drawing.Size(944, 501);
            this.mainBackground.TabIndex = 0;
            this.mainBackground.TabStop = false;
            // 
            // playGame
            // 
            this.playGame.Location = new System.Drawing.Point(364, 297);
            this.playGame.Name = "playGame";
            this.playGame.Size = new System.Drawing.Size(226, 23);
            this.playGame.TabIndex = 4;
            this.playGame.Text = "Play game, todo: make this icon look better";
            this.playGame.UseVisualStyleBackColor = true;
            this.playGame.Click += new System.EventHandler(this.playGame_Click);
            // 
            // tqLabel
            // 
            this.tqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tqLabel.AutoSize = true;
            this.tqLabel.BackColor = System.Drawing.Color.Transparent;
            this.tqLabel.Font = new System.Drawing.Font("EVE Alpha", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tqLabel.ForeColor = System.Drawing.Color.White;
            this.tqLabel.Location = new System.Drawing.Point(631, 106);
            this.tqLabel.Name = "tqLabel";
            this.tqLabel.Size = new System.Drawing.Size(209, 21);
            this.tqLabel.TabIndex = 5;
            this.tqLabel.Text = "Tranquility:";
            // 
            // thirtySecondTimer
            // 
            this.thirtySecondTimer.Enabled = true;
            this.thirtySecondTimer.Interval = 10000;
            this.thirtySecondTimer.Tick += new System.EventHandler(this.thirtySecondTimer_Tick);
            // 
            // tqStatus
            // 
            this.tqStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tqStatus.AutoSize = true;
            this.tqStatus.BackColor = System.Drawing.Color.Transparent;
            this.tqStatus.Font = new System.Drawing.Font("EVE Alpha", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tqStatus.ForeColor = System.Drawing.Color.Red;
            this.tqStatus.Location = new System.Drawing.Point(631, 140);
            this.tqStatus.Name = "tqStatus";
            this.tqStatus.Size = new System.Drawing.Size(154, 21);
            this.tqStatus.TabIndex = 6;
            this.tqStatus.Text = "Loading...";
            // 
            // onlinePlayers
            // 
            this.onlinePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlinePlayers.AutoSize = true;
            this.onlinePlayers.BackColor = System.Drawing.Color.Transparent;
            this.onlinePlayers.Font = new System.Drawing.Font("EVE Alpha", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePlayers.ForeColor = System.Drawing.Color.Green;
            this.onlinePlayers.Location = new System.Drawing.Point(631, 177);
            this.onlinePlayers.Name = "onlinePlayers";
            this.onlinePlayers.Size = new System.Drawing.Size(154, 21);
            this.onlinePlayers.TabIndex = 7;
            this.onlinePlayers.Text = "Loading...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.onlinePlayers);
            this.Controls.Add(this.tqStatus);
            this.Controls.Add(this.tqLabel);
            this.Controls.Add(this.playGame);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ccpLogo);
            this.Controls.Add(this.eveonlineLogo);
            this.Controls.Add(this.mainBackground);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainWindow";
            this.Text = "Edna\'s Launcher";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccpLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveonlineLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainBackground;
        private System.Windows.Forms.PictureBox eveonlineLogo;
        private System.Windows.Forms.PictureBox ccpLogo;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.Button playGame;
        private System.Windows.Forms.Label tqLabel;
        private System.Windows.Forms.Timer thirtySecondTimer;
        public System.Windows.Forms.Label tqStatus;
        public System.Windows.Forms.Label onlinePlayers;
    }
}

