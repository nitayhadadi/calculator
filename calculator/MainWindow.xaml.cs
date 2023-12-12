using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    
    public partial class MainWindow : Window
    {
       
        internal class Start
        {

        }
       
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            if (int.TryParse(AgeTextBox.Text, out int gradeLevel))
            {
                // Ensure grade level is within a valid range (e.g., 1 to 4)
                if (gradeLevel >= 1 && gradeLevel <= 4)
                {
                    mathgame gamePage = new mathgame(gradeLevel);  // Ensure this is the only declaration of gamePage in this scope
                    gamePage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid grade level (1-4).");
                }
            }
            else
            {
                MessageBox.Show("Please enter a numeric grade level.");
            }
        }

        private void ageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
