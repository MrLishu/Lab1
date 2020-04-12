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
    public partial class Lab1_5 : Form
    {
        public string t = "";
        public bool IsH(string s)
        {
            int l = s.Length;
            if (l == 1)
                return true;
            else if (l == 2)
            {
                if (s[0] == s[1])
                    return true;
                else
                    return false;
            }
            else
            {
                if (s[0] == s[l - 1])
                    return IsH(s.Substring(1, l - 2));
                else
                    return false;
            }
        }
        public Lab1_5()
        {
            InitializeComponent();
        }

        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                label3.Text += t;
                if (IsH(t))
                    label3.Text += "★";
                t = "";
                label3.Text += "\n";
            }
            else
                t += Convert.ToString(e.KeyChar);
        }
    }
}
