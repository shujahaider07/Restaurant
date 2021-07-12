using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form3 : Form
    {
        public static string value1;
        public static string value2;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string [] colddrinks = {"Pepsi","CocaCola","Limca","Sprite","7up","Dew","Sting","Pinacoloda"};
            foreach (string  item in colddrinks)
            {
                comboBox1.Items.Add(item);
                comboBox1.Text = "Pepsi";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            value1 = textBox1.Text;
            value2 = comboBox1.Text;
            Form4 frm = new Form4();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
