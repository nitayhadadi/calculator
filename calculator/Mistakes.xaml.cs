using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Interaction logic for Mistakes.xaml
    /// </summary>
    public partial class Mistakes : Window
    {
        public Mistakes()
        {
            InitializeComponent();
        }
        private List<string> listOfMistakes = new List<string>();

        public void ShowMistakes(List<string> mistakes)
        {
            foreach (var mistake in mistakes)
            {
                MistakesList.Items.Add(mistake);
            }
        }
        // This could be a part of your CheckAnswer method or an end-of-game method
        private void ShowResultsWindow()
        {
            try
            {
                Mistakes mistakesWindow = new Mistakes();
                mistakesWindow.ShowMistakes(listOfMistakes);
                mistakesWindow.Show();
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }

    }





