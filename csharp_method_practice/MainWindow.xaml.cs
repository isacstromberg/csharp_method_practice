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

namespace csharp_method_practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string firstString = "Hello! I'm testing this new function";
            string secondString = " Because i want to become a better software engineer";


            MessageBox.Show(String.Concat(firstString, secondString));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string testString = "This is a test, so this part should be excluded";
            MessageBox.Show(testString.Substring(0,14));        
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string[] testArr = {"This", "Array", "Will", "Be", "Reversed"};
            Array.Reverse(testArr);
       
            MessageBox.Show($"{testArr[0]}");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string[] testArr = { "I", "am", "testing", "a", "method","called", "Join()" };
            string testJoin = String.Join(" ", testArr);
            MessageBox.Show(testJoin);
        }
    }
}
