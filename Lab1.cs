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
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f = new Lab1_1();
            f.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form f = new Lab1_2();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form f = new Lab1_3();
            f.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form f = new Lab1_4();
            f.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form f = new Lab1_5();
            f.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form f = new Lab1_6();
            f.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form f = new Lab1_7();
            f.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form f = new Lab1_8();
            f.Show();
        }
    }
}
