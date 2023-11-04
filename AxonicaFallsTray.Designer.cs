namespace AxonicaFalls
{
    partial class AxonicaFallsTray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxonicaFallsTray));
            SuspendLayout();
            // 
            // AxonicaFallsTray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(136, 39);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(136, 39);
            MinimumSize = new Size(136, 39);
            Name = "AxonicaFallsTray";
            ShowInTaskbar = false;
            Text = "AxonicaFallsTray";
            WindowState = FormWindowState.Minimized;
            Load += AxonicaFallsTray_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}