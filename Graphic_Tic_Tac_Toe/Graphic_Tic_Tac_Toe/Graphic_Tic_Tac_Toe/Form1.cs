/*
Norman Andrew 
Jasse Moren
Sarah Mac
Samuel Kwibe
 */


// TIC TAC TOE GAME


using System.ComponentModel;

namespace Graphic_Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        bool turn = true; // when is true = X and when is false = Y turn
        int turn_count = 0; 






        public TicTacToe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Samuel,Jasse,Sarah,and Andrew", "Tic Tac Toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckForwinner();
        }
        private void CheckForwinner()
        {
            // This condition will be used in checking the winner Horizontaly
            bool there_is_the_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_the_winner = true;

            else if ((B1.Text == B2.Text) && (A2.Text == B3.Text) && (!B1.Enabled))
                there_is_the_winner = true;

            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_the_winner = true;



            // This condition will be used in checking the winner Verticaly


            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_the_winner = true;

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_the_winner = true;

            if ((A3.Text == B3.Text) && (B2.Text == C3.Text) && (!A3.Enabled))
                there_is_the_winner = true;



            // This condition will be used in checking the winner diagnoly


            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_the_winner = true;

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_the_winner = true;

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!B3.Enabled))
                there_is_the_winner = true;

            if (there_is_the_winner)
            {

                disableButtons();


                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " Wins!", "yayaayay!");

            } // end of if steatment
            else
            {
                if (turn_count == 9)
                    MessageBox.Show(" The game is Draw", "Bummer!!!");
            }





        } // This show that the checking for a winner is end over here.

        private void disableButtons()
        {
            try // this will help us to make it run without having problems 
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false; // after having a winner the other button will be desable
                } // endds
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) // This will be able to set the new game 
        {
            turn = true;
            turn_count = 0;

            try // this will help us to make it run without having problems 
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true; // after having a winner the other button will be desable
                    b.Text = "";
                }
            }
            catch { }
        }

        private void gameInstructionToolStripMenuItem_Click(object sender, EventArgs e) //Game istructions
        {
            MessageBox.Show("Tic Tac Toe is a shared poker card game," +
                " or community card poker game, in which cards are dealt into a particular configuration." +
                " Unlike typical community card poker games, like Texas Hold’Em, " +
                "there are only certain sets of cards that players can use to construct their final hand" +
                ". This game is also known as Criss Cross, as well." +
                "\r\n\r\nTic Tac Toe is a poker game typically played in people’s homes, not in the big casinos. " +
                "Players place an ante prior to the deal and the betting begins with the player sitting directly to the left of the dealer." +
                "\r\nTHE DEAL\r\n\r\nThe dealer deals two cards, face-down, to each player. " +
                "Then they deal 9 cards to the table, face-down, in a 3×3 grid. " +
                "At showdown, players use their two cards with any row " +
                "(8-1-5, 4-9-2, 7-3-6), or any column (1-9-3, 5-2-6, 8-4-7), or any diagonal (8-9-6, 5-9-7), to form a 5-card poker hand." +
                "\r\n\r\nIn some versions of the game, players are dealt four cards as opposed to two. " +
                "The players choose two cards to use with a row, column, or diagonal on the table." +
                " Or, players may use between 4 and 2 of the cards dealt with them with either 1, 2, or 3 cards from the table." +
                " Those cards may come from any row, column, or diagonal.");
        }
    }
}