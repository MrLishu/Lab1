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
    public partial class Lab1_7_Form_2 : Form
    {
        public Lab1_7_Form_2(int[] arr)
        {
            InitializeComponent();
            int min=100;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min & arr[i] > 0)
                    min = arr[i];
            }
            textBox1.Text = min.ToString();
            textBox2.Text = arr.Max().ToString();
            textBox3.Text = arr.Average().ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
