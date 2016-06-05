namespace CreepersBot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Notifications = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.aboutMB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMB = new System.Windows.Forms.ToolStripMenuItem();
            this.vTw = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mlg = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMB = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.opt = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notifications
            // 
            this.Notifications.Icon = ((System.Drawing.Icon)(resources.GetObject("Notifications.Icon")));
            this.Notifications.Text = "CreepersBot";
            this.Notifications.Visible = true;
            this.Notifications.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.N_MDC);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt,
            this.toolsMB,
            this.aboutMB,
            this.exitMB});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(624, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "CreepersBot Menu";
            // 
            // aboutMB
            // 
            this.aboutMB.Name = "aboutMB";
            this.aboutMB.Size = new System.Drawing.Size(52, 20);
            this.aboutMB.Text = "About";
            this.aboutMB.Click += new System.EventHandler(this.aboutMB_Click);
            // 
            // toolsMB
            // 
            this.toolsMB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vTw,
            this.twitchChatToolStripMenuItem,
            this.mlg});
            this.toolsMB.Name = "toolsMB";
            this.toolsMB.Size = new System.Drawing.Size(48, 20);
            this.toolsMB.Text = "Tools";
            // 
            // vTw
            // 
            this.vTw.Name = "vTw";
            this.vTw.Size = new System.Drawing.Size(154, 22);
            this.vTw.Text = "TwitchChannel";
            this.vTw.Click += new System.EventHandler(this.vTw_Click);
            // 
            // twitchChatToolStripMenuItem
            // 
            this.twitchChatToolStripMenuItem.Name = "twitchChatToolStripMenuItem";
            this.twitchChatToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.twitchChatToolStripMenuItem.Text = "TwitchChat";
            // 
            // mlg
            // 
            this.mlg.Name = "mlg";
            this.mlg.Size = new System.Drawing.Size(154, 22);
            this.mlg.Text = "MLG";
            this.mlg.Click += new System.EventHandler(this.mlg_Click);
            // 
            // exitMB
            // 
            this.exitMB.Name = "exitMB";
            this.exitMB.Size = new System.Drawing.Size(37, 20);
            this.exitMB.Text = "Exit";
            this.exitMB.Click += new System.EventHandler(this.exitMB_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // opt
            // 
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(61, 20);
            this.opt.Text = "Options";
            this.opt.Click += new System.EventHandler(this.opt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 322);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CreepersBot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

       }

        #endregion

        private System.Windows.Forms.NotifyIcon Notifications;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem aboutMB;
        private System.Windows.Forms.ToolStripMenuItem exitMB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolsMB;
        private System.Windows.Forms.ToolStripMenuItem vTw;
        private System.Windows.Forms.ToolStripMenuItem twitchChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mlg;
        private System.Windows.Forms.ToolStripMenuItem opt;
    }
}

