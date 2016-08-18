namespace CreepyBot
{
    public partial class f_Main
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            this.Notifications = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_Menu = new System.Windows.Forms.MenuStrip();
            this.botToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_viewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Authors = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Send = new System.Windows.Forms.TextBox();
            this.ircTimer = new System.Windows.Forms.Timer(this.components);
            this.tc_1 = new System.Windows.Forms.TabControl();
            this.tp_1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtb_Chat = new System.Windows.Forms.RichTextBox();
            this.tp_2 = new System.Windows.Forms.TabPage();
            this.b_Send = new CreepyBot.Utils.RedButton();
            this.button1 = new CreepyBot.Utils.RedButton();
            this.m_Menu.SuspendLayout();
            this.tc_1.SuspendLayout();
            this.tp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notifications
            // 
            this.Notifications.Icon = ((System.Drawing.Icon)(resources.GetObject("Notifications.Icon")));
            this.Notifications.Text = "CreepersBot";
            this.Notifications.Visible = true;
            // 
            // m_Menu
            // 
            this.m_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botToolStripMenuItem,
            this.mi_Settings,
            this.mi_Help});
            this.m_Menu.Location = new System.Drawing.Point(0, 0);
            this.m_Menu.Name = "m_Menu";
            this.m_Menu.Size = new System.Drawing.Size(848, 24);
            this.m_Menu.TabIndex = 0;
            this.m_Menu.Text = "m_Menu";
            // 
            // botToolStripMenuItem
            // 
            this.botToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Connect,
            this.mi_Disconnect,
            this.mi_Exit});
            this.botToolStripMenuItem.Name = "botToolStripMenuItem";
            this.botToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.botToolStripMenuItem.Text = "Bot";
            // 
            // mi_Connect
            // 
            this.mi_Connect.Name = "mi_Connect";
            this.mi_Connect.Size = new System.Drawing.Size(133, 22);
            this.mi_Connect.Text = "Connect";
            this.mi_Connect.Click += new System.EventHandler(this.b_connact);
            // 
            // mi_Disconnect
            // 
            this.mi_Disconnect.Enabled = false;
            this.mi_Disconnect.Name = "mi_Disconnect";
            this.mi_Disconnect.Size = new System.Drawing.Size(133, 22);
            this.mi_Disconnect.Text = "Disconnect";
            this.mi_Disconnect.Click += new System.EventHandler(this.Disconnect);
            // 
            // mi_Exit
            // 
            this.mi_Exit.Name = "mi_Exit";
            this.mi_Exit.Size = new System.Drawing.Size(133, 22);
            this.mi_Exit.Text = "Exit";
            this.mi_Exit.Click += new System.EventHandler(this.mi_Exit_e);
            // 
            // mi_Settings
            // 
            this.mi_Settings.Name = "mi_Settings";
            this.mi_Settings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mi_Settings.Size = new System.Drawing.Size(61, 20);
            this.mi_Settings.Text = "Settings";
            this.mi_Settings.Click += new System.EventHandler(this.mi_Settings_Click);
            // 
            // mi_Help
            // 
            this.mi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_viewHelp,
            this.mi_About,
            this.mi_Authors});
            this.mi_Help.Name = "mi_Help";
            this.mi_Help.Size = new System.Drawing.Size(44, 20);
            this.mi_Help.Text = "Help";
            // 
            // mi_viewHelp
            // 
            this.mi_viewHelp.Name = "mi_viewHelp";
            this.mi_viewHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mi_viewHelp.Size = new System.Drawing.Size(173, 22);
            this.mi_viewHelp.Text = "View Help";
            // 
            // mi_About
            // 
            this.mi_About.Name = "mi_About";
            this.mi_About.Size = new System.Drawing.Size(173, 22);
            this.mi_About.Text = "About CreepyBot";
            // 
            // mi_Authors
            // 
            this.mi_Authors.Name = "mi_Authors";
            this.mi_Authors.Size = new System.Drawing.Size(173, 22);
            this.mi_Authors.Text = "Authors";
            this.mi_Authors.Click += new System.EventHandler(this.mi_Authors_Click);
            // 
            // tb_Send
            // 
            this.tb_Send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Send.Enabled = false;
            this.tb_Send.Location = new System.Drawing.Point(6, 357);
            this.tb_Send.MaxLength = 150;
            this.tb_Send.Name = "tb_Send";
            this.tb_Send.Size = new System.Drawing.Size(496, 20);
            this.tb_Send.TabIndex = 2;
            this.tb_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eSend);
            // 
            // ircTimer
            // 
            this.ircTimer.Tick += new System.EventHandler(this.Timer);
            // 
            // tc_1
            // 
            this.tc_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_1.Controls.Add(this.tp_1);
            this.tc_1.Controls.Add(this.tp_2);
            this.tc_1.Location = new System.Drawing.Point(12, 27);
            this.tc_1.Name = "tc_1";
            this.tc_1.SelectedIndex = 0;
            this.tc_1.Size = new System.Drawing.Size(824, 409);
            this.tc_1.TabIndex = 4;
            // 
            // tp_1
            // 
            this.tp_1.Controls.Add(this.splitContainer1);
            this.tp_1.Location = new System.Drawing.Point(4, 22);
            this.tp_1.Name = "tp_1";
            this.tp_1.Padding = new System.Windows.Forms.Padding(3);
            this.tp_1.Size = new System.Drawing.Size(816, 383);
            this.tp_1.TabIndex = 0;
            this.tp_1.Text = "Chat";
            this.tp_1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.b_Send);
            this.splitContainer1.Panel1.Controls.Add(this.tb_Send);
            this.splitContainer1.Panel1.Controls.Add(this.rtb_Chat);
            this.splitContainer1.Panel1MinSize = 256;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(816, 383);
            this.splitContainer1.SplitterDistance = 586;
            this.splitContainer1.TabIndex = 6;
            // 
            // rtb_Chat
            // 
            this.rtb_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Chat.Location = new System.Drawing.Point(6, 6);
            this.rtb_Chat.Name = "rtb_Chat";
            this.rtb_Chat.Size = new System.Drawing.Size(577, 345);
            this.rtb_Chat.TabIndex = 5;
            this.rtb_Chat.Text = "";
            // 
            // tp_2
            // 
            this.tp_2.Location = new System.Drawing.Point(4, 22);
            this.tp_2.Name = "tp_2";
            this.tp_2.Padding = new System.Windows.Forms.Padding(3);
            this.tp_2.Size = new System.Drawing.Size(816, 383);
            this.tp_2.TabIndex = 1;
            this.tp_2.Text = "Auto";
            this.tp_2.UseVisualStyleBackColor = true;
            // 
            // b_Send
            // 
            this.b_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.b_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Send.Enabled = false;
            this.b_Send.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.b_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Send.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Send.ForeColor = System.Drawing.Color.White;
            this.b_Send.Location = new System.Drawing.Point(508, 355);
            this.b_Send.MinimumSize = new System.Drawing.Size(75, 23);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(75, 23);
            this.b_Send.TabIndex = 3;
            this.b_Send.Text = "Send";
            this.b_Send.UseVisualStyleBackColor = true;
            this.b_Send.Click += new System.EventHandler(this.bSend);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(145, 354);
            this.button1.MinimumSize = new System.Drawing.Size(75, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Don\'t press";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.aUpdate);
            // 
            // f_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 448);
            this.Controls.Add(this.tc_1);
            this.Controls.Add(this.m_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_Menu;
            this.Name = "f_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.m_Menu.ResumeLayout(false);
            this.m_Menu.PerformLayout();
            this.tc_1.ResumeLayout(false);
            this.tp_1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Notifications;
        private System.Windows.Forms.MenuStrip m_Menu;
        private System.Windows.Forms.ToolStripMenuItem mi_Settings;
        private System.Windows.Forms.ToolStripMenuItem mi_Help;
        private System.Windows.Forms.ToolStripMenuItem mi_viewHelp;
        private System.Windows.Forms.ToolStripMenuItem mi_About;
        private System.Windows.Forms.ToolStripMenuItem mi_Authors;
        private System.Windows.Forms.TextBox tb_Send;
        private System.Windows.Forms.Timer ircTimer;
        private System.Windows.Forms.ToolStripMenuItem botToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_Connect;
        private System.Windows.Forms.ToolStripMenuItem mi_Disconnect;
        private Utils.RedButton b_Send;
        private System.Windows.Forms.TabControl tc_1;
        private System.Windows.Forms.TabPage tp_1;
        private System.Windows.Forms.TabPage tp_2;
        private System.Windows.Forms.ToolStripMenuItem mi_Exit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtb_Chat;
        private Utils.RedButton button1;
    }
}

