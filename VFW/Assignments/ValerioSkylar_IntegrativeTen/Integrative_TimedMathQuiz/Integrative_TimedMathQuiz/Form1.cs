using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Skylar Valerio
 * 10.21.19
 * Integrative Ten
 * VFW
 * 
 */

namespace Integrative_TimedMathQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();

        // stores numbers for addition problem
        int addend1;
        int addend2;

        // stores numbers for the subtraction problem
        int minuend;
        int subtrahend;

        // stores numbers for the multiplication problem
        int multiplicand;
        int multiplier;

        // stores numbers for the division problem
        int dividend;
        int divisor;

        // int to keep track of the remaining time
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }


        public void StartTheQuiz()
        {
            // randomize numbers
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // display randomized numbers
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // make sure the sum value is 0 before adding anything else to it
            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }


        // starts the quiz
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();

            // disable the button during the quiz
            startButton.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // display the new time left when the clock is ticking
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        // check to see if the user got the answer right
        // true if they did, false if they didn't
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
            && (minuend - subtrahend == difference.Value)
            && (multiplicand * multiplier == product.Value)
            && (dividend / divisor == quotient.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void answer_Enter(object sender, EventArgs e)
        {
            // remember the sender is the object whose event is firing
            // in this case, the numericupdown

            // select the text of the numericupdown
            NumericUpDown answerBox = sender as NumericUpDown;

            // if the caste was successful, then this will select the current value
            // and clear it if a different value is entered in
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
