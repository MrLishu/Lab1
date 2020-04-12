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
    public partial class Lab1_7 : Form
    {
        public Lab1_7()
        {
            InitializeComponent();
        }

        public int[] arr = new int[20];
        public Random r = new Random();
        public int len;
        public bool data_generated = false;

        public void Data_show()
        {
            richTextBox1.Text = "";
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    richTextBox1.Text += arr[i].ToString() + "\n";

            }
        }

        private void CountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data_generated)
            {
                Form f2 = new Lab1_7_Form_2(arr);
                f2.Show();
            }
            else
                MessageBox.Show("Please generate data first!", "Error");
        }

        private void GenerateRandomDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                arr[i] = r.Next(1, 101);
            for (int i = 10; i < 20; i++)
                arr[i] = 0;
            data_generated = true;
            len = 10;
            Data_show();
        }

        private void DeleteTheMinimumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int min = 100, index = 0;
            for(int i = 0; i < len; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            for (int i = index; i < len; i++)
            {
                if (i == len)
                    arr[i] = 0;
                arr[i] = arr[i + 1];
            }
            len -= 1;
            Data_show();
        }

        private void DeleteTheMaximumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = 0, index = 0;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            for (int i = index; i < len; i++)
            {
                if (i == len)
                    arr[i] = 0;
                arr[i] = arr[i + 1];
            }
            len -= 1;
            Data_show();
        }

        private void AddDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (len == 20)
                MessageBox.Show("Too much data! Please regenerate.", "Too much data");
            else
            {
                arr[len] = r.Next(1, 100);
                len += 1;
                Data_show();
            }
        }

        private void FinishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
