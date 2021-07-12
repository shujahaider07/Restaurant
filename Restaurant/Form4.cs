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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(Form3.value1);
            listBox1.Items.Add(Form3.value2);
            listBox1.Items.Add(Form2.text1);
            listBox1.Items.Add(Form2.text2);
            listBox1.Items.Add(Form2.text3);
            listBox1.Items.Add(Form2.text4);
            listBox1.Items.Add(Form2.text5);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }catch (Exception ex)
            {
                MessageBox.Show("Select Any food for delete");
            }
            }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
