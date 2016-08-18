namespace CreepyBot.Utils
{
    public class RedButton : System.Windows.Forms.Button
    {
        private static System.Drawing.Font _normalFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        private static System.Drawing.Color c_bg = System.Drawing.Color.FromArgb(76,36,36);
        private static System.Drawing.Color c_border = System.Drawing.Color.FromArgb(107,51,51);
        private static System.Drawing.Color c_border_active = System.Drawing.Color.Red;
        private static System.Drawing.Color c_text = System.Drawing.Color.White;

        private static System.Windows.Forms.Cursor _cursore = System.Windows.Forms.Cursors.Hand;

        private static System.Drawing.Size _minSize = new System.Drawing.Size(75, 23);

        private bool _active;

        public RedButton() : base()
        {
            base.Font = _normalFont;
            base.BackColor = c_border;
            base.ForeColor = c_text;
            base.FlatAppearance.BorderColor = c_bg;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.MinimumSize = _minSize;
            base.Cursor = _cursore;
        }

        protected override void OnControlAdded(System.Windows.Forms.ControlEventArgs e)
        {
            base.OnControlAdded(e);
            UseVisualStyleBackColor = false;
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!_active)
                base.FlatAppearance.BorderColor = c_border_active;
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!_active)
                base.FlatAppearance.BorderColor = c_border;
        }

        public void SetStateActive()
        {
            _active = true;
            base.FlatAppearance.BorderColor = c_border_active;
        }

        public void SetStateNormal()
        {
            _active = false;
            base.FlatAppearance.BorderColor = c_border;
        }
    }
}
