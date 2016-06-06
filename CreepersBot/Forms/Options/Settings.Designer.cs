namespace CreepersBot
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
            this.tb_Channel = new System.Windows.Forms.TextBox();
            this.gb_Account = new System.Windows.Forms.GroupBox();
            this.b_Save = new System.Windows.Forms.Button();
            this.la_Channel = new System.Windows.Forms.Label();
            this.b_Exit = new System.Windows.Forms.Button();
            this.gb_Account.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Channel
            // 
            this.tb_Channel.Location = new System.Drawing.Point(92, 13);
            this.tb_Channel.Name = "tb_Channel";
            this.tb_Channel.Size = new System.Drawing.Size(100, 20);
            this.tb_Channel.TabIndex = 0;
            // 
            // gb_Account
            // 
            this.gb_Account.Controls.Add(this.la_Channel);
            this.gb_Account.Controls.Add(this.tb_Channel);
            this.gb_Account.Location = new System.Drawing.Point(12, 12);
            this.gb_Account.Name = "gb_Account";
            this.gb_Account.Size = new System.Drawing.Size(260, 100);
            this.gb_Account.TabIndex = 1;
            this.gb_Account.TabStop = false;
            this.gb_Account.Text = "Account";
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(12, 227);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(75, 23);
            this.b_Save.TabIndex = 2;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // la_Channel
            // 
            this.la_Channel.AutoSize = true;
            this.la_Channel.Location = new System.Drawing.Point(6, 16);
            this.la_Channel.Name = "la_Channel";
            this.la_Channel.Size = new System.Drawing.Size(80, 13);
            this.la_Channel.TabIndex = 1;
            this.la_Channel.Text = "Channel Name:";
            // 
            // b_Exit
            // 
            this.b_Exit.Location = new System.Drawing.Point(191, 227);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(75, 23);
            this.b_Exit.TabIndex = 2;
            this.b_Exit.Text = "Exit";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.b_Exit);
            this.Controls.Add(this.gb_Account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.Text = "f_Settings";
            this.Load += new System.EventHandler(this.f_Settings_Load);
            this.gb_Account.ResumeLayout(false);
            this.gb_Account.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Channel;
        private System.Windows.Forms.GroupBox gb_Account;
        private System.Windows.Forms.Label la_Channel;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Exit;
    }
}