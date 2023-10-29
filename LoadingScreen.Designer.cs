namespace AxonicaFalls
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            loadscreenicon = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)loadscreenicon).BeginInit();
            SuspendLayout();
            // 
            // loadscreenicon
            // 
            loadscreenicon.Image = (Image)resources.GetObject("loadscreenicon.Image");
            loadscreenicon.Location = new Point(50, 41);
            loadscreenicon.Name = "loadscreenicon";
            loadscreenicon.Size = new Size(200, 200);
            loadscreenicon.SizeMode = PictureBoxSizeMode.StretchImage;
            loadscreenicon.TabIndex = 0;
            loadscreenicon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Neue Haas Grotesk Text Pro Blac", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 266);
            label1.Name = "label1";
            label1.Size = new Size(253, 45);
            label1.TabIndex = 1;
            label1.Text = "Axonica Falls";
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(300, 350);
            Controls.Add(label1);
            Controls.Add(loadscreenicon);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Axonica Falls";
            Load += LoadingScreen_Load;
            ((System.ComponentModel.ISupportInitialize)loadscreenicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox loadscreenicon;
        private Label label1;
    }
}