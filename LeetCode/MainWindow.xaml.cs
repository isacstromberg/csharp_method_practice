using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
           
            Dictionary<string, int> romanletters = new Dictionary<string, int>();
            romanletters.Add("I", 1);
            romanletters.Add("V", 5);
            romanletters.Add("X", 10);
            romanletters.Add("L", 50);
            romanletters.Add("C", 100);
            romanletters.Add("D", 500);
            romanletters.Add("M", 1000);
            
            int result = 0;
            int previous = 0;
            string s = "MCMXCVI";
            char[] chars= s.ToCharArray();      
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                int currentVal = romanletters[chars[i].ToString()];
                if (currentVal < previous)
                {
                    result -= currentVal;
                   
                }
                else
                {
                    result += romanletters[chars[i].ToString()];
                }
                previous = currentVal;
            }




            MessageBox.Show(result.ToString());

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Dictionary<int,char> keys = new Dictionary<int,char>();
            keys.Add(0,'(');
            keys.Add(1, ')');
            keys.Add(2, '[');
            keys.Add(3, ']');
            keys.Add(4, '{');
            keys.Add(5, '}');

            string s = "()[]{}";
            char[] chars = s.ToCharArray();
            char previous = chars[0];
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != keys[i])
                {
                    MessageBox.Show(chars[i].ToString());   
                }
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            /*int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int k = 0;
            Array.Sort(nums);
            for (int j = 1; j < nums.Length; j++)
            {
              
                if (nums[j - 1] == nums[j])
                {
                    nums[k] = nums[j];
                  
                }
                if (nums[j - 1] != nums[j])
                {
                    nums[k] = nums[j];
                    k++;
                }
            }*/
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
              int i = 1;

              foreach (int n in nums)
              {
                  if (nums[i - 1] != n) nums[i++] = n;
              }

         




          MessageBox.Show(i.ToString());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int[] digits = { 9, 9, 9 };

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    break;
                }
                digits[i] = 0;
            }

            List<int> num = new List<int>();
      
         digits[0] = 1;


Array.Resize(ref digits, digits.Length + 1);
digits[digits.Length - 1] = 0;

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int[] s = { 2, 1, 4, 3, 3, 7, 6 };

            Array.Sort(s);

            int uniqueValue = s.GroupBy(x => x)
                                .Where(g => g.Count() == 1)
                                .Select(g => g.Key)
                                .FirstOrDefault();

            MessageBox.Show("lol");

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;
            int x = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    MessageBox.Show(i.ToString());
                }
            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (target > nums[x] && target < nums[i])
                {
                    MessageBox.Show(x+1.ToString());
                }
                x++;
            }


        }
    }
}
