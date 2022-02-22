//John Reichenbach
//CS 285-001
//Number Guessing Game
//11-22-2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class GuessingGame : System.Windows.Forms.Form
    {
        Random r = new Random(); //object to generate random numbers
        int target; //integer to hold each random number
        int userScore; //integer to hold the user score

        //constructor
        public GuessingGame()
        {
            InitializeComponent();
            target = r.Next(0, 101); //generates a random number
            userScore = 0; //sets the user score to 0
        }

        //when the guess button is pressed
        private void guessButton_Text(object sender, EventArgs e)
        {
            int num;

            //makes sure the user only enters an integer
            if (int.TryParse(userGuess.Text, out num) == true)
            {
                //if the user guesses the correct number
                if (num == target)
                {
                    BackColor = System.Drawing.Color.Green;
                    Hint.Text = "Correct";
                    userScore++;
                    score.Text = userScore.ToString();
                    Guess.Enabled = false;
                }
                //if the user enters a value less than the random number
                else if (num < target)
                {
                    BackColor = System.Drawing.Color.Yellow;
                    Hint.Text = "Higher";
                    userScore++;
                    score.Text = userScore.ToString();
                }
                //else, the user entered a value greater than the random number
                else
                {
                    BackColor = System.Drawing.Color.Red;
                    Hint.Text = "Lower";
                    userScore++;
                    score.Text = userScore.ToString();
                }
            }
            //else, the user entered an invalid input
            else
            {
                MessageBox.Show("Invalid Input", "Error");
            }
        }

        //when the reset button is clicked
        private void resetButton_Click(object sender, EventArgs e)
        {
            target = r.Next(0, 101);
            Hint.Text = "";
            userGuess.Text = "";
            BackColor = System.Drawing.Color.LightBlue;
            userScore = 0;
            score.Text = userScore.ToString();
            Guess.Enabled = true;
        }

        private void GuessingGame_Load(object sender, EventArgs e)
        {

        }
    }
}
