using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test1
{
    public partial class Lab1_8 : Form
    {
        public static string keyword = "";
        public static int selected_index = 0;
        public Lab1_8()
        {
            InitializeComponent();
        }

        public void Search()
        {
            string text = "";
            int index;
            text = richTextBox1.Text.Substring(selected_index + keyword.Length);
            index = text.IndexOf(keyword);
            if (index != -1)
            {
                richTextBox1.Focus();
                richTextBox1.Select(selected_index + keyword.Length + index, keyword.Length);
                selected_index += index + keyword.Length;
            }
            else
            {
                if (selected_index == -keyword.Length)
                {
                    MessageBox.Show("No such keyword \"" + keyword + "\"in this file", "Error");
                    keyword = "";
                    Lab1_8_Form_2 f2 = new Lab1_8_Form_2();
                    f2.f1 = this;
                    f2.Show();
                }
                else
                {
                    selected_index = -keyword.Length;
                    Search();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Please choose file";
            openFileDialog1.Filter = "文本文件 (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (keyword != "")
            {
                keyword = "";
                selected_index = 0;
            }
            else
                Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "D://";
            saveFileDialog1.Title = "Please choose file";
            saveFileDialog1.Filter = "文本文件 (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (keyword == "")
            {
                Lab1_8_Form_2 f2 = new Lab1_8_Form_2();
                f2.f1 = this;
                f2.Show();
            }
            else
                Search();
        }
    }
}
