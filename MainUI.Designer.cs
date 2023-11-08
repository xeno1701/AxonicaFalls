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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            invMenuPopout = new Button();
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
            PromptGroup.ForeColor = Color.FromArgb(108, 94, 181);
            PromptGroup.Location = new Point(279, 290);
            PromptGroup.Name = "PromptGroup";
            PromptGroup.Size = new Size(701, 265);
            PromptGroup.TabIndex = 0;
            PromptGroup.TabStop = false;
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.FromArgb(53, 40, 121);
            enterButton.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            enterButton.FlatAppearance.BorderSize = 0;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Ac437 IBM EGA 8x14", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            enterButton.ForeColor = Color.FromArgb(108, 94, 181);
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
            helpindicator.Font = new Font("Ac437 IBM EGA 8x14", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            helpindicator.ForeColor = Color.FromArgb(108, 94, 181);
            helpindicator.Location = new Point(485, 250);
            helpindicator.Name = "helpindicator";
            helpindicator.Size = new Size(217, 13);
            helpindicator.TabIndex = 14;
            helpindicator.Text = "Type \"Help\" for a list of commands.";
            helpindicator.TextAlign = ContentAlignment.TopCenter;
            // 
            // movelabel
            // 
            movelabel.AutoSize = true;
            movelabel.BackColor = Color.FromArgb(108, 94, 181);
            movelabel.Font = new Font("Ac437 IBM EGA 8x8", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            movelabel.ForeColor = Color.FromArgb(53, 40, 121);
            movelabel.Location = new Point(120, 147);
            movelabel.Name = "movelabel";
            movelabel.Size = new Size(69, 19);
            movelabel.TabIndex = 13;
            movelabel.Text = "MOVE";
            movelabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // wButton
            // 
            wButton.Anchor = AnchorStyles.Right;
            wButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            wButton.ForeColor = Color.FromArgb(108, 94, 181);
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
            sButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sButton.ForeColor = Color.FromArgb(108, 94, 181);
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
            swButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swButton.ForeColor = Color.FromArgb(108, 94, 181);
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
            seButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            seButton.ForeColor = Color.FromArgb(108, 94, 181);
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
            eButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eButton.ForeColor = Color.FromArgb(108, 94, 181);
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
            nwButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nwButton.ForeColor = Color.FromArgb(108, 94, 181);
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
            neButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            neButton.ForeColor = Color.FromArgb(108, 94, 181);
            neButton.Location = new Point(202, 88);
            neButton.Name = "neButton";
            neButton.Size = new Size(88, 18);
            neButton.TabIndex = 6;
            neButton.Text = "NE";
            neButton.Click += neButton_Click;
            // 
            // nButton
            // 
            nButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nButton.ForeColor = Color.FromArgb(108, 94, 181);
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
            outputBox.Font = new Font("Ac437 IBM EGA 8x14", 18F, FontStyle.Regular, GraphicsUnit.Point);
            outputBox.ForeColor = Color.FromArgb(108, 94, 181);
            outputBox.Location = new Point(307, 14);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(388, 216);
            outputBox.TabIndex = 3;
            outputBox.Text = "label1";
            outputBox.TextAlign = ContentAlignment.BottomLeft;
            // 
            // inputBox
            // 
            inputBox.BackColor = Color.FromArgb(53, 40, 121);
            inputBox.BorderStyle = BorderStyle.None;
            inputBox.Font = new Font("Ac437 IBM EGA 8x8", 15F, FontStyle.Regular, GraphicsUnit.Point);
            inputBox.ForeColor = Color.FromArgb(108, 94, 181);
            inputBox.HideSelection = false;
            inputBox.Location = new Point(311, 230);
            inputBox.MaxLength = 34;
            inputBox.Name = "inputBox";
            inputBox.PlaceholderText = "Type a command...";
            inputBox.Size = new Size(288, 20);
            inputBox.TabIndex = 2;
            // 
            // menulabel
            // 
            menulabel.Font = new Font("C64 Pro Mono", 20F, FontStyle.Bold, GraphicsUnit.Point);
            menulabel.ForeColor = Color.FromArgb(108, 94, 181);
            menulabel.Location = new Point(1, 14);
            menulabel.Name = "menulabel";
            menulabel.Size = new Size(124, 41);
            menulabel.TabIndex = 1;
            menulabel.Text = "MENU";
            // 
            // StatGroup
            // 
            StatGroup.BackColor = Color.Transparent;
            StatGroup.Controls.Add(label4);
            StatGroup.Controls.Add(label3);
            StatGroup.Controls.Add(label2);
            StatGroup.Controls.Add(label1);
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
            StatGroup.ForeColor = Color.FromArgb(108, 94, 181);
            StatGroup.Location = new Point(5, 0);
            StatGroup.Name = "StatGroup";
            StatGroup.Size = new Size(268, 555);
            StatGroup.TabIndex = 2;
            StatGroup.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(108, 94, 181);
            label4.Location = new Point(120, 101);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 36;
            label4.Text = "DEF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(108, 94, 181);
            label3.Location = new Point(120, 62);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 35;
            label3.Text = "ATK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(108, 94, 181);
            label2.Location = new Point(11, 101);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 34;
            label2.Text = "$$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(108, 94, 181);
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 33;
            label1.Text = "HP";
            // 
            // invMenuPopout
            // 
            invMenuPopout.BackColor = Color.FromArgb(53, 40, 121);
            invMenuPopout.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            invMenuPopout.FlatAppearance.BorderSize = 0;
            invMenuPopout.FlatStyle = FlatStyle.Flat;
            invMenuPopout.Font = new Font("C64 Pro", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            invMenuPopout.ForeColor = Color.FromArgb(108, 94, 181);
            invMenuPopout.ImageAlign = ContentAlignment.BottomLeft;
            invMenuPopout.Location = new Point(7, 514);
            invMenuPopout.Name = "invMenuPopout";
            invMenuPopout.Size = new Size(67, 35);
            invMenuPopout.TabIndex = 16;
            invMenuPopout.Text = "INV";
            invMenuPopout.UseVisualStyleBackColor = false;
            // 
            // inventorylabel
            // 
            inventorylabel.AutoSize = true;
            inventorylabel.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            inventorylabel.ForeColor = Color.FromArgb(108, 94, 181);
            inventorylabel.Location = new Point(2, 141);
            inventorylabel.Name = "inventorylabel";
            inventorylabel.Size = new Size(170, 18);
            inventorylabel.TabIndex = 32;
            inventorylabel.Text = "INVENTORY";
            // 
            // playerinv
            // 
            playerinv.Font = new Font("Ac437 IBM EGA 8x14", 18F, FontStyle.Regular, GraphicsUnit.Point);
            playerinv.ForeColor = Color.FromArgb(108, 94, 181);
            playerinv.Location = new Point(7, 165);
            playerinv.Name = "playerinv";
            playerinv.Size = new Size(255, 346);
            playerinv.TabIndex = 15;
            playerinv.Text = "null";
            // 
            // playerdef
            // 
            playerdef.AutoSize = true;
            playerdef.Font = new Font("C64 Pro Mono", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerdef.ForeColor = Color.FromArgb(108, 94, 181);
            playerdef.Location = new Point(179, 100);
            playerdef.Name = "playerdef";
            playerdef.Size = new Size(49, 20);
            playerdef.TabIndex = 31;
            playerdef.Text = "00";
            playerdef.TextAlign = ContentAlignment.BottomLeft;
            // 
            // playeratk
            // 
            playeratk.AutoSize = true;
            playeratk.Font = new Font("C64 Pro Mono", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playeratk.ForeColor = Color.FromArgb(108, 94, 181);
            playeratk.Location = new Point(179, 61);
            playeratk.Name = "playeratk";
            playeratk.Size = new Size(49, 20);
            playeratk.TabIndex = 30;
            playeratk.Text = "00";
            playeratk.TextAlign = ContentAlignment.BottomLeft;
            // 
            // playermoney
            // 
            playermoney.AutoSize = true;
            playermoney.Font = new Font("C64 Pro Mono", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playermoney.ForeColor = Color.FromArgb(108, 94, 181);
            playermoney.Location = new Point(56, 100);
            playermoney.Name = "playermoney";
            playermoney.Size = new Size(49, 20);
            playermoney.TabIndex = 29;
            playermoney.Text = "00";
            playermoney.TextAlign = ContentAlignment.BottomLeft;
            // 
            // playerhealth
            // 
            playerhealth.AutoSize = true;
            playerhealth.Font = new Font("C64 Pro Mono", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerhealth.ForeColor = Color.FromArgb(108, 94, 181);
            playerhealth.Location = new Point(56, 61);
            playerhealth.Name = "playerhealth";
            playerhealth.Size = new Size(49, 20);
            playerhealth.TabIndex = 15;
            playerhealth.Text = "00";
            playerhealth.TextAlign = ContentAlignment.BottomLeft;
            // 
            // atkicon
            // 
            atkicon.Image = (Image)resources.GetObject("atkicon.Image");
            atkicon.Location = new Point(137, 55);
            atkicon.Name = "atkicon";
            atkicon.Size = new Size(33, 33);
            atkicon.SizeMode = PictureBoxSizeMode.StretchImage;
            atkicon.TabIndex = 28;
            atkicon.TabStop = false;
            atkicon.Visible = false;
            // 
            // deficon
            // 
            deficon.Image = (Image)resources.GetObject("deficon.Image");
            deficon.Location = new Point(137, 94);
            deficon.Name = "deficon";
            deficon.Size = new Size(33, 33);
            deficon.SizeMode = PictureBoxSizeMode.StretchImage;
            deficon.TabIndex = 27;
            deficon.TabStop = false;
            deficon.Visible = false;
            // 
            // moneyicon
            // 
            moneyicon.Image = (Image)resources.GetObject("moneyicon.Image");
            moneyicon.Location = new Point(17, 94);
            moneyicon.Name = "moneyicon";
            moneyicon.Size = new Size(33, 33);
            moneyicon.SizeMode = PictureBoxSizeMode.StretchImage;
            moneyicon.TabIndex = 26;
            moneyicon.TabStop = false;
            moneyicon.Visible = false;
            // 
            // hearticon
            // 
            hearticon.Image = (Image)resources.GetObject("hearticon.Image");
            hearticon.Location = new Point(17, 55);
            hearticon.Name = "hearticon";
            hearticon.Size = new Size(33, 33);
            hearticon.SizeMode = PictureBoxSizeMode.StretchImage;
            hearticon.TabIndex = 25;
            hearticon.TabStop = false;
            hearticon.Visible = false;
            // 
            // playerName
            // 
            playerName.Font = new Font("C64 Pro Mono", 20F, FontStyle.Bold, GraphicsUnit.Point);
            playerName.ForeColor = Color.FromArgb(108, 94, 181);
            playerName.Location = new Point(0, 14);
            playerName.Name = "playerName";
            playerName.Size = new Size(262, 41);
            playerName.TabIndex = 0;
            playerName.Text = "PLAYER";
            // 
            // GameGroup
            // 
            GameGroup.BackColor = Color.Transparent;
            GameGroup.Controls.Add(RoomCanvas);
            GameGroup.Controls.Add(descLabel);
            GameGroup.Controls.Add(RoomNameLabel);
            GameGroup.ForeColor = Color.FromArgb(108, 94, 181);
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
            descLabel.Font = new Font("Ac437 IBM EGA 8x14", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            descLabel.ForeColor = Color.FromArgb(108, 94, 181);
            descLabel.ImageAlign = ContentAlignment.MiddleRight;
            descLabel.Location = new Point(356, 9);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(330, 41);
            descLabel.TabIndex = 1;
            descLabel.Text = "Room Description";
            descLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // RoomNameLabel
            // 
            RoomNameLabel.Font = new Font("C64 Pro Mono", 20F, FontStyle.Bold, GraphicsUnit.Point);
            RoomNameLabel.ForeColor = Color.FromArgb(108, 94, 181);
            RoomNameLabel.Location = new Point(0, 14);
            RoomNameLabel.Name = "RoomNameLabel";
            RoomNameLabel.Size = new Size(350, 45);
            RoomNameLabel.TabIndex = 0;
            RoomNameLabel.Text = "CURRENTROOM";
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 40, 121);
            ClientSize = new Size(984, 561);
            Controls.Add(GameGroup);
            Controls.Add(StatGroup);
            Controls.Add(PromptGroup);
            ForeColor = Color.FromArgb(108, 94, 181);
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
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label1;
    }
}