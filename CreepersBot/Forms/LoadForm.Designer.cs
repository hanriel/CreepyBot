namespace CreepersBot.Forms
{
    partial class LoadForm
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
            this.i_Logo = new System.Windows.Forms.PictureBox();
            this.b_Load = new System.Windows.Forms.Button();
            this.la_Name = new System.Windows.Forms.Label();
            this.b_Exit = new System.Windows.Forms.Button();
            this.la_Info = new System.Windows.Forms.Label();
            this.ll_SAF = new System.Windows.Forms.LinkLabel();
            this.la_Dev = new System.Windows.Forms.Label();
            this.ll_Medieval = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.i_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // i_Logo
            // 
            this.i_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i_Logo.Image = global::CreepersBot.Properties.Resources.Logo;
            this.i_Logo.Location = new System.Drawing.Point(128, 12);
            this.i_Logo.Name = "i_Logo";
            this.i_Logo.Size = new System.Drawing.Size(128, 128);
            this.i_Logo.TabIndex = 0;
            this.i_Logo.TabStop = false;
            // 
            // b_Load
            // 
            this.b_Load.Location = new System.Drawing.Point(128, 283);
            this.b_Load.Name = "b_Load";
            this.b_Load.Size = new System.Drawing.Size(128, 23);
            this.b_Load.TabIndex = 1;
            this.b_Load.Text = "Load";
            this.b_Load.UseVisualStyleBackColor = true;
            this.b_Load.Click += new System.EventHandler(this.b_Load_Click);
            // 
            // la_Name
            // 
            this.la_Name.AutoSize = true;
            this.la_Name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_Name.ForeColor = System.Drawing.Color.White;
            this.la_Name.Location = new System.Drawing.Point(124, 143);
            this.la_Name.Name = "la_Name";
            this.la_Name.Size = new System.Drawing.Size(114, 30);
            this.la_Name.TabIndex = 2;
            this.la_Name.Text = "CreepyBot";
            // 
            // b_Exit
            // 
            this.b_Exit.Location = new System.Drawing.Point(128, 312);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(128, 23);
            this.b_Exit.TabIndex = 3;
            this.b_Exit.Text = "Exit";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // la_Info
            // 
            this.la_Info.AutoSize = true;
            this.la_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_Info.ForeColor = System.Drawing.Color.White;
            this.la_Info.Location = new System.Drawing.Point(58, 173);
            this.la_Info.Name = "la_Info";
            this.la_Info.Size = new System.Drawing.Size(197, 16);
            this.la_Info.TabIndex = 4;
            this.la_Info.Text = "Thank you for using Creepy Bot ";
            // 
            // ll_SAF
            // 
            this.ll_SAF.AutoSize = true;
            this.ll_SAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ll_SAF.ForeColor = System.Drawing.SystemColors.Window;
            this.ll_SAF.LinkColor = System.Drawing.Color.White;
            this.ll_SAF.Location = new System.Drawing.Point(59, 205);
            this.ll_SAF.Name = "ll_SAF";
            this.ll_SAF.Size = new System.Drawing.Size(93, 16);
            this.ll_SAF.TabIndex = 5;
            this.ll_SAF.TabStop = true;
            this.ll_SAF.Text = "SkyAndForest";
            this.ll_SAF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_SAF_LinkClicked);
            // 
            // la_Dev
            // 
            this.la_Dev.AutoSize = true;
            this.la_Dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_Dev.ForeColor = System.Drawing.Color.White;
            this.la_Dev.Location = new System.Drawing.Point(59, 189);
            this.la_Dev.Name = "la_Dev";
            this.la_Dev.Size = new System.Drawing.Size(97, 16);
            this.la_Dev.TabIndex = 6;
            this.la_Dev.Text = "Developed by:";
            // 
            // ll_Medieval
            // 
            this.ll_Medieval.AutoSize = true;
            this.ll_Medieval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ll_Medieval.LinkColor = System.Drawing.Color.White;
            this.ll_Medieval.Location = new System.Drawing.Point(59, 221);
            this.ll_Medieval.Name = "ll_Medieval";
            this.ll_Medieval.Size = new System.Drawing.Size(83, 16);
            this.ll_Medieval.TabIndex = 7;
            this.ll_Medieval.TabStop = true;
            this.ll_Medieval.Text = "MedivalCraft";
            this.ll_Medieval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_MedievalCraft_LinkClicked);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(368, 346);
            this.ControlBox = false;
            this.Controls.Add(this.ll_Medieval);
            this.Controls.Add(this.la_Dev);
            this.Controls.Add(this.ll_SAF);
            this.Controls.Add(this.la_Info);
            this.Controls.Add(this.b_Exit);
            this.Controls.Add(this.la_Name);
            this.Controls.Add(this.b_Load);
            this.Controls.Add(this.i_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "LoadForm";
            this.Text = "CreepyBot";
            ((System.ComponentModel.ISupportInitialize)(this.i_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox i_Logo;
        private System.Windows.Forms.Button b_Load;
        private System.Windows.Forms.Label la_Name;
        private System.Windows.Forms.Button b_Exit;
        private System.Windows.Forms.Label la_Info;
        private System.Windows.Forms.LinkLabel ll_SAF;
        private System.Windows.Forms.Label la_Dev;
        private System.Windows.Forms.LinkLabel ll_Medieval;
    }
}