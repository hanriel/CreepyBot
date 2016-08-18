namespace CreepyBot.Forms
{
    partial class f_Load
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Load));
            this.b_Load = new CreepyBot.Utils.RedButton();
            this.la_Name = new System.Windows.Forms.Label();
            this.b_Exit = new CreepyBot.Utils.RedButton();
            this.la_Info = new System.Windows.Forms.Label();
            this.ll_SAF = new System.Windows.Forms.LinkLabel();
            this.la_Dev = new System.Windows.Forms.Label();
            this.ll_Medieval = new System.Windows.Forms.LinkLabel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Load
            // 
            this.b_Load.Location = new System.Drawing.Point(104, 262);
            this.b_Load.Name = "b_Load";
            this.b_Load.Size = new System.Drawing.Size(75, 23);
            this.b_Load.TabIndex = 1;
            this.b_Load.Text = "Load";
            this.b_Load.UseVisualStyleBackColor = true;
            this.b_Load.Click += new System.EventHandler(this.b_Load_Click);
            // 
            // la_Name
            // 
            this.la_Name.AutoSize = true;
            this.la_Name.BackColor = System.Drawing.Color.Transparent;
            this.la_Name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_Name.Location = new System.Drawing.Point(85, 164);
            this.la_Name.Name = "la_Name";
            this.la_Name.Size = new System.Drawing.Size(114, 30);
            this.la_Name.TabIndex = 2;
            this.la_Name.Text = "CreepyBot";
            // 
            // b_Exit
            // 
            this.b_Exit.Location = new System.Drawing.Point(104, 288);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(75, 23);
            this.b_Exit.TabIndex = 3;
            this.b_Exit.Text = "Exit";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // la_Info
            // 
            this.la_Info.AutoSize = true;
            this.la_Info.BackColor = System.Drawing.Color.Transparent;
            this.la_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_Info.Location = new System.Drawing.Point(49, 194);
            this.la_Info.Name = "la_Info";
            this.la_Info.Size = new System.Drawing.Size(194, 16);
            this.la_Info.TabIndex = 4;
            this.la_Info.Text = "Thank you for using Creepy Bot";
            // 
            // ll_SAF
            // 
            this.ll_SAF.AutoSize = true;
            this.ll_SAF.BackColor = System.Drawing.Color.Transparent;
            this.ll_SAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ll_SAF.Location = new System.Drawing.Point(91, 227);
            this.ll_SAF.Name = "ll_SAF";
            this.ll_SAF.Size = new System.Drawing.Size(93, 16);
            this.ll_SAF.TabIndex = 5;
            this.ll_SAF.TabStop = true;
            this.ll_SAF.Text = "SkyAndForest";
            this.ll_SAF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_SAF_e);
            // 
            // la_Dev
            // 
            this.la_Dev.AutoSize = true;
            this.la_Dev.BackColor = System.Drawing.Color.Transparent;
            this.la_Dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_Dev.Location = new System.Drawing.Point(87, 211);
            this.la_Dev.Name = "la_Dev";
            this.la_Dev.Size = new System.Drawing.Size(97, 16);
            this.la_Dev.TabIndex = 6;
            this.la_Dev.Text = "Developed by:";
            // 
            // ll_Medieval
            // 
            this.ll_Medieval.AutoSize = true;
            this.ll_Medieval.BackColor = System.Drawing.Color.Transparent;
            this.ll_Medieval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ll_Medieval.Location = new System.Drawing.Point(101, 243);
            this.ll_Medieval.Name = "ll_Medieval";
            this.ll_Medieval.Size = new System.Drawing.Size(83, 16);
            this.ll_Medieval.TabIndex = 7;
            this.ll_Medieval.TabStop = true;
            this.ll_Medieval.Text = "MedivalCraft";
            this.ll_Medieval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_MedievalCraft);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::CreepyBot.Properties.Resources.logo2_512;
            this.pb_logo.Location = new System.Drawing.Point(69, 11);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(150, 150);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 8;
            this.pb_logo.TabStop = false;
            // 
            // f_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 323);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.ll_Medieval);
            this.Controls.Add(this.la_Dev);
            this.Controls.Add(this.ll_SAF);
            this.Controls.Add(this.la_Info);
            this.Controls.Add(this.b_Exit);
            this.Controls.Add(this.la_Name);
            this.Controls.Add(this.b_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreepyBot";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CreepyBot.Utils.RedButton b_Load;
        private System.Windows.Forms.Label la_Name;
        private CreepyBot.Utils.RedButton b_Exit;
        private System.Windows.Forms.Label la_Info;
        private System.Windows.Forms.LinkLabel ll_SAF;
        private System.Windows.Forms.Label la_Dev;
        private System.Windows.Forms.LinkLabel ll_Medieval;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}