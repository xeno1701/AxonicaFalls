namespace AxonicaFalls
{
    partial class ItemList
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
            RoomNameLabel = new Label();
            INVLIST = new ListBox();
            invMenuPopout = new Button();
            button1 = new Button();
            button2 = new Button();
            inventorylabel = new Label();
            playerinv = new Label();
            playerhealth = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // RoomNameLabel
            // 
            RoomNameLabel.Font = new Font("Neue Haas Grotesk Text Pro Blac", 24F, FontStyle.Bold, GraphicsUnit.Point);
            RoomNameLabel.ForeColor = Color.Gainsboro;
            RoomNameLabel.Location = new Point(12, 9);
            RoomNameLabel.Name = "RoomNameLabel";
            RoomNameLabel.Size = new Size(416, 45);
            RoomNameLabel.TabIndex = 1;
            RoomNameLabel.Text = "Inventory";
            RoomNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // INVLIST
            // 
            INVLIST.BackColor = Color.FromArgb(25, 25, 25);
            INVLIST.BorderStyle = BorderStyle.None;
            INVLIST.Font = new Font("Ubuntu Mono", 14F, FontStyle.Regular, GraphicsUnit.Point);
            INVLIST.ForeColor = Color.Gainsboro;
            INVLIST.FormattingEnabled = true;
            INVLIST.ItemHeight = 20;
            INVLIST.Location = new Point(12, 57);
            INVLIST.Name = "INVLIST";
            INVLIST.Size = new Size(184, 380);
            INVLIST.TabIndex = 2;
            // 
            // invMenuPopout
            // 
            invMenuPopout.BackColor = Color.FromArgb(25, 25, 25);
            invMenuPopout.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            invMenuPopout.FlatAppearance.BorderSize = 0;
            invMenuPopout.FlatStyle = FlatStyle.Flat;
            invMenuPopout.Font = new Font("Neue Haas Grotesk Text Pro", 17F, FontStyle.Bold, GraphicsUnit.Point);
            invMenuPopout.ForeColor = Color.Gainsboro;
            invMenuPopout.ImageAlign = ContentAlignment.BottomLeft;
            invMenuPopout.Location = new Point(202, 403);
            invMenuPopout.Name = "invMenuPopout";
            invMenuPopout.Size = new Size(81, 35);
            invMenuPopout.TabIndex = 17;
            invMenuPopout.Text = "EXIT";
            invMenuPopout.UseVisualStyleBackColor = false;
            invMenuPopout.Click += invMenuPopout_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 25, 25);
            button1.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Neue Haas Grotesk Text Pro", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(280, 403);
            button1.Name = "button1";
            button1.Size = new Size(69, 35);
            button1.TabIndex = 18;
            button1.Text = "USE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 25, 25);
            button2.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Neue Haas Grotesk Text Pro", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(349, 403);
            button2.Name = "button2";
            button2.Size = new Size(95, 35);
            button2.TabIndex = 19;
            button2.Text = "DROP";
            button2.UseVisualStyleBackColor = false;
            // 
            // inventorylabel
            // 
            inventorylabel.AutoSize = true;
            inventorylabel.Font = new Font("Neue Haas Grotesk Text Pro", 18F, FontStyle.Bold, GraphicsUnit.Point);
            inventorylabel.ForeColor = Color.Gainsboro;
            inventorylabel.Location = new Point(198, 53);
            inventorylabel.Name = "inventorylabel";
            inventorylabel.Size = new Size(130, 31);
            inventorylabel.TabIndex = 33;
            inventorylabel.Text = "Itemname";
            // 
            // playerinv
            // 
            playerinv.Font = new Font("Ubuntu Mono", 14F, FontStyle.Regular, GraphicsUnit.Point);
            playerinv.ForeColor = Color.Gainsboro;
            playerinv.Location = new Point(202, 78);
            playerinv.Name = "playerinv";
            playerinv.Size = new Size(233, 176);
            playerinv.TabIndex = 34;
            playerinv.Text = "null";
            // 
            // playerhealth
            // 
            playerhealth.AutoSize = true;
            playerhealth.Font = new Font("Ubuntu Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playerhealth.ForeColor = Color.Gainsboro;
            playerhealth.Location = new Point(289, 274);
            playerhealth.Name = "playerhealth";
            playerhealth.Size = new Size(39, 29);
            playerhealth.TabIndex = 35;
            playerhealth.Text = "00";
            playerhealth.TextAlign = ContentAlignment.BottomLeft;
            playerhealth.Click += playerhealth_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ubuntu Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(289, 314);
            label3.Name = "label3";
            label3.Size = new Size(39, 29);
            label3.TabIndex = 37;
            label3.Text = "00";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ItemList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(440, 450);
            Controls.Add(label3);
            Controls.Add(playerhealth);
            Controls.Add(playerinv);
            Controls.Add(inventorylabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(invMenuPopout);
            Controls.Add(INVLIST);
            Controls.Add(RoomNameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemList";
            Text = "ItemList";
            Load += ItemList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label RoomNameLabel;
        private ListBox INVLIST;
        private Button invMenuPopout;
        private Button button1;
        private Button button2;
        public Label inventorylabel;
        public Label playerinv;
        public Label playerhealth;
        public Label label3;
    }

}
