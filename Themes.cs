using AxonicaFalls.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxonicaFalls
{
    public partial class MainUI : Form
    {
        void implementCommodoreTheme()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            PromptGroup.BackColor = Color.Transparent;
            PromptGroup.ForeColor = Color.FromArgb(108, 94, 181);
            PromptGroup.Location = new Point(279, 290);
            PromptGroup.Name = "PromptGroup";
            PromptGroup.Size = new Size(701, 265);
            PromptGroup.TabIndex = 0;
            PromptGroup.TabStop = false;

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

            helpindicator.AutoSize = true;
            helpindicator.Font = new Font("Ac437 IBM EGA 8x14", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            helpindicator.ForeColor = Color.FromArgb(108, 94, 181);
            helpindicator.Location = new Point(485, 250);
            helpindicator.Name = "helpindicator";
            helpindicator.Size = new Size(217, 13);
            helpindicator.TabIndex = 14;
            helpindicator.Text = "Type \"Help\" for a list of commands.";
            helpindicator.TextAlign = ContentAlignment.TopCenter;

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

            wButton.Anchor = AnchorStyles.Right;
            wButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            wButton.ForeColor = Color.FromArgb(108, 94, 181);
            wButton.Location = new Point(6, 146);
            wButton.Name = "wButton";
            wButton.Size = new Size(76, 18);
            wButton.TabIndex = 12;
            wButton.Text = "W";
            wButton.TextAlign = ContentAlignment.MiddleRight;

            sButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sButton.ForeColor = Color.FromArgb(108, 94, 181);
            sButton.Location = new Point(109, 224);
            sButton.Name = "sButton";
            sButton.Size = new Size(94, 18);
            sButton.TabIndex = 11;
            sButton.Text = "S";
            sButton.TextAlign = ContentAlignment.BottomCenter;

            swButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            swButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swButton.ForeColor = Color.FromArgb(108, 94, 181);
            swButton.Location = new Point(16, 203);
            swButton.Name = "swButton";
            swButton.Size = new Size(92, 18);
            swButton.TabIndex = 10;
            swButton.Text = "SW";
            swButton.TextAlign = ContentAlignment.BottomRight;

            seButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            seButton.ForeColor = Color.FromArgb(108, 94, 181);
            seButton.Location = new Point(203, 203);
            seButton.Name = "seButton";
            seButton.Size = new Size(87, 18);
            seButton.TabIndex = 9;
            seButton.Text = "SE";
            seButton.TextAlign = ContentAlignment.BottomLeft;

            eButton.Anchor = AnchorStyles.Left;
            eButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eButton.ForeColor = Color.FromArgb(108, 94, 181);
            eButton.Location = new Point(227, 146);
            eButton.Name = "eButton";
            eButton.Size = new Size(74, 18);
            eButton.TabIndex = 8;
            eButton.Text = "E";
            eButton.TextAlign = ContentAlignment.MiddleLeft;

            nwButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nwButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nwButton.ForeColor = Color.FromArgb(108, 94, 181);
            nwButton.Location = new Point(16, 88);
            nwButton.Name = "nwButton";
            nwButton.Size = new Size(93, 18);
            nwButton.TabIndex = 7;
            nwButton.Text = "NW";
            nwButton.TextAlign = ContentAlignment.TopRight;

            neButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            neButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            neButton.ForeColor = Color.FromArgb(108, 94, 181);
            neButton.Location = new Point(202, 88);
            neButton.Name = "neButton";
            neButton.Size = new Size(88, 18);
            neButton.TabIndex = 6;
            neButton.Text = "NE";

            nButton.Font = new Font("Ac437 IBM EGA 8x8", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nButton.ForeColor = Color.FromArgb(108, 94, 181);
            nButton.Location = new Point(109, 67);
            nButton.Name = "nButton";
            nButton.Size = new Size(94, 18);
            nButton.TabIndex = 5;
            nButton.Text = "N";
            nButton.TextAlign = ContentAlignment.TopCenter;

            hexcompass1.Image = (Image)resources.GetObject("hexcompass1.Image");
            hexcompass1.Location = new Point(88, 88);
            hexcompass1.Name = "hexcompass1";
            hexcompass1.Size = new Size(133, 133);
            hexcompass1.SizeMode = PictureBoxSizeMode.StretchImage;
            hexcompass1.TabIndex = 4;
            hexcompass1.TabStop = false;

            outputBox.Font = new Font("Ac437 IBM EGA 8x14", 18F, FontStyle.Regular, GraphicsUnit.Point);
            outputBox.ForeColor = Color.FromArgb(108, 94, 181);
            outputBox.Location = new Point(307, 14);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(388, 216);
            outputBox.TabIndex = 3;
            outputBox.TextAlign = ContentAlignment.BottomLeft;

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

            menulabel.Font = new Font("C64 Pro Mono", 20F, FontStyle.Bold, GraphicsUnit.Point);
            menulabel.ForeColor = Color.FromArgb(108, 94, 181);
            menulabel.Location = new Point(1, 14);
            menulabel.Name = "menulabel";
            menulabel.Size = new Size(124, 41);
            menulabel.TabIndex = 1;
            menulabel.Text = "MENU";

            StatGroup.BackColor = Color.Transparent;
            StatGroup.FlatStyle = FlatStyle.Flat;
            StatGroup.ForeColor = Color.FromArgb(108, 94, 181);
            StatGroup.Location = new Point(5, 0);
            StatGroup.Name = "StatGroup";
            StatGroup.Size = new Size(268, 555);
            StatGroup.TabIndex = 2;
            StatGroup.TabStop = false;

            C64DEF.AutoSize = true;
            C64DEF.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            C64DEF.ForeColor = Color.FromArgb(108, 94, 181);
            C64DEF.Location = new Point(120, 101);
            C64DEF.Name = "C64DEF";
            C64DEF.Size = new Size(62, 18);
            C64DEF.TabIndex = 36;
            C64DEF.Text = "DEF";

            C64ATK.AutoSize = true;
            C64ATK.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            C64ATK.ForeColor = Color.FromArgb(108, 94, 181);
            C64ATK.Location = new Point(120, 62);
            C64ATK.Name = "C64ATK";
            C64ATK.Size = new Size(62, 18);
            C64ATK.TabIndex = 35;
            C64ATK.Text = "ATK";

            C64HP.AutoSize = true;
            C64HP.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            C64HP.ForeColor = Color.FromArgb(108, 94, 181);
            C64HP.Location = new Point(11, 62);
            C64HP.Name = "C64HP";
            C64HP.Size = new Size(44, 18);
            C64HP.TabIndex = 33;
            C64HP.Text = "HP";

            inventorylabel.AutoSize = true;
            inventorylabel.Font = new Font("C64 Pro Mono", 13F, FontStyle.Regular, GraphicsUnit.Point);
            inventorylabel.ForeColor = Color.FromArgb(108, 94, 181);
            inventorylabel.Location = new Point(2, 141);
            inventorylabel.Name = "inventorylabel";
            inventorylabel.Size = new Size(170, 18);
            inventorylabel.TabIndex = 32;
            inventorylabel.Text = "INVENTORY";

            menulabel.Font = new Font("C64 Pro Mono", 20F, FontStyle.Bold, GraphicsUnit.Point);
            menulabel.ForeColor = Color.FromArgb(108, 94, 181);
            menulabel.Location = new Point(1, 14);
            menulabel.Name = "menulabel";
            menulabel.Size = new Size(124, 41);
            menulabel.TabIndex = 1;
            menulabel.Text = "MENU";


        }
        void implementModernTheme()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            PromptGroup.BackColor = Color.Transparent;
            PromptGroup.Controls.Add(helpindicator);
            PromptGroup.Controls.Add(enterButton);
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

            helpindicator.AutoSize = true;
            helpindicator.Font = new Font("Ubuntu Mono", 9F, FontStyle.Bold, GraphicsUnit.Point);
            helpindicator.ForeColor = Color.Gainsboro;
            helpindicator.Location = new Point(484, 250);
            helpindicator.Name = "helpindicator";
            helpindicator.Size = new Size(217, 13);
            helpindicator.TabIndex = 14;
            helpindicator.Text = "Type \"Help\" for a list of commands.";
            helpindicator.TextAlign = ContentAlignment.TopCenter;

            enterButton.BackColor = Color.FromArgb(25, 25, 25);
            enterButton.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            enterButton.FlatAppearance.BorderSize = 0;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Neue Haas Grotesk Text Pro", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            enterButton.ForeColor = Color.Gainsboro;
            enterButton.ImageAlign = ContentAlignment.TopCenter;
            enterButton.Location = new Point(615, 225);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(83, 33);
            enterButton.TabIndex = 15;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = false;

            movelabel.AutoSize = true;
            movelabel.BackColor = Color.Gainsboro;
            movelabel.Font = new Font("Neue Haas Grotesk Text Pro Blac", 18F, FontStyle.Bold, GraphicsUnit.Point);
            movelabel.ForeColor = Color.FromArgb(25, 25, 25);
            movelabel.Location = new Point(111, 141);
            movelabel.Name = "movelabel";
            movelabel.Size = new Size(89, 31);
            movelabel.TabIndex = 13;
            movelabel.Text = "MOVE";
            movelabel.TextAlign = ContentAlignment.TopCenter;

            wButton.Anchor = AnchorStyles.Right;
            wButton.Font = new Font("Neue Haas Grotesk Text Pro Medi", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            wButton.ForeColor = Color.Gainsboro;
            wButton.Location = new Point(6, 146);
            wButton.Name = "wButton";
            wButton.Size = new Size(76, 18);
            wButton.TabIndex = 12;
            wButton.Text = "W";
            wButton.TextAlign = ContentAlignment.MiddleRight;

            sButton.Font = new Font("Neue Haas Grotesk Text Pro Medi", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sButton.ForeColor = Color.Gainsboro;
            sButton.Location = new Point(109, 224);
            sButton.Name = "sButton";
            sButton.Size = new Size(94, 18);
            sButton.TabIndex = 11;
            sButton.Text = "S";
            sButton.TextAlign = ContentAlignment.BottomCenter;

            swButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            swButton.Font = new Font("Neue Haas Grotesk Text Pro Medi", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            swButton.ForeColor = Color.Gainsboro;
            swButton.Location = new Point(16, 203);
            swButton.Name = "swButton";
            swButton.Size = new Size(92, 18);
            swButton.TabIndex = 10;
            swButton.Text = "SW";
            swButton.TextAlign = ContentAlignment.BottomRight;
            swButton.Click += swButton_Click;

            seButton.Font = new Font("Neue Haas Grotesk Text Pro Medi", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            seButton.ForeColor = Color.Gainsboro;
            seButton.Location = new Point(203, 203);
            seButton.Name = "seButton";
            seButton.Size = new Size(87, 18);
            seButton.TabIndex = 9;
            seButton.Text = "SE";
            seButton.TextAlign = ContentAlignment.BottomLeft;

            eButton.Anchor = AnchorStyles.Left;
            eButton.Font = new Font("Neue Haas Grotesk Text Pro Medi", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            eButton.ForeColor = Color.Gainsboro;
            eButton.Location = new Point(227, 146);
            eButton.Name = "eButton";
            eButton.Size = new Size(74, 18);
            eButton.TabIndex = 8;
            eButton.Text = "E";
            eButton.TextAlign = ContentAlignment.MiddleLeft;

            nwButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nwButton.Font = new Font("Neue Haas Grotesk Text Pro Medi", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            nwButton.ForeColor = Color.Gainsboro;
            nwButton.Location = new Point(16, 88);
            nwButton.Name = "nwButton";
            nwButton.Size = new Size(93, 18);
            nwButton.TabIndex = 7;
            nwButton.Text = "NW";
            nwButton.TextAlign = ContentAlignment.TopRight;

            neButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            neButton.Font = new Font("Neue Haas Grotesk Text Pro Medi", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            neButton.ForeColor = Color.Gainsboro;
            neButton.Location = new Point(202, 88);
            neButton.Name = "neButton";
            neButton.Size = new Size(88, 18);
            neButton.TabIndex = 6;
            neButton.Text = "NE";

            nButton.Font = new Font("Neue Haas Grotesk Text Pro Medi", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            nButton.ForeColor = Color.Gainsboro;
            nButton.Location = new Point(109, 67);
            nButton.Name = "nButton";
            nButton.Size = new Size(94, 18);
            nButton.TabIndex = 5;
            nButton.Text = "N";
            nButton.TextAlign = ContentAlignment.TopCenter;

            hexcompass1.Image = (Image)resources.GetObject("hexcompass1.Image");
            hexcompass1.Location = new Point(88, 88);
            hexcompass1.Name = "hexcompass1";
            hexcompass1.Size = new Size(133, 133);
            hexcompass1.SizeMode = PictureBoxSizeMode.StretchImage;
            hexcompass1.TabIndex = 4;
            hexcompass1.TabStop = false;

            outputBox.Font = new Font("Ubuntu Mono", 16F, FontStyle.Regular, GraphicsUnit.Point);
            outputBox.ForeColor = Color.Gainsboro;
            outputBox.Location = new Point(307, 14);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(388, 216);
            outputBox.TabIndex = 3;
            outputBox.TextAlign = ContentAlignment.BottomLeft;

            inputBox.BackColor = Color.FromArgb(25, 25, 25);
            inputBox.BorderStyle = BorderStyle.None;
            inputBox.Font = new Font("Ubuntu Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            inputBox.ForeColor = Color.White;
            inputBox.HideSelection = false;
            inputBox.Location = new Point(311, 230);
            inputBox.MaxLength = 34;
            inputBox.Name = "inputBox";
            inputBox.PlaceholderText = "Type a command...";
            inputBox.Size = new Size(298, 21);

            menulabel.Font = new Font("Neue Haas Grotesk Text Pro Blac", 24F, FontStyle.Bold, GraphicsUnit.Point);
            menulabel.ForeColor = Color.Gainsboro;
            menulabel.Location = new Point(1, 11);
            menulabel.Name = "menulabel";
            menulabel.Size = new Size(124, 41);
            menulabel.TabIndex = 1;
            menulabel.Text = "Menu";

            StatGroup.FlatStyle = FlatStyle.Flat;
            StatGroup.ForeColor = Color.FromArgb(108, 94, 181);
            StatGroup.Location = new Point(5, 0);
            StatGroup.Name = "StatGroup";
            StatGroup.Size = new Size(268, 555);
            StatGroup.TabIndex = 2;
            StatGroup.TabStop = false;

            invMenuPopout.BackColor = Color.FromArgb(25, 25, 25);
            invMenuPopout.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            invMenuPopout.FlatAppearance.BorderSize = 0;
            invMenuPopout.FlatStyle = FlatStyle.Flat;
            invMenuPopout.Font = new Font("Neue Haas Grotesk Text Pro Blac", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            invMenuPopout.ForeColor = Color.Gainsboro;
            invMenuPopout.ImageAlign = ContentAlignment.BottomLeft;
            invMenuPopout.Location = new Point(7, 514);
            invMenuPopout.Name = "invMenuPopout";
            invMenuPopout.Size = new Size(67, 35);
            invMenuPopout.TabIndex = 16;
            invMenuPopout.Text = "INV";
            invMenuPopout.UseVisualStyleBackColor = false;
            invMenuPopout.Click += invMenuPopout_Click;

            inventorylabel.AutoSize = true;
            inventorylabel.Font = new Font("Neue Haas Grotesk Text Pro", 18F, FontStyle.Bold, GraphicsUnit.Point);
            inventorylabel.ForeColor = Color.Gainsboro;
            inventorylabel.Location = new Point(7, 132);
            inventorylabel.Name = "inventorylabel";
            inventorylabel.Size = new Size(123, 31);
            inventorylabel.TabIndex = 32;
            inventorylabel.Text = "Inventory";

            playerinv.Font = new Font("Ubuntu Mono", 14F, FontStyle.Regular, GraphicsUnit.Point);
            playerinv.ForeColor = Color.Gainsboro;
            playerinv.Location = new Point(7, 165);
            playerinv.Name = "playerinv";
            playerinv.Size = new Size(255, 346);
            playerinv.TabIndex = 15;

            playerdef.AutoSize = true;
            playerdef.Font = new Font("Ubuntu Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playerdef.ForeColor = Color.Gainsboro;
            playerdef.Location = new Point(185, 97);
            playerdef.Name = "playerdef";
            playerdef.Size = new Size(39, 29);
            playerdef.TabIndex = 31;
            playerdef.TextAlign = ContentAlignment.BottomLeft;

            playeratk.AutoSize = true;
            playeratk.Font = new Font("Ubuntu Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playeratk.ForeColor = Color.Gainsboro;
            playeratk.Location = new Point(185, 58);
            playeratk.Name = "playeratk";
            playeratk.Size = new Size(39, 29);
            playeratk.TabIndex = 30;
            playeratk.TextAlign = ContentAlignment.BottomLeft;

            playermoney.AutoSize = true;
            playermoney.Font = new Font("Ubuntu Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playermoney.ForeColor = Color.Gainsboro;
            playermoney.Location = new Point(62, 97);
            playermoney.Name = "playermoney";
            playermoney.Size = new Size(39, 29);
            playermoney.TabIndex = 29;
            playermoney.TextAlign = ContentAlignment.BottomLeft;

            playerhealth.AutoSize = true;
            playerhealth.Font = new Font("Ubuntu Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playerhealth.ForeColor = Color.Gainsboro;
            playerhealth.Location = new Point(62, 58);
            playerhealth.Name = "playerhealth";
            playerhealth.Size = new Size(39, 29);
            playerhealth.TabIndex = 15;
            playerhealth.TextAlign = ContentAlignment.BottomLeft;

            atkicon.Image = (Image)resources.GetObject("atkicon.Image");
            atkicon.Location = new Point(134, 55);
            atkicon.Name = "atkicon";
            atkicon.Size = new Size(33, 33);
            atkicon.SizeMode = PictureBoxSizeMode.StretchImage;
            atkicon.TabIndex = 28;
            atkicon.TabStop = false;

            deficon.Image = (Image)resources.GetObject("deficon.Image");
            deficon.Location = new Point(134, 94);
            deficon.Name = "deficon";
            deficon.Size = new Size(33, 33);
            deficon.SizeMode = PictureBoxSizeMode.StretchImage;
            deficon.TabIndex = 27;
            deficon.TabStop = false;

            moneyicon.Image = (Image)resources.GetObject("moneyicon.Image");
            moneyicon.Location = new Point(14, 94);
            moneyicon.Name = "moneyicon";
            moneyicon.Size = new Size(33, 33);
            moneyicon.SizeMode = PictureBoxSizeMode.StretchImage;
            moneyicon.TabIndex = 26;
            moneyicon.TabStop = false;

            hearticon.Image = (Image)resources.GetObject("hearticon.Image");
            hearticon.Location = new Point(14, 55);
            hearticon.Name = "hearticon";
            hearticon.Size = new Size(33, 33);
            hearticon.SizeMode = PictureBoxSizeMode.StretchImage;
            hearticon.TabIndex = 25;
            hearticon.TabStop = false;

            playerName.Font = new Font("Neue Haas Grotesk Text Pro Blac", 24F, FontStyle.Bold, GraphicsUnit.Point);
            playerName.ForeColor = Color.Gainsboro;
            playerName.Location = new Point(5, 11);
            playerName.Name = "playerName";
            playerName.Size = new Size(262, 41);
            playerName.TabIndex = 0;
            playerName.Text = "Player";

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

            RoomCanvas.Image = (Image)resources.GetObject("RoomCanvas.Image");
            RoomCanvas.Location = new Point(6, 49);
            RoomCanvas.Name = "RoomCanvas";
            RoomCanvas.Size = new Size(680, 235);
            RoomCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            RoomCanvas.TabIndex = 2;
            RoomCanvas.TabStop = false;

            descLabel.Font = new Font("Ubuntu Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descLabel.ForeColor = Color.Gainsboro;
            descLabel.ImageAlign = ContentAlignment.MiddleRight;
            descLabel.Location = new Point(356, 9);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(330, 41);
            descLabel.TabIndex = 1;
            descLabel.Text = "Room Description";
            descLabel.TextAlign = ContentAlignment.BottomRight;

            RoomNameLabel.Font = new Font("Neue Haas Grotesk Text Pro Blac", 24F, FontStyle.Bold, GraphicsUnit.Point);
            RoomNameLabel.ForeColor = Color.Gainsboro;
            RoomNameLabel.Location = new Point(0, 10);
            RoomNameLabel.Name = "RoomNameLabel";
            RoomNameLabel.Size = new Size(350, 45);
            RoomNameLabel.TabIndex = 0;

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

        }
    }
}
