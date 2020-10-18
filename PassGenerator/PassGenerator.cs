using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGenerator
{
    public partial class PassGenerator : Form
    {
        int PasswordLength = 0;
        bool SymbolsChecked = false;

        public PassGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            PasswordLength = int.Parse(cmbPasswordLength.Text);

            if (chkSymbols.Checked == true)
            {
                SymbolsChecked = true;
            }
            else
            {
                SymbolsChecked = false;
            }

            txbPassword.Text = PasswordGenerator(PasswordLength, SymbolsChecked);
        }

        public string PasswordGenerator(int PasswordLength, bool SymbolsChecked)
        {
            Random num = new Random();
            string[] symbols = new string[] { "!", "#", "$", "%", "&", ".", "?", "@", "_" };
            string password = "";
            int type = 0;

            while (password.Length < PasswordLength)
            {
                type = num.Next(0, 4);

                if (type == 0)
                {
                    password += Convert.ToChar(num.Next(65, 91));
                }
                else
                {
                    if (type == 1)
                    {
                        password += Convert.ToChar(num.Next(97, 123));
                    }
                    else
                    {
                        if (type == 2)
                        {
                            password += Convert.ToChar(num.Next(48, 58));
                        }
                        else
                        {
                            if (type == 3 && SymbolsChecked == true)
                            {
                                password += symbols[num.Next(0, 9)];
                            }
                        }
                    }
                }            
            }

            return password;
        }
    }
}
