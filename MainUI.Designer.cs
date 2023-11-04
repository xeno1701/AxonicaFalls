namespace AxonicaFalls
{
    partial class MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            PromptGroup = new GroupBox();
            enterButton = new Button();
            helpindicator = new Label();
            movelabel = new Label();
            wButton = new Label();
            sButton = new Label();
            swButton = new Label();
            seButton = new Label();
            eButton = new Label();
            nwButton = new Label();
            neButton = new Label();
            nButton = new Label();
            hexcompass1 = new PictureBox();
            outputBox = new Label();
            inputBox = new TextBox();
            menulabel = new Label();
            StatGroup = new GroupBox();
            inventorylabel = new Label();
            playerinv = new Label();
            playerdef = new Label();
            playeratk = new Label();
            playermoney = new Label();
            playerhealth = new Label();
            atkicon = new PictureBox();
            deficon = new PictureBox();
            moneyicon = new PictureBox();
            hearticon = new PictureBox();
            playerName = new Label();
            GameGroup = new GroupBox();
            RoomCanvas = new PictureBox();
            descLabel = new Label();
            RoomNameLabel = new Label();
            invMenuPopout = new Button();
            PromptGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hexcompass1).BeginInit();
            StatGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)atkicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deficon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moneyicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hearticon).BeginInit();
            GameGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomCanvas).BeginInit();
            SuspendLayout();
            // 
            // PromptGroup
            // 
            PromptGroup.BackColor = Color.Transparent;
            PromptGroup.Controls.Add(enterButton);
            PromptGroup.Controls.Add(helpindicator);
            PromptGroup.Controls.Add(movelabel);
            PromptGroup.Controls.Add(wButton);
            PromptGroup.Controls.Add(sButton);
            PromptGroup.Controls.Add(swButton);
            PromptGroup.Controls.Add(seButton);
            PromptGroup.Controls.Add(eButton);
            PromptGroup.Controls.Add(nwButton);
            PromptGroup.Controls.Add(neButton);
            PromptGroup.Controls.Add(nButton);
            PromptGroup.Controls.Add(hexcompass1);
            PromptGroup.Controls.Add(outputBox);
            PromptGroup.Controls.Add(inputBox);
            PromptGroup.Controls.Add(menulabel);
            PromptGroup.ForeColor = Color.Gainsboro;
            PromptGroup.Location = new Point(279, 290);
            PromptGroup.Name = "PromptGroup";
            PromptGroup.Size = new Size(701, 265);
            PromptGroup.TabIndex = 0;
            PromptGroup.TabStop = false;
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.FromArgb(25, 25, 25);
            enterButton.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            enterButton.FlatAppearance.BorderSize = 0;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Neue Haas Grotesk Text Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enterButton.ImageAlign = ContentAlignment.TopCenter;
            enterButton.Location = new Point(605, 224);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(90, 28);
            enterButton.TabIndex = 15;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // helpindicator
            // 
            helpindicator.AutoSize = true;
            helpindicator.Font = new Font("Neue Haas Grotesk Text Pro Thin", 7F, FontStyle.Regular, GraphicsUnit.Point);
            helpindicator.Location = new Point(510, 250);
            helpindicator.Name = "helpindicator";
            helpindicator.Size = new Size(193, 13);
            helpindicator.TabIndex = 14;
            helpindicator.Text = "Type \"Help\" for a list of commands.";
            helpindicator.TextAlign = ContentAlignment.TopCenter;
            // 
            // movelabel
            // 
            movelabel.AutoSize = true;
            movelabel.BackColor = Color.Gainsboro;
            movelabel.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            movelabel.ForeColor = Color.FromArgb(25, 25, 25);
            movelabel.Location = new Point(131, 147);
            movelabel.Name = "movelabel";
            movelabel.Size = new Size(46, 18);
            movelabel.TabIndex = 13;
            movelabel.Text = "Move";
            movelabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // wButton
            // 
            wButton.Anchor = AnchorStyles.Right;
            wButton.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            wButton.Location = new Point(6, 146);
            wButton.Name = "wButton";
            wButton.Size = new Size(76, 18);
            wButton.TabIndex = 12;
            wButton.Text = "W";
            wButton.TextAlign = ContentAlignment.MiddleRight;
            wButton.Click += wButton_Click;
            // 
            // sButton
            // 
            sButton.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sButton.Location = new Point(109, 224);
            sButton.Name = "sButton";
            sButton.Size = new Size(94, 18);
            sButton.TabIndex = 11;
            sButton.Text = "S";
            sButton.TextAlign = ContentAlignment.BottomCenter;
            sButton.Click += sButton_Click;
            // 
            // swButton
            // 
            swButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            swButton.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            swButton.Location = new Point(16, 203);
            swButton.Name = "swButton";
            swButton.Size = new Size(92, 18);
            swButton.TabIndex = 10;
            swButton.Text = "SW";
            swButton.TextAlign = ContentAlignment.BottomRight;
            swButton.Click += swButton_Click;
            // 
            // seButton
            // 
            seButton.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            seButton.Location = new Point(203, 203);
            seButton.Name = "seButton";
            seButton.Size = new Size(87, 18);
            seButton.TabIndex = 9;
            seButton.Text = "SE";
            seButton.TextAlign = ContentAlignment.BottomLeft;
            seButton.Click += seButton_Click;
            // 
            // eButton
            // 
            eButton.Anchor = AnchorStyles.Left;
            eButton.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            eButton.Location = new Point(227, 146);
            eButton.Name = "eButton";
            eButton.Size = new Size(74, 18);
            eButton.TabIndex = 8;
            eButton.Text = "E";
            eButton.TextAlign = ContentAlignment.MiddleLeft;
            eButton.Click += eButton_Click;
            // 
            // nwButton
            // 
            nwButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nwButton.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nwButton.Location = new Point(16, 88);
            nwButton.Name = "nwButton";
            nwButton.Size = new Size(93, 18);
            nwButton.TabIndex = 7;
            nwButton.Text = "NW";
            nwButton.TextAlign = ContentAlignment.TopRight;
            nwButton.Click += nwButton_Click;
            // 
            // neButton
            // 
            neButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            neButton.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            neButton.Location = new Point(202, 88);
            neButton.Name = "neButton";
            neButton.Size = new Size(88, 18);
            neButton.TabIndex = 6;
            neButton.Text = "NE";
            neButton.Click += neButton_Click;
            // 
            // nButton
            // 
            nButton.Font = new Font("Neue Haas Grotesk Text Pro Thin", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nButton.Location = new Point(109, 67);
            nButton.Name = "nButton";
            nButton.Size = new Size(94, 18);
            nButton.TabIndex = 5;
            nButton.Text = "N";
            nButton.TextAlign = ContentAlignment.TopCenter;
            nButton.Click += nButton_Click;
            // 
            // hexcompass1
            // 
            hexcompass1.Image = (Image)resources.GetObject("hexcompass1.Image");
            hexcompass1.Location = new Point(88, 88);
            hexcompass1.Name = "hexcompass1";
            hexcompass1.Size = new Size(133, 133);
            hexcompass1.SizeMode = PictureBoxSizeMode.StretchImage;
            hexcompass1.TabIndex = 4;
            hexcompass1.TabStop = false;
            // 
            // outputBox
            // 
            outputBox.Font = new Font("Neue Haas Grotesk Text Pro Medi", 15F, FontStyle.Bold, GraphicsUnit.Point);
            outputBox.Location = new Point(307, 14);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(388, 216);
            outputBox.TabIndex = 3;
            outputBox.Text = "label1";
            outputBox.TextAlign = ContentAlignment.BottomLeft;
            // 
            // inputBox
            // 
            inputBox.BackColor = Color.FromArgb(25, 25, 25);
            inputBox.BorderStyle = BorderStyle.None;
            inputBox.Font = new Font("Neue Haas Grotesk Text Pro Medi", 15F, FontStyle.Bold, GraphicsUnit.Point);
            inputBox.ForeColor = Color.Gainsboro;
            inputBox.HideSelection = false;
            inputBox.Location = new Point(311, 226);
            inputBox.MaxLength = 34;
            inputBox.Name = "inputBox";
            inputBox.PlaceholderText = "Type a command...";
            inputBox.Size = new Size(288, 26);
            inputBox.TabIndex = 2;
            // 
            // menulabel
            // 
            menulabel.Font = new Font("Neue Haas Grotesk Text Pro Blac", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            menulabel.Location = new Point(1, 10);
            menulabel.Name = "menulabel";
            menulabel.Size = new Size(124, 41);
            menulabel.TabIndex = 1;
            menulabel.Text = "Menu";
            // 
            // StatGroup
            // 
            StatGroup.BackColor = Color.Transparent;
            StatGroup.Controls.Add(invMenuPopout);
            StatGroup.Controls.Add(inventorylabel);
            StatGroup.Controls.Add(playerinv);
            StatGroup.Controls.Add(playerdef);
            StatGroup.Controls.Add(playeratk);
            StatGroup.Controls.Add(playermoney);
            StatGroup.Controls.Add(playerhealth);
            StatGroup.Controls.Add(atkicon);
            StatGroup.Controls.Add(deficon);
            StatGroup.Controls.Add(moneyicon);
            StatGroup.Controls.Add(hearticon);
            StatGroup.Controls.Add(playerName);
            StatGroup.ForeColor = Color.Gainsboro;
            StatGroup.Location = new Point(5, 0);
            StatGroup.Name = "StatGroup";
            StatGroup.Size = new Size(268, 555);
            StatGroup.TabIndex = 2;
            StatGroup.TabStop = false;
            // 
            // inventorylabel
            // 
            inventorylabel.AutoSize = true;
            inventorylabel.Font = new Font("Neue Haas Grotesk Text Pro", 16F, FontStyle.Bold, GraphicsUnit.Point);
            inventorylabel.Location = new Point(7, 134);
            inventorylabel.Name = "inventorylabel";
            inventorylabel.Size = new Size(114, 28);
            inventorylabel.TabIndex = 32;
            inventorylabel.Text = "Inventory";
            // 
            // playerinv
            // 
            playerinv.Font = new Font("Neue Haas Grotesk Text Pro Thin", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            playerinv.Location = new Point(7, 165);
            playerinv.Name = "playerinv";
            playerinv.Size = new Size(255, 378);
            playerinv.TabIndex = 15;
            playerinv.Text = "null";
            // 
            // playerdef
            // 
            playerdef.AutoSize = true;
            playerdef.Font = new Font("Neue Haas Grotesk Text Pro", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerdef.Location = new Point(136, 103);
            playerdef.Name = "playerdef";
            playerdef.Size = new Size(44, 25);
            playerdef.TabIndex = 31;
            playerdef.Text = "null";
            playerdef.TextAlign = ContentAlignment.BottomLeft;
            // 
            // playeratk
            // 
            playeratk.AutoSize = true;
            playeratk.Font = new Font("Neue Haas Grotesk Text Pro", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playeratk.Location = new Point(136, 64);
            playeratk.Name = "playeratk";
            playeratk.Size = new Size(44, 25);
            playeratk.TabIndex = 30;
            playeratk.Text = "null";
            playeratk.TextAlign = ContentAlignment.BottomLeft;
            // 
            // playermoney
            // 
            playermoney.AutoSize = true;
            playermoney.Font = new Font("Neue Haas Grotesk Text Pro", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playermoney.Location = new Point(46, 103);
            playermoney.Name = "playermoney";
            playermoney.Size = new Size(44, 25);
            playermoney.TabIndex = 29;
            playermoney.Text = "null";
            playermoney.TextAlign = ContentAlignment.BottomLeft;
            // 
            // playerhealth
            // 
            playerhealth.AutoSize = true;
            playerhealth.Font = new Font("Neue Haas Grotesk Text Pro", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerhealth.Location = new Point(46, 64);
            playerhealth.Name = "playerhealth";
            playerhealth.Size = new Size(44, 25);
            playerhealth.TabIndex = 15;
            playerhealth.Text = "null";
            playerhealth.TextAlign = ContentAlignment.BottomLeft;
            // 
            // atkicon
            // 
            atkicon.Image = (Image)resources.GetObject("atkicon.Image");
            atkicon.Location = new Point(97, 59);
            atkicon.Name = "atkicon";
            atkicon.Size = new Size(33, 33);
            atkicon.SizeMode = PictureBoxSizeMode.StretchImage;
            atkicon.TabIndex = 28;
            atkicon.TabStop = false;
            // 
            // deficon
            // 
            deficon.Image = (Image)resources.GetObject("deficon.Image");
            deficon.Location = new Point(97, 98);
            deficon.Name = "deficon";
            deficon.Size = new Size(33, 33);
            deficon.SizeMode = PictureBoxSizeMode.StretchImage;
            deficon.TabIndex = 27;
            deficon.TabStop = false;
            // 
            // moneyicon
            // 
            moneyicon.Image = (Image)resources.GetObject("moneyicon.Image");
            moneyicon.Location = new Point(7, 98);
            moneyicon.Name = "moneyicon";
            moneyicon.Size = new Size(33, 33);
            moneyicon.SizeMode = PictureBoxSizeMode.StretchImage;
            moneyicon.TabIndex = 26;
            moneyicon.TabStop = false;
            // 
            // hearticon
            // 
            hearticon.Image = (Image)resources.GetObject("hearticon.Image");
            hearticon.Location = new Point(7, 59);
            hearticon.Name = "hearticon";
            hearticon.Size = new Size(33, 33);
            hearticon.SizeMode = PictureBoxSizeMode.StretchImage;
            hearticon.TabIndex = 25;
            hearticon.TabStop = false;
            // 
            // playerName
            // 
            playerName.Font = new Font("Neue Haas Grotesk Text Pro Blac", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            playerName.Location = new Point(0, 10);
            playerName.Name = "playerName";
            playerName.Size = new Size(262, 41);
            playerName.TabIndex = 0;
            playerName.Text = "Player";
            // 
            // GameGroup
            // 
            GameGroup.BackColor = Color.Transparent;
            GameGroup.Controls.Add(RoomCanvas);
            GameGroup.Controls.Add(descLabel);
            GameGroup.Controls.Add(RoomNameLabel);
            GameGroup.ForeColor = Color.Gainsboro;
            GameGroup.Location = new Point(279, 0);
            GameGroup.Name = "GameGroup";
            GameGroup.Size = new Size(700, 292);
            GameGroup.TabIndex = 1;
            GameGroup.TabStop = false;
            // 
            // RoomCanvas
            // 
            RoomCanvas.Image = (Image)resources.GetObject("RoomCanvas.Image");
            RoomCanvas.Location = new Point(6, 49);
            RoomCanvas.Name = "RoomCanvas";
            RoomCanvas.Size = new Size(680, 235);
            RoomCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            RoomCanvas.TabIndex = 2;
            RoomCanvas.TabStop = false;
            // 
            // descLabel
            // 
            descLabel.Font = new Font("Neue Haas Grotesk Text Pro Thin", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            descLabel.ImageAlign = ContentAlignment.MiddleRight;
            descLabel.Location = new Point(356, 10);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(330, 41);
            descLabel.TabIndex = 1;
            descLabel.Text = "Room Description";
            descLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // RoomNameLabel
            // 
            RoomNameLabel.Font = new Font("Neue Haas Grotesk Text Pro Blac", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            RoomNameLabel.Location = new Point(0, 10);
            RoomNameLabel.Name = "RoomNameLabel";
            RoomNameLabel.Size = new Size(350, 45);
            RoomNameLabel.TabIndex = 0;
            RoomNameLabel.Text = "Currentroom";
            // 
            // invMenuPopout
            // 
            invMenuPopout.BackColor = Color.FromArgb(25, 25, 25);
            invMenuPopout.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            invMenuPopout.FlatAppearance.BorderSize = 0;
            invMenuPopout.FlatStyle = FlatStyle.Flat;
            invMenuPopout.Font = new Font("Neue Haas Grotesk Text Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            invMenuPopout.ImageAlign = ContentAlignment.TopCenter;
            invMenuPopout.Location = new Point(7, 521);
            invMenuPopout.Name = "invMenuPopout";
            invMenuPopout.Size = new Size(255, 28);
            invMenuPopout.TabIndex = 16;
            invMenuPopout.Text = "Inventory Menu";
            invMenuPopout.UseVisualStyleBackColor = false;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(984, 561);
            Controls.Add(GameGroup);
            Controls.Add(StatGroup);
            Controls.Add(PromptGroup);
            ForeColor = Color.Gainsboro;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "MainUI";
            Text = "Axonica Falls";
            Load += Form1_Load;
            PromptGroup.ResumeLayout(false);
            PromptGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hexcompass1).EndInit();
            StatGroup.ResumeLayout(false);
            StatGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)atkicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)deficon).EndInit();
            ((System.ComponentModel.ISupportInitialize)moneyicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)hearticon).EndInit();
            GameGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RoomCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox PromptGroup;
        public GroupBox StatGroup;
        public GroupBox GameGroup;
        public Label RoomNameLabel;
        public Label descLabel;
        public PictureBox RoomCanvas;
        public Label playerName;
        public Label menulabel;
        public TextBox inputBox;
        public Label outputBox;
        public PictureBox hexcompass1;
        public Label wButton;
        public Label sButton;
        public Label swButton;
        public Label seButton;
        public Label eButton;
        public Label nwButton;
        public Label neButton;
        public Label nButton;
        public Label movelabel;
        public Label helpindicator;
        public PictureBox atkicon;
        public PictureBox deficon;
        public PictureBox moneyicon;
        public PictureBox hearticon;
        public Label playerhealth;
        public Label playermoney;
        public Label inventorylabel;
        public Label playerinv;
        public Label playerdef;
        public Label playeratk;
        private Button enterButton;
        private Button invMenuPopout;
    }
}