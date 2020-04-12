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
    public partial class Lab1_3 : Form
    {
        public Lab1_3()
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
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                double a, b, c, x1, x2, delta;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                if (a == 0)
                {
                    MessageBox.Show("Error!!! Please enter again.");
                }
                else
                {
                    delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {

                        x1 = -b / (2 * a);
                        x2 = Math.Sqrt(-delta) / (2 * a);
                        if (x1 == 0)
                        {
                            textBox4.Text = Convert.ToString(Math.Round(x2, 3)) + "i";
                            textBox5.Text = Convert.ToString(Math.Round(x2, 3)) + "i";
                        }
                        else
                        {
                            textBox4.Text = Convert.ToString(Math.Round(x1, 3)) + "+" + Convert.ToString(Math.Round(x2, 3)) + "i";
                            textBox5.Text = Convert.ToString(Math.Round(x1, 3)) + "-" + Convert.ToString(Math.Round(x2, 3)) + "i";
                        }

                    }
                    else if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        textBox4.Text = Convert.ToString(Math.Round(x1,3));
                        textBox5.Text = "x1";
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        textBox4.Text = Convert.ToString(Math.Round(x1,3));
                        textBox5.Text = Convert.ToString(Math.Round(x2,3));
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.TabIndex = 0;
            SendKeys.Send("{TAB}");
            SendKeys.Send("{ENTER}");
            textBox3.TabIndex = 3;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.TabIndex = 0;
            SendKeys.Send("{TAB}");
            textBox1.TabIndex = 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
