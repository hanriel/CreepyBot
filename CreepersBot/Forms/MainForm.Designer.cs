namespace CreepyBot
{
    partial class f_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            this.Notifications = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_Menu = new System.Windows.Forms.MenuStrip();
            this.botToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_viewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Authors = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_Chat = new System.Windows.Forms.RichTextBox();
            this.tb_Send = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_SendMSG = new System.Windows.Forms.Button();
            this.tc_1 = new System.Windows.Forms.TabControl();
            this.tp_1 = new System.Windows.Forms.TabPage();
            this.tp_2 = new System.Windows.Forms.TabPage();
            this.m_Menu.SuspendLayout();
            this.tc_1.SuspendLayout();
            this.tp_1.SuspendLayout();
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
            this.mi_Options,
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
            this.mi_Disconnect});
            this.botToolStripMenuItem.Name = "botToolStripMenuItem";
            this.botToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.botToolStripMenuItem.Text = "Bot";
            // 
            // mi_Connect
            // 
            this.mi_Connect.Name = "mi_Connect";
            this.mi_Connect.Size = new System.Drawing.Size(133, 22);
            this.mi_Connect.Text = "Connect";
            this.mi_Connect.Click += new System.EventHandler(this.sConnect);
            // 
            // mi_Disconnect
            // 
            this.mi_Disconnect.Enabled = false;
            this.mi_Disconnect.Name = "mi_Disconnect";
            this.mi_Disconnect.Size = new System.Drawing.Size(133, 22);
            this.mi_Disconnect.Text = "Disconnect";
            this.mi_Disconnect.Click += new System.EventHandler(this.sDisconnect);
            // 
            // mi_Options
            // 
            this.mi_Options.Name = "mi_Options";
            this.mi_Options.Size = new System.Drawing.Size(61, 20);
            this.mi_Options.Text = "Options";
            this.mi_Options.Click += new System.EventHandler(this.mi_Options_Click);
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
            // rtb_Chat
            // 
            this.rtb_Chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.rtb_Chat.ForeColor = System.Drawing.SystemColors.Window;
            this.rtb_Chat.Location = new System.Drawing.Point(6, 6);
            this.rtb_Chat.Name = "rtb_Chat";
            this.rtb_Chat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_Chat.Size = new System.Drawing.Size(400, 345);
            this.rtb_Chat.TabIndex = 1;
            this.rtb_Chat.Text = "";
            // 
            // tb_Send
            // 
            this.tb_Send.Location = new System.Drawing.Point(6, 357);
            this.tb_Send.Name = "tb_Send";
            this.tb_Send.Size = new System.Drawing.Size(319, 20);
            this.tb_Send.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // b_SendMSG
            // 
            this.b_SendMSG.Enabled = false;
            this.b_SendMSG.Location = new System.Drawing.Point(331, 354);
            this.b_SendMSG.Name = "b_SendMSG";
            this.b_SendMSG.Size = new System.Drawing.Size(75, 23);
            this.b_SendMSG.TabIndex = 3;
            this.b_SendMSG.Text = "Send";
            this.b_SendMSG.UseVisualStyleBackColor = true;
            // 
            // tc_1
            // 
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
            this.tp_1.Controls.Add(this.rtb_Chat);
            this.tp_1.Controls.Add(this.tb_Send);
            this.tp_1.Controls.Add(this.b_SendMSG);
            this.tp_1.Location = new System.Drawing.Point(4, 22);
            this.tp_1.Name = "tp_1";
            this.tp_1.Padding = new System.Windows.Forms.Padding(3);
            this.tp_1.Size = new System.Drawing.Size(816, 383);
            this.tp_1.TabIndex = 0;
            this.tp_1.Text = "Chat";
            this.tp_1.UseVisualStyleBackColor = true;
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
            // f_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 448);
            this.Controls.Add(this.tc_1);
            this.Controls.Add(this.m_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_Menu;
            this.MaximizeBox = false;
            this.Name = "f_Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.m_Menu.ResumeLayout(false);
            this.m_Menu.PerformLayout();
            this.tc_1.ResumeLayout(false);
            this.tp_1.ResumeLayout(false);
            this.tp_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Notifications;
        private System.Windows.Forms.MenuStrip m_Menu;
        private System.Windows.Forms.ToolStripMenuItem mi_Options;
        private System.Windows.Forms.ToolStripMenuItem mi_Help;
        private System.Windows.Forms.ToolStripMenuItem mi_viewHelp;
        private System.Windows.Forms.ToolStripMenuItem mi_About;
        private System.Windows.Forms.ToolStripMenuItem mi_Authors;
        private System.Windows.Forms.RichTextBox rtb_Chat;
        private System.Windows.Forms.TextBox tb_Send;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem botToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_Connect;
        private System.Windows.Forms.ToolStripMenuItem mi_Disconnect;
        private System.Windows.Forms.Button b_SendMSG;
        private System.Windows.Forms.TabControl tc_1;
        private System.Windows.Forms.TabPage tp_1;
        private System.Windows.Forms.TabPage tp_2;
    }
}

