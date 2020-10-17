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



        }
    }
}
