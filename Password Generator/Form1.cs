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
            string[] specialChar = { "!", "#", "£", "@", "*", "^", "(", ")", ".", "+" };

            int length = Convert.ToInt32(pass_Length.Value); //Gets required length of password
            string Password = "";
            Random rand = new Random(); //instanciates a new rand object

            //if special wanted
            if (chkbox_special_Char.Checked)
            {
                for (int i = 0; i < length; i++) // loops length of password
                {
                    int selectlist = rand.Next(0, 4);
                    switch (selectlist)
                    {
                        //lower
                        case 0:
                            Password += lowerCase[rand.Next(0, 26)].ToString();
                            break;

                        //upper
                        case 1:
                            Password += upperCase[rand.Next(0, 26)].ToString();
                            break;

                        //Number
                        case 2:
                            Password += rand.Next(0, 10).ToString().ToString();
                            break;

                        //special
                        case 3:
                            Password += specialChar[rand.Next(0, 10)].ToString(); //10 otherwise 9 won't be included
                            break;
                    }
                }

            }

            //if no special
            if (!chkbox_special_Char.Checked)
            {
                for (int i = 0; i < length; i++) // loops length of password
                {
                    int selectlist = rand.Next(0, 3);
                    switch (selectlist)
                    {
                        //lower
                        case 0:
                            Password += lowerCase[rand.Next(0, 26)].ToString();
                            break;

                        //upper
                        case 1:
                            Password += upperCase[rand.Next(0, 26)].ToString();
                            break;

                        //Number
                        case 2:
                            Password += rand.Next(0, 10).ToString(); //10 otherwise 9 won't be included
                            break;
                    }
                }
            }
            pass_Box.Clear(); //ensure password is blank when inputting password
            pass_Box.Text = Password; //posts password into text box
        }
    }
}