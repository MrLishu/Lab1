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
    public partial class Lab1_1 : Form
    {
        public Lab1_1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("仿宋", 25);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("楷体", 15);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = textBox1.SelectedText;
            this.textBox2.Font = textBox1.Font;
        }
    }
}
