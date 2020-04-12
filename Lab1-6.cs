using System;
using System.Windows.Forms;

namespace Test1
{
    public partial class Lab1_6 : Form
    {
        public string type, cpu, ram, text;
        public bool[] aux = new bool[3];
        public string[] TYPES = new string[] { "Lenovo", "iMac", "Dell", "HP" };
        public string[] CPUS = new string[] { "Pentium D", "Pentium M", "Xeon" };
        public int[] RAMS = new int[] { 256, 512 };
        public string[] AUX = new string[] { "Printer", "Modem", "Network Adapter" };
        public new void Show()
        {
            textBox1.Text = type;
            text = type + cpu + ram;
            for (int i = 0; i < 3; i++)
                if (aux[i])
                    text += AUX[i] + "\n";
            richTextBox1.Text = text;
        }

        public Lab1_6()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = TYPES[listBox1.SelectedIndex] + "\n";
            textBox1.Text = TYPES[listBox1.SelectedIndex];
            Show();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cpu = CPUS[0] + "\n";
            Show();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cpu = CPUS[1] + "\n";
            Show();
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ram = RAMS[1] + "M\n";
            Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                aux[0] = true;
            else
                aux[0] = false;
            Show();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cpu = CPUS[2] + "\n";
            Show();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                aux[1] = true;
            else
                aux[1] = false;
            Show();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                aux[2] = true;
            else
                aux[2] = false;
            Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text);
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ram = RAMS[0] + "M\n";
            Show();
        }
    }
}
