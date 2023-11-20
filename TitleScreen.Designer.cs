namespace AxonicaFalls
{
    partial class TitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            loadscreenicon = new PictureBox();
            label1 = new Label();
            button1 = new Button();
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
            label1.Location = new Point(24, 244);
            label1.Name = "label1";
            label1.Size = new Size(253, 45);
            label1.TabIndex = 1;
            label1.Text = "Axonica Falls";
            // 
            // button1
            // 
            button1.Location = new Point(138, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(300, 350);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(loadscreenicon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TitleScreen";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Axonica Falls";
            Load += TitleScreen_Load;
            ((System.ComponentModel.ISupportInitialize)loadscreenicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox loadscreenicon;
        private Label label1;
        private Button button1;
    }
}