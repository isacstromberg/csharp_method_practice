using System;
using System.Collections;
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string[] stringArr = { "C", "B", "A" };
            int[] intArr = { 3, 2, 1, };

            Array.Sort(stringArr);
            Array.Sort(intArr);

            string[] intArrToString = intArr.Select(i => i.ToString()).ToArray();
            string presentStringArr = String.Join(" ", stringArr);
           string presentIntArr = String.Join(" ", intArrToString);

            MessageBox.Show(presentStringArr);
            MessageBox.Show(presentIntArr);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string a = "b";
            string b = "b";
            int result = 0;
           result = String.Compare(b, a);
            MessageBox.Show(result.ToString());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string mailEnding = "@hotmail.com";
            if (mailEnding.EndsWith("@hotmail.com"))
            {
                MessageBox.Show("Correct format");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string start = "start";
            if (start.StartsWith("start"))
            {
                MessageBox.Show("correct");
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string test = "test";
            MessageBox.Show(test.LastIndexOf("t").ToString());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string test = "test";
     
            MessageBox.Show(test.IndexOf("t").ToString());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string s1 = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvXxYyZz1234567890._-";
            string s2 = "fox-123_testing";
            bool b = false;

            foreach (char c in s2)
            {
                if (s1.Contains(c.ToString()))
                {
                    b = true;
                }
                if (!s1.Contains(c.ToString()))
                {
                    b = false;
                    break;
                }
            }

            MessageBox.Show(b.ToString());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string test = "test";
         
            test = test.Replace('t', 'ö');
          
           

            MessageBox.Show(test);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];

            sourceArray.CopyTo(destinationArray, 0);

            foreach (int num in destinationArray)
            {
                MessageBox.Show(num.ToString());
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            string name = "John";
            int age = 30;
            double height = 175.5;

            string formattedString = string.Format("Name: {0}, Age: {1}, Height: {2}", name, age, height);

            // decimal pricePerOunce = 17.36m;
            int pricePerOunce = 2, pricePerKilo = 1;
            String s = String.Format("The current price is {0} per ounce and {1} per kilo.",
                                     pricePerOunce, pricePerKilo);

            MessageBox.Show(formattedString);
            MessageBox.Show(s);
        }
    }
}
