using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Lab1_2 : Form
    {
        public Lab1_2()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int m, n, x, y;
                m = Convert.ToInt32(textBox1.Text);
                n = Convert.ToInt32(textBox2.Text);
                if (m % 2 != 0 ^ n % 2 != 0 ^ 2 * m > n ^ 4 * m < n)
                {
                    MessageBox.Show("Error!!! Please enter again.");
                }
                else
                {
                    y = (4 * m - n) / 2;
                    x = (n - 2 * m) / 2;
                    textBox3.Text = Convert.ToString(x);
                    textBox4.Text = Convert.ToString(y);
                }
            }
        }
    }
}
