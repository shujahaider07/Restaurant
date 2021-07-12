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
    public partial class Form2 : Form
    {
     

        public Form2()
        {
          

            InitializeComponent();
        
    }
    string text = "";
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected " + text1+" "+text2 +" "+text3+" "+" "+text4+ " "+text5);

        }
        public static string text1 = "";
        public static string text2 = "";
        public static string text3 = "";
        public static string text4 = "";
        public static string text5 = "";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                text1 = checkBox1.Text;
            }
            else
            {
                text1 = "";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                text2 = checkBox2.Text;
            }
            else
            {
                text2 = "";
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                text3 = checkBox3.Text;
            }
            else
            {
                text3 = "";
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                text5 = checkBox5.Text;
            }
            else
            {
                text5 = "";
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                text4 = checkBox4.Text;
            }
            else
            {
                text4 = "";
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();



        }
    }
}
