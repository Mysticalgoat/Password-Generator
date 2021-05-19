using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_pass_Click(object sender, EventArgs e)
        {
            string[] lowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "j", "i", "k", "l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "k", "y", "z" };
            string[] upperCase = { "A", "B", "C", "D", "E", "F", "G", "H", "J", "I", "K", "L", "M",
            "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] specialChar = { "!", "#", "£", "@", "*", "^", "(", ")", ".", "+" };

            int length = Convert.ToInt32(pass_Length.Value);
            string Password = "";
            Random rand = new Random();
            //if special wanted
            if (chkbox_special_Char.Checked)
            {
                for (int i = 0; i < length; i++)
                {
                    int selectlist = rand.Next(1, 5);
                    //lower
                    if (selectlist == 1)
                    {
                        int selectValue = rand.Next(0, 25);
                        string nextValue = lowerCase[selectValue];
                        Password += nextValue;
                    }
                    //upper
                    if (selectlist == 2)
                    {
                        int selectValue = rand.Next(0, 25);
                        string nextValue = upperCase[selectValue];
                        Password += nextValue;
                    }
                    //number
                    if (selectlist == 3)
                    {
                        int selectValue = rand.Next(0, 9);
                        string nextValue = numbers[selectValue].ToString();
                        Password += nextValue;
                    }
                    //special
                    if (selectlist == 4)
                    {
                        int selectValue = rand.Next(0, 9);
                        string nextValue = specialChar[selectValue].ToString();
                        Password += nextValue;
                    }
                }// end of for

            }//end of if special
             //if no special
            if (!chkbox_special_Char.Checked)
            {
                for (int i = 0; i < length; i++)
                {
                    int selectlist = rand.Next(1, 4);
                    //lower
                    if (selectlist == 1)
                    {
                        int selectValue = rand.Next(0, 25);
                        string nextValue = lowerCase[selectValue];
                        Password += nextValue;
                    }
                    //upper
                    if (selectlist == 2)
                    {
                        int selectValue = rand.Next(0, 25);
                        string nextValue = upperCase[selectValue];
                        Password += nextValue;
                    }
                    //number
                    if (selectlist == 3)
                    {
                        int selectValue = rand.Next(0, 9);
                        string nextValue = numbers[selectValue].ToString();
                        Password += nextValue;
                    }
                }
            }//end of if not special
            pass_Box.Clear();
            pass_Box.Text = Password;


        }
    }
}