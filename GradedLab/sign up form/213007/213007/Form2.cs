using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213007
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string username;
        string pass;
        string cpass;
        string email;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            email = textBox2.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pass = textBox3.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cpass = textBox3.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "User: " + username + "Pass: " + pass + " " + " Email:" + email + " ";
            MessageBox.Show(data, "signup data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Form1 login = new Form1();
            login.Show();
        }
    }
}
