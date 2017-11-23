namespace CreepyBot.Forms
{
    partial class Debug
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
            this.b_dbTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_dbTest
            // 
            this.b_dbTest.Location = new System.Drawing.Point(13, 13);
            this.b_dbTest.Name = "b_dbTest";
            this.b_dbTest.Size = new System.Drawing.Size(75, 23);
            this.b_dbTest.TabIndex = 0;
            this.b_dbTest.Text = "DataBase";
            this.b_dbTest.UseVisualStyleBackColor = true;
            this.b_dbTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.b_dbTest);
            this.Name = "Debug";
            this.Text = "Debug";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_dbTest;
    }
}