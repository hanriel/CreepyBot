namespace CreepersBot
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
            this.mi_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Authors = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Menu.SuspendLayout();
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
            this.mi_Options,
            this.mi_Help});
            this.m_Menu.Location = new System.Drawing.Point(0, 0);
            this.m_Menu.Name = "m_Menu";
            this.m_Menu.Size = new System.Drawing.Size(624, 24);
            this.m_Menu.TabIndex = 0;
            this.m_Menu.Text = "m_Menu";
            // 
            // mi_Options
            // 
            this.mi_Options.Name = "mi_Options";
            this.mi_Options.Size = new System.Drawing.Size(61, 20);
            this.mi_Options.Text = "Options";
            // 
            // mi_Help
            // 
            this.mi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.mi_Authors,
            this.mi_About});
            this.mi_Help.Name = "mi_Help";
            this.mi_Help.Size = new System.Drawing.Size(44, 20);
            this.mi_Help.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
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
            // f_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 322);
            this.Controls.Add(this.m_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_Menu;
            this.MaximizeBox = false;
            this.Name = "f_Main";
            this.Text = "CreepersBot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.m_Menu.ResumeLayout(false);
            this.m_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

       }

        #endregion

        private System.Windows.Forms.NotifyIcon Notifications;
        private System.Windows.Forms.MenuStrip m_Menu;
        private System.Windows.Forms.ToolStripMenuItem mi_Options;
        private System.Windows.Forms.ToolStripMenuItem mi_Help;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_About;
        private System.Windows.Forms.ToolStripMenuItem mi_Authors;
    }
}

