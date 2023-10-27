namespace CS311_Project2_LTC
{
    public partial class formCraps : Form
    {
        // class fields
        Random randomNum = new Random();
        int myPoint = 0;
        bool firstRoll = true;
        int bankAmount = 100;

        // Empty-argument constructor
        public formCraps()
        {
            InitializeComponent();
            lblAnnouncement.Text = "Please place your bet!";
            lblBank.Text = $"${bankAmount}";
            lblDice1.Text = "";
            lblDice2.Text = "";
        }// end Empty-argument constructor

        // btnRoll_Click method that will call the calculate_score method
        private void btnRoll_Click(object sender, EventArgs e)
        {
            calculate_score();
        }

        //calculate_score method
        private void calculate_score()
        {
            // check to see if the user input a number or not
            if (!int.TryParse(textBoxBetAmount.Text, out int betAmount))
            {
                MessageBox.Show("Please enter a valid integer", "Invalid Input", MessageBoxButtons.OK);
                return;
            }

            textBoxBetAmount.Enabled = false;

            // creating two random dice
            int dice1 = randomNum.Next(1, 7);
            int dice2 = randomNum.Next(1, 7);

            // setting the dice to the labels text and making them a string
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();

            // setting the sum of the dice
            int diceSum = dice1 + dice2;

            // checking if the bet amount is less than or equal to the bank amount
            // also checking to see if the bet amount is over zero
            if (betAmount <= bankAmount && betAmount > 0)
            {
                //  checking if this is the first roll
                if (firstRoll)
                {
                    // win condition if it's the first roll
                    if (diceSum == 7 || diceSum == 11)
                    {
                        lblAnnouncement.Text = "YOU WIN!!";
                        bankAmount += betAmount;
                        lblBank.Text = $"${bankAmount}";
                        btnRoll.Enabled = false;
                        firstRoll = false;
                        keepRollingMsgBox();
                    }
                    // lose condition if it's the first roll
                    else if (diceSum == 2 || diceSum == 3 || diceSum == 12)
                    {
                        lblAnnouncement.Text = "YOU LOSE!!";
                        bankAmount -= betAmount;
                        lblBank.Text = $"${bankAmount}";
                        btnRoll.Enabled = false;
                        firstRoll = false;

                        if (bankAmount == 0)
                        {
                            resetGameMsgBox();
                        }
                        else
                        {
                            keepRollingMsgBox();
                        }
                    }
                    // if the user don't hit any of the magic numbers,
                    // then the point will be set
                    else
                    {
                        myPoint = diceSum;
                        lblAnnouncement.Text = "Your point is " + myPoint + "\nkeep rolling!";
                        firstRoll = false;
                    }
                }
                else
                {
                    // win condition if user reaches the point
                    if (diceSum == myPoint)
                    {
                        lblAnnouncement.Text = "YOU WIN!!";
                        bankAmount += betAmount;
                        lblBank.Text = $"${bankAmount}";
                        btnRoll.Enabled = false;
                        firstRoll = true;
                        keepRollingMsgBox();
                    }
                    // lose condition if user reaches 7 while rolling for point
                    else if (diceSum == 7)
                    {
                        lblAnnouncement.Text = "YOU LOSE!!";
                        bankAmount -= betAmount;
                        lblBank.Text = $"${bankAmount}";
                        btnRoll.Enabled = false;
                        firstRoll = true;

                        if (bankAmount == 0)
                        {
                            resetGameMsgBox();
                        }
                        else if (bankAmount > 0)
                        {
                            keepRollingMsgBox();
                        }
                    }
                }
            }
            // if the user tries to bet zero or less
            else if (betAmount <= 0)
            {
                invalidBetMsgBox();
            }
            // if the user tries to bet more than what's in the bank amount
            else if (betAmount > bankAmount)
            {
                invalidBetMsgBox();
            }
        }

        // resetGameMsgBox method that displays when the user's
        // bank amount reaches zero
        private void resetGameMsgBox()
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show("You have no more money left. Reset Game?", "Reset Game?", messageBoxButtons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int newBankAmount = 100;
                lblBank.Text = $"${newBankAmount}";
                textBoxBetAmount.Text = "";
                resumeGame();
            }
            else
            {
                MessageBox.Show("You have " + lblBank.Text + ". Goodbye!");
            }
        }

        // resumeGame method that's called if the user can continue playing
        private void resumeGame()
        {
            myPoint = 0;
            firstRoll = true;
            lblDice1.Text = "Dice1";
            lblDice2.Text = "Dice2";

            btnRoll.Enabled = true;
            textBoxBetAmount.Enabled = true;
            lblAnnouncement.Text = "Please place your bet!";
        }

        // keepRollingMsgBox method that's called when the user can
        // continue rolling the dice
        private void keepRollingMsgBox()
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show("You have " + lblBank.Text + ". Keep rolling?", "Roll Again?", messageBoxButtons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                resumeGame();
            }
            else
            {
                MessageBox.Show("You have " + lblBank.Text + ". Goodbye!");
            }
        }

        // invalidBetMsgBox that's called when the user input's an invalid bet
        private void invalidBetMsgBox()
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show("Please make a valid bet!", "Invalid Bet", messageBoxButtons);

            if (result == DialogResult.OK)
            {
                btnRoll.Enabled = true;
                textBoxBetAmount.Enabled = true;
            }
        }

        // btnGameRules_click method that displays the rules of the game
        private void btnGameRules_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(
                "You roll two dice.  Each die has six faces, which contain," +
                " one, two, three, four, five, or six dots respectively. After" +
                " the dice have come to rest, the sum of the dots on the two" +
                " dice facing upward is calculated.  If the sum is 7 or 11 on" +
                " the first throw, you win.  If the sum is 2,3, or 12 on the" +
                " first throw (called \"craps\"), you lose (the house wins)." +
                " If the sum is 4, 5, 6, 8, 9, 10 on the first throw that sum" +
                " becomes your \"point\".  To win, you must continue rolling the" +
                " dice until you \"make your point\" (roll the same value). You" +
                " lose by rolling a 7 before making your point.", "Game Rules", messageBoxButtons
                );
        }
    }
}
