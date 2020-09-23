using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object globally and name it randomizer
        // This will be used to generate random numbers
        Random randomizer = new Random();

        // Create addition variables to store random integers
        int addend1;
        int addend2;

        // Create subtraction variables to store random integers
        int minuend;
        int subtrahead;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // Create global integer variable to track time
        int timeLeft;

        // Get current date and store it in a variable
        DateTime currentDate = DateTime.Now;
        
        public Form1()
        {
            InitializeComponent();

            date.Text = currentDate.ToString("dd MMMM yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void StartTheQuiz()
        {
            // Fill addition variables with random integers
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the integers into strings to display them
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // Zero out the value of sum prior to use
            sum.Value = 0;

            // Fill in the subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahead = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahead.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem
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

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timeLeft <= 5)
            {
                timeLabel.BackColor = Color.Red;
            }

            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
                timeLabel.BackColor = Color.White;
            }
            else if (timeLeft > 0)
            {
                // Update timeLeft and display it
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If timer runns out, stop it and display a message
                // Also display correct answers
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahead;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
                timeLabel.BackColor = Color.White;
            }
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahead == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void true_Tone(object sender, EventArgs e)
        {
            if (sum.Value == addend1 + addend2)
                System.Media.SystemSounds.Exclamation.Play();
        }

        private void treu_Tone_Subtract(object sender, EventArgs e)
        {
            if (difference.Value == minuend - subtrahead)
                System.Media.SystemSounds.Exclamation.Play();
        }

        private void true_Tone_Multiply(object sender, EventArgs e)
        {
            if (product.Value == multiplicand * multiplier)
                System.Media.SystemSounds.Exclamation.Play();
        }

        private void true_Tone_Div(object sender, EventArgs e)
        {
            if (quotient.Value == dividend / divisor)
                System.Media.SystemSounds.Exclamation.Play();
        }
    }
}
