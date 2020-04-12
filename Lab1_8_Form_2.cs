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
    public partial class Lab1_8_Form_2 : Form
    {
        public Lab1_8 f1 = new Lab1_8();
        public Lab1_8_Form_2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Lab1_8.keyword = textBox1.Text;
            Lab1_8.selected_index = -Lab1_8.keyword.Length;
            f1.Search();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Lab1_8.keyword = textBox1.Text;
                Lab1_8.selected_index = -Lab1_8.keyword.Length;
                f1.Search();
                Close();
            }
        }
    }
}
