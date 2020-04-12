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
    public partial class Lab1_4 : Form
    {
        public Lab1_4()
        {
            InitializeComponent();
            Random r = new Random();
            string s = "\n\t";
            int[] arr = new int[10];
            for(int i = 0; i < 10; i++)
            {
                int n;
                n = r.Next(30, 101);
                s += Convert.ToString(n) + "\t\t";
                arr[i] = n;
                if (i == 4)
                    s += "\n\n\t";
            }
            richTextBox1.Text = s + "\n\n\tAvg:\t\t" + Convert.ToString(arr.Average())
                + "\n\n\tMax:\t" + Convert.ToString(arr.Max())
                + "\n\n\tMin:\t\t" + Convert.ToString(arr.Min());
            richTextBox1.Font = new Font("Times New Roman", 18);
        }
    }
}
