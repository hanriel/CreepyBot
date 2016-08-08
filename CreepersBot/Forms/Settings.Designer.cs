namespace CreepyBot
{
    partial class Settings
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
            this.tb_Channel = new System.Windows.Forms.TextBox();
            this.gb_Account = new System.Windows.Forms.GroupBox();
            this.ll_oAuth = new System.Windows.Forms.LinkLabel();
            this.la_Channel = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.la_UserName = new System.Windows.Forms.Label();
            this.tb_oAuth = new System.Windows.Forms.TextBox();
            this.b_Save = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.la_msgMax = new System.Windows.Forms.Label();
            this.la_msgDelay = new System.Windows.Forms.Label();
            this.tc_Settings = new System.Windows.Forms.TabControl();
            this.tb_Account = new System.Windows.Forms.TabPage();
            this.tp_Chat = new System.Windows.Forms.TabPage();
            this.tp_Notify = new System.Windows.Forms.TabPage();
            this.gb_Sound = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.b_removeTrack = new System.Windows.Forms.Button();
            this.b_sAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.la_Track = new System.Windows.Forms.Label();
            this.la_Volume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cb_Notify = new System.Windows.Forms.CheckBox();
            this.la_What = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tp_Commands = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_cmdRemove = new System.Windows.Forms.Button();
            this.lb_cmdList = new System.Windows.Forms.ListBox();
            this.b_cmdAdd = new System.Windows.Forms.Button();
            this.tt_1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gb_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tc_Settings.SuspendLayout();
            this.tb_Account.SuspendLayout();
            this.tp_Chat.SuspendLayout();
            this.tp_Notify.SuspendLayout();
            this.gb_Sound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tp_Commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Channel
            // 
            this.tb_Channel.Location = new System.Drawing.Point(92, 13);
            this.tb_Channel.Name = "tb_Channel";
            this.tb_Channel.Size = new System.Drawing.Size(100, 20);
            this.tb_Channel.TabIndex = 0;
            this.tt_1.SetToolTip(this.tb_Channel, "The channel name you want to connect.");
            // 
            // gb_Account
            // 
            this.gb_Account.Controls.Add(this.ll_oAuth);
            this.gb_Account.Controls.Add(this.la_Channel);
            this.gb_Account.Controls.Add(this.tb_User);
            this.gb_Account.Controls.Add(this.la_UserName);
            this.gb_Account.Controls.Add(this.tb_oAuth);
            this.gb_Account.Controls.Add(this.tb_Channel);
            this.gb_Account.Location = new System.Drawing.Point(6, 6);
            this.gb_Account.Name = "gb_Account";
            this.gb_Account.Size = new System.Drawing.Size(260, 100);
            this.gb_Account.TabIndex = 1;
            this.gb_Account.TabStop = false;
            this.gb_Account.Text = "Account";
            // 
            // ll_oAuth
            // 
            this.ll_oAuth.AutoSize = true;
            this.ll_oAuth.Location = new System.Drawing.Point(6, 70);
            this.ll_oAuth.Name = "ll_oAuth";
            this.ll_oAuth.Size = new System.Drawing.Size(38, 13);
            this.ll_oAuth.TabIndex = 5;
            this.ll_oAuth.TabStop = true;
            this.ll_oAuth.Text = "oAuth:";
            this.tt_1.SetToolTip(this.ll_oAuth, "Key authorization issued by the service Twitch.tv\r\nClick on the link something to" +
        " get it ->");
            // 
            // la_Channel
            // 
            this.la_Channel.AutoSize = true;
            this.la_Channel.Location = new System.Drawing.Point(6, 16);
            this.la_Channel.Name = "la_Channel";
            this.la_Channel.Size = new System.Drawing.Size(80, 13);
            this.la_Channel.TabIndex = 1;
            this.la_Channel.Text = "Channel Name:";
            this.tt_1.SetToolTip(this.la_Channel, "The channel name you want to connect.");
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(92, 40);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(100, 20);
            this.tb_User.TabIndex = 2;
            this.tt_1.SetToolTip(this.tb_User, "Bot user name that will be connected to the channel.");
            // 
            // la_UserName
            // 
            this.la_UserName.AutoSize = true;
            this.la_UserName.Location = new System.Drawing.Point(6, 43);
            this.la_UserName.Name = "la_UserName";
            this.la_UserName.Size = new System.Drawing.Size(63, 13);
            this.la_UserName.TabIndex = 4;
            this.la_UserName.Text = "User Name:";
            this.tt_1.SetToolTip(this.la_UserName, "Bot user name that will be connected to the channel.");
            // 
            // tb_oAuth
            // 
            this.tb_oAuth.Location = new System.Drawing.Point(92, 67);
            this.tb_oAuth.Name = "tb_oAuth";
            this.tb_oAuth.PasswordChar = '*';
            this.tb_oAuth.Size = new System.Drawing.Size(100, 20);
            this.tb_oAuth.TabIndex = 3;
            this.tt_1.SetToolTip(this.tb_oAuth, "Key authorization issued by the service Twitch.tv\r\nClick on the link something to" +
        " get it ->");
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(12, 332);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(75, 23);
            this.b_Save.TabIndex = 2;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 9);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(89, 35);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // la_msgMax
            // 
            this.la_msgMax.AutoSize = true;
            this.la_msgMax.Location = new System.Drawing.Point(6, 15);
            this.la_msgMax.Name = "la_msgMax";
            this.la_msgMax.Size = new System.Drawing.Size(73, 13);
            this.la_msgMax.TabIndex = 5;
            this.la_msgMax.Text = "Max Message";
            // 
            // la_msgDelay
            // 
            this.la_msgDelay.AutoSize = true;
            this.la_msgDelay.Location = new System.Drawing.Point(6, 41);
            this.la_msgDelay.Name = "la_msgDelay";
            this.la_msgDelay.Size = new System.Drawing.Size(80, 13);
            this.la_msgDelay.TabIndex = 6;
            this.la_msgDelay.Text = "Message Delay";
            // 
            // tc_Settings
            // 
            this.tc_Settings.Controls.Add(this.tb_Account);
            this.tc_Settings.Controls.Add(this.tp_Chat);
            this.tc_Settings.Controls.Add(this.tp_Notify);
            this.tc_Settings.Controls.Add(this.tp_Commands);
            this.tc_Settings.Location = new System.Drawing.Point(12, 12);
            this.tc_Settings.Name = "tc_Settings";
            this.tc_Settings.SelectedIndex = 0;
            this.tc_Settings.Size = new System.Drawing.Size(538, 314);
            this.tc_Settings.TabIndex = 9;
            // 
            // tb_Account
            // 
            this.tb_Account.Controls.Add(this.gb_Account);
            this.tb_Account.Location = new System.Drawing.Point(4, 22);
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Account.Size = new System.Drawing.Size(530, 288);
            this.tb_Account.TabIndex = 0;
            this.tb_Account.Text = "Account";
            this.tb_Account.UseVisualStyleBackColor = true;
            // 
            // tp_Chat
            // 
            this.tp_Chat.Controls.Add(this.la_msgMax);
            this.tp_Chat.Controls.Add(this.numericUpDown1);
            this.tp_Chat.Controls.Add(this.numericUpDown2);
            this.tp_Chat.Controls.Add(this.la_msgDelay);
            this.tp_Chat.Location = new System.Drawing.Point(4, 22);
            this.tp_Chat.Name = "tp_Chat";
            this.tp_Chat.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Chat.Size = new System.Drawing.Size(530, 288);
            this.tp_Chat.TabIndex = 1;
            this.tp_Chat.Text = "Chat";
            this.tp_Chat.UseVisualStyleBackColor = true;
            // 
            // tp_Notify
            // 
            this.tp_Notify.Controls.Add(this.gb_Sound);
            this.tp_Notify.Controls.Add(this.cb_Notify);
            this.tp_Notify.Controls.Add(this.la_What);
            this.tp_Notify.Controls.Add(this.checkedListBox1);
            this.tp_Notify.Location = new System.Drawing.Point(4, 22);
            this.tp_Notify.Name = "tp_Notify";
            this.tp_Notify.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Notify.Size = new System.Drawing.Size(530, 288);
            this.tp_Notify.TabIndex = 2;
            this.tp_Notify.Text = "Notify";
            this.tp_Notify.UseVisualStyleBackColor = true;
            // 
            // gb_Sound
            // 
            this.gb_Sound.Controls.Add(this.numericUpDown3);
            this.gb_Sound.Controls.Add(this.b_removeTrack);
            this.gb_Sound.Controls.Add(this.b_sAdd);
            this.gb_Sound.Controls.Add(this.comboBox1);
            this.gb_Sound.Controls.Add(this.la_Track);
            this.gb_Sound.Controls.Add(this.la_Volume);
            this.gb_Sound.Controls.Add(this.trackBar1);
            this.gb_Sound.Location = new System.Drawing.Point(210, 6);
            this.gb_Sound.Name = "gb_Sound";
            this.gb_Sound.Size = new System.Drawing.Size(314, 276);
            this.gb_Sound.TabIndex = 4;
            this.gb_Sound.TabStop = false;
            this.gb_Sound.Text = "Sound";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(57, 67);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown3.TabIndex = 9;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // b_removeTrack
            // 
            this.b_removeTrack.Location = new System.Drawing.Point(131, 11);
            this.b_removeTrack.Name = "b_removeTrack";
            this.b_removeTrack.Size = new System.Drawing.Size(75, 23);
            this.b_removeTrack.TabIndex = 7;
            this.b_removeTrack.Text = "Remove";
            this.b_removeTrack.UseVisualStyleBackColor = true;
            this.b_removeTrack.Click += new System.EventHandler(this.b_removeTrack_Click);
            // 
            // b_sAdd
            // 
            this.b_sAdd.Location = new System.Drawing.Point(50, 11);
            this.b_sAdd.Name = "b_sAdd";
            this.b_sAdd.Size = new System.Drawing.Size(75, 23);
            this.b_sAdd.TabIndex = 6;
            this.b_sAdd.Text = "Add";
            this.b_sAdd.UseVisualStyleBackColor = true;
            this.b_sAdd.Click += new System.EventHandler(this.b_sAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Хуйня.wav",
            "Блядина.wav"});
            this.comboBox1.Location = new System.Drawing.Point(9, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // la_Track
            // 
            this.la_Track.AutoSize = true;
            this.la_Track.Location = new System.Drawing.Point(6, 16);
            this.la_Track.Name = "la_Track";
            this.la_Track.Size = new System.Drawing.Size(38, 13);
            this.la_Track.TabIndex = 4;
            this.la_Track.Text = "Track:";
            // 
            // la_Volume
            // 
            this.la_Volume.AutoSize = true;
            this.la_Volume.Location = new System.Drawing.Point(6, 69);
            this.la_Volume.Name = "la_Volume";
            this.la_Volume.Size = new System.Drawing.Size(45, 13);
            this.la_Volume.TabIndex = 3;
            this.la_Volume.Text = "Volume:";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(6, 93);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(302, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cb_Notify
            // 
            this.cb_Notify.AutoSize = true;
            this.cb_Notify.Location = new System.Drawing.Point(9, 265);
            this.cb_Notify.Name = "cb_Notify";
            this.cb_Notify.Size = new System.Drawing.Size(59, 17);
            this.cb_Notify.TabIndex = 2;
            this.cb_Notify.Text = "Notify?";
            this.cb_Notify.UseVisualStyleBackColor = true;
            // 
            // la_What
            // 
            this.la_What.AutoSize = true;
            this.la_What.Location = new System.Drawing.Point(6, 3);
            this.la_What.Name = "la_What";
            this.la_What.Size = new System.Drawing.Size(60, 13);
            this.la_What.TabIndex = 1;
            this.la_What.Text = "What Alert:";
            this.tt_1.SetToolTip(this.la_What, "What are the warning display?");
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "User joined the channel",
            "User disconnected from the channel",
            "New message",
            "User has Followed",
            "User has Subscribed"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(198, 79);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tp_Commands
            // 
            this.tp_Commands.Controls.Add(this.label2);
            this.tp_Commands.Controls.Add(this.richTextBox1);
            this.tp_Commands.Controls.Add(this.label1);
            this.tp_Commands.Controls.Add(this.textBox1);
            this.tp_Commands.Controls.Add(this.b_cmdRemove);
            this.tp_Commands.Controls.Add(this.lb_cmdList);
            this.tp_Commands.Controls.Add(this.b_cmdAdd);
            this.tp_Commands.Location = new System.Drawing.Point(4, 22);
            this.tp_Commands.Name = "tp_Commands";
            this.tp_Commands.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Commands.Size = new System.Drawing.Size(530, 288);
            this.tp_Commands.TabIndex = 3;
            this.tp_Commands.Text = "Commands";
            this.tp_Commands.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Return:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(307, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(217, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Command:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 4;
            // 
            // b_cmdRemove
            // 
            this.b_cmdRemove.Location = new System.Drawing.Point(449, 144);
            this.b_cmdRemove.Name = "b_cmdRemove";
            this.b_cmdRemove.Size = new System.Drawing.Size(75, 23);
            this.b_cmdRemove.TabIndex = 3;
            this.b_cmdRemove.Text = "Remove";
            this.b_cmdRemove.UseVisualStyleBackColor = true;
            // 
            // lb_cmdList
            // 
            this.lb_cmdList.FormattingEnabled = true;
            this.lb_cmdList.Location = new System.Drawing.Point(87, 16);
            this.lb_cmdList.Name = "lb_cmdList";
            this.lb_cmdList.Size = new System.Drawing.Size(151, 251);
            this.lb_cmdList.TabIndex = 1;
            this.lb_cmdList.SelectedIndexChanged += new System.EventHandler(this.lb_cmdList_SelectedIndexChanged);
            // 
            // b_cmdAdd
            // 
            this.b_cmdAdd.Location = new System.Drawing.Point(247, 144);
            this.b_cmdAdd.Name = "b_cmdAdd";
            this.b_cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.b_cmdAdd.TabIndex = 0;
            this.b_cmdAdd.Text = "Add";
            this.b_cmdAdd.UseVisualStyleBackColor = true;
            this.b_cmdAdd.Click += new System.EventHandler(this.b_cmdAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Audio files|*.mp3;*.wav;*.ogg";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 363);
            this.Controls.Add(this.tc_Settings);
            this.Controls.Add(this.b_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.f_Settings_Load);
            this.gb_Account.ResumeLayout(false);
            this.gb_Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tc_Settings.ResumeLayout(false);
            this.tb_Account.ResumeLayout(false);
            this.tp_Chat.ResumeLayout(false);
            this.tp_Chat.PerformLayout();
            this.tp_Notify.ResumeLayout(false);
            this.tp_Notify.PerformLayout();
            this.gb_Sound.ResumeLayout(false);
            this.gb_Sound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tp_Commands.ResumeLayout(false);
            this.tp_Commands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Channel;
        private System.Windows.Forms.GroupBox gb_Account;
        private System.Windows.Forms.Label la_Channel;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.LinkLabel ll_oAuth;
        private System.Windows.Forms.Label la_UserName;
        private System.Windows.Forms.TextBox tb_oAuth;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label la_msgMax;
        private System.Windows.Forms.Label la_msgDelay;
        private System.Windows.Forms.TabControl tc_Settings;
        private System.Windows.Forms.TabPage tb_Account;
        private System.Windows.Forms.TabPage tp_Chat;
        private System.Windows.Forms.TabPage tp_Notify;
        private System.Windows.Forms.CheckBox cb_Notify;
        private System.Windows.Forms.Label la_What;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolTip tt_1;
        private System.Windows.Forms.GroupBox gb_Sound;
        private System.Windows.Forms.Label la_Track;
        private System.Windows.Forms.Label la_Volume;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button b_removeTrack;
        private System.Windows.Forms.Button b_sAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tp_Commands;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_cmdRemove;
        private System.Windows.Forms.ListBox lb_cmdList;
        private System.Windows.Forms.Button b_cmdAdd;
    }
}