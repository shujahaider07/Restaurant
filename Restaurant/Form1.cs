using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
         
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
         

     
            if (textBox1.Text == "shuja" && textBox2.Text == "haider" && textBox1.Text != "" && textBox2.Text != "")
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;

                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(15);
                    progressBar1.Value = i;

                   
                }
                Form2 frm = new Form2();
           
               frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong input");
              //  MessageBox.Show("Enter proper Information");
            }
               
           
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (textBox1.Text))
            {
                errorProvider1.SetError(this.textBox1,"Please fill USERNAME");
                textBox1.Focus();
                //MessageBox.Show("PLEASE FILL THE BOX FIRST");
            }
            else
            {
                errorProvider1.Clear();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
            textBox2.PasswordChar = '*';
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2,"Fill password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}
