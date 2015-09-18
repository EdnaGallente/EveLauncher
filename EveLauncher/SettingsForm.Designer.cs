namespace EveLauncher
{
    partial class SettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.launchSisi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.launchRescache = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.launchLogServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.launchRepairTool = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.launchSisi);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("EveSans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Eve Online";
            // 
            // launchSisi
            // 
            this.launchSisi.Font = new System.Drawing.Font("EveSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchSisi.Location = new System.Drawing.Point(365, 66);
            this.launchSisi.Name = "launchSisi";
            this.launchSisi.Size = new System.Drawing.Size(75, 23);
            this.launchSisi.TabIndex = 9;
            this.launchSisi.Text = "Launch";
            this.launchSisi.UseVisualStyleBackColor = true;
            this.launchSisi.Click += new System.EventHandler(this.launchSisi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("EveSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Launch the test server (sisi):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.launchRescache);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.launchLogServer);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.launchRepairTool);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("EveSans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Debug tools";
            // 
            // launchRescache
            // 
            this.launchRescache.Font = new System.Drawing.Font("EveSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchRescache.Location = new System.Drawing.Point(361, 134);
            this.launchRescache.Name = "launchRescache";
            this.launchRescache.Size = new System.Drawing.Size(75, 23);
            this.launchRescache.TabIndex = 5;
            this.launchRescache.Text = "Launch";
            this.launchRescache.UseVisualStyleBackColor = true;
            this.launchRescache.Click += new System.EventHandler(this.launchRescache_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("EveSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Launch rescache:";
            // 
            // launchLogServer
            // 
            this.launchLogServer.Font = new System.Drawing.Font("EveSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchLogServer.Location = new System.Drawing.Point(361, 99);
            this.launchLogServer.Name = "launchLogServer";
            this.launchLogServer.Size = new System.Drawing.Size(75, 23);
            this.launchLogServer.TabIndex = 3;
            this.launchLogServer.Text = "Launch";
            this.launchLogServer.UseVisualStyleBackColor = true;
            this.launchLogServer.Click += new System.EventHandler(this.launchLogServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("EveSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Launch log server:";
            // 
            // launchRepairTool
            // 
            this.launchRepairTool.Font = new System.Drawing.Font("EveSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchRepairTool.Location = new System.Drawing.Point(361, 64);
            this.launchRepairTool.Name = "launchRepairTool";
            this.launchRepairTool.Size = new System.Drawing.Size(75, 23);
            this.launchRepairTool.TabIndex = 1;
            this.launchRepairTool.Text = "Launch";
            this.launchRepairTool.UseVisualStyleBackColor = true;
            this.launchRepairTool.Click += new System.EventHandler(this.launchRepairTool_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("EveSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Launch repair tool:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button launchRescache;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button launchLogServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button launchRepairTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button launchSisi;
        private System.Windows.Forms.Label label6;
    }
}