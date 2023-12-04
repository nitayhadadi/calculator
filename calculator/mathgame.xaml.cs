using System;
using System.Windows;
using System.Windows.Controls;

namespace calculator
{
    public partial class mathgame : Window
    {
        private int number1;
        private int number2;
        private int correctAnswer;
        private Random random = new Random();

        public mathgame()
        {
            InitializeComponent();
            GenerateNewProblem();
        }

        private void GenerateNewProblem()
        {
            number1 = random.Next(1, 10);
            number2 = random.Next(1, 10);
            correctAnswer = number1 + number2; // Example for addition

            // Update UI elements here to show the problem
            // e.g., questionTextBlock.Text = $"{number1} + {number2} = ?";
        }
        private void txtNumber1_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Add logic here if needed
        }

        private void txtNumber2_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Add logic here if needed
        }

        private void CheckAnswer()
        {
            // Assuming answerTextBox is a TextBox where the user enters their answer
            if (int.TryParse(answerTextBox.Text, out int userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Incorrect. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
