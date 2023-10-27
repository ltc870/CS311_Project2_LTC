namespace CS311_Project2_LTC
{
    partial class formCraps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCraps));
            lblDice2 = new Label();
            lblDice1 = new Label();
            lblBankBalance = new Label();
            lblBank = new Label();
            textBoxBetAmount = new TextBox();
            btnRoll = new Button();
            lblAnnouncement = new Label();
            btnGameRules = new Button();
            picBoxDice1 = new PictureBox();
            picBoxDice2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxDice1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDice2).BeginInit();
            SuspendLayout();
            // 
            // lblDice2
            // 
            lblDice2.AutoSize = true;
            lblDice2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDice2.Location = new Point(425, 150);
            lblDice2.Name = "lblDice2";
            lblDice2.Size = new Size(71, 30);
            lblDice2.TabIndex = 1;
            lblDice2.Text = "Dice2";
            // 
            // lblDice1
            // 
            lblDice1.AutoSize = true;
            lblDice1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDice1.Location = new Point(264, 150);
            lblDice1.Name = "lblDice1";
            lblDice1.Size = new Size(71, 30);
            lblDice1.TabIndex = 2;
            lblDice1.Text = "Dice1";
            // 
            // lblBankBalance
            // 
            lblBankBalance.AutoSize = true;
            lblBankBalance.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankBalance.Location = new Point(448, 66);
            lblBankBalance.Name = "lblBankBalance";
            lblBankBalance.Size = new Size(156, 30);
            lblBankBalance.TabIndex = 3;
            lblBankBalance.Text = "Bank Balance:";
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblBank.Location = new Point(614, 66);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(26, 30);
            lblBank.TabIndex = 4;
            lblBank.Text = "0";
            // 
            // textBoxBetAmount
            // 
            textBoxBetAmount.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxBetAmount.Location = new Point(91, 66);
            textBoxBetAmount.Name = "textBoxBetAmount";
            textBoxBetAmount.PlaceholderText = "Enter Your Bet!";
            textBoxBetAmount.Size = new Size(171, 37);
            textBoxBetAmount.TabIndex = 5;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoll.Location = new Point(35, 341);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(112, 76);
            btnRoll.TabIndex = 6;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblAnnouncement
            // 
            lblAnnouncement.AutoSize = true;
            lblAnnouncement.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnouncement.Location = new Point(275, 366);
            lblAnnouncement.Name = "lblAnnouncement";
            lblAnnouncement.Size = new Size(124, 30);
            lblAnnouncement.TabIndex = 7;
            lblAnnouncement.Text = "Let's Play!!";
            // 
            // btnGameRules
            // 
            btnGameRules.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnGameRules.Location = new Point(571, 362);
            btnGameRules.Name = "btnGameRules";
            btnGameRules.Size = new Size(149, 34);
            btnGameRules.TabIndex = 8;
            btnGameRules.Text = "Game Rules";
            btnGameRules.UseVisualStyleBackColor = true;
            btnGameRules.Click += btnGameRules_Click;
            // 
            // picBoxDice1
            // 
            picBoxDice1.Image = (Image)resources.GetObject("picBoxDice1.Image");
            picBoxDice1.Location = new Point(223, 183);
            picBoxDice1.Name = "picBoxDice1";
            picBoxDice1.Size = new Size(112, 104);
            picBoxDice1.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxDice1.TabIndex = 9;
            picBoxDice1.TabStop = false;
            // 
            // picBoxDice2
            // 
            picBoxDice2.Image = (Image)resources.GetObject("picBoxDice2.Image");
            picBoxDice2.Location = new Point(384, 183);
            picBoxDice2.Name = "picBoxDice2";
            picBoxDice2.Size = new Size(112, 104);
            picBoxDice2.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxDice2.TabIndex = 10;
            picBoxDice2.TabStop = false;
            // 
            // formCraps
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 446);
            Controls.Add(picBoxDice2);
            Controls.Add(picBoxDice1);
            Controls.Add(btnGameRules);
            Controls.Add(lblAnnouncement);
            Controls.Add(btnRoll);
            Controls.Add(textBoxBetAmount);
            Controls.Add(lblBank);
            Controls.Add(lblBankBalance);
            Controls.Add(lblDice1);
            Controls.Add(lblDice2);
            Name = "formCraps";
            Text = "Craps";
            ((System.ComponentModel.ISupportInitialize)picBoxDice1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDice2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblDice2;
        private Label lblDice1;
        private Label lblBankBalance;
        private Label lblBank;
        private TextBox textBoxBetAmount;
        private Button btnRoll;
        private Label lblAnnouncement;
        private Button btnGameRules;
        private PictureBox picBoxDice1;
        private PictureBox picBoxDice2;
    }
}