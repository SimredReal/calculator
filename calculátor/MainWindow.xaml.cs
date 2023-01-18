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

namespace calculátor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string number = "0";
        string memory = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void clickedNumber(int input)
        {
            number = number == "0" ? input.ToString() : number + input.ToString();
            updateDisplays();
        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {

        }

        
        private void equals_Click(object sender, RoutedEventArgs e)
        {

        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            number = "0";
            memory = null;
            updateDisplays();
        }
        private void updateDisplays()
        {
            display.Text = number;
            memorydisplay.Text = memory;
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(1);

        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(2);

        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(3);

        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(0);

        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(7);

        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(8);

        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(9);

        }
        private void four_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(4);
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(5);
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            clickedNumber(6);

        }


        
    }
}
