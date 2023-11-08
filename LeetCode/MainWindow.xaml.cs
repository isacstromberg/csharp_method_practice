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

namespace LeetCode
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
            string test = "testing";
            for (int i = 0; i < test.Length; i++)
            {
                test = test[..^1];
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dictionary<int,string> data = new Dictionary<int,string>();

            data.Add(1, "Jane Doe");
            data.Add(2, "Jon Doe");
            data.Add(11, "Sully Doe");

            Dictionary<string, int> romanletters = new Dictionary<string, int>();
            romanletters.Add("IV", 4);
            romanletters.Add("I", 1);
            int result = 0;

            string test = "I";

            for (int i = 0; i < test.Length; i++)
            {
                result += romanletters[test];
            }
        }
    }
}
