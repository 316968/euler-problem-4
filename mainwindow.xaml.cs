/*Quinn Parker-Joyes
 * June 18 2018
 * ICS3U
 * Euler Problem 4
 * finds a large palindrome number
 */



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

namespace eulerProblem4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool correct = false;
        
        int[] factors = new int[2];
        int first = 998;
        int palindrome = 0;

        public MainWindow()
        {
            InitializeComponent();
            while(correct == false)
            {   // first decreases until answer found
                first--;
                //first is put into the palindrome method
                palindrome = createPalindrome(first);
                for(int i = 999; i>99; i--)
                {   
                    if((palindrome / i) > 999 || i * i < palindrome)
                    {
                        break;
                    }
                    if(palindrome % i == 0)
                    {
                        correct = true;
                        factors[0] = palindrome / i;
                        factors[1] = i;
                        break;
                    }
                }
            }
            MessageBox.Show(palindrome.ToString());
        }
        private int createPalindrome(int first)
        {
            char[] reversed = first.ToString().Reverse().ToArray();
            return Convert.ToInt32(first + new string(reversed));
        }



    }
}
