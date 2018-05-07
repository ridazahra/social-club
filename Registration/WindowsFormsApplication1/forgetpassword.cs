using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class forgetpassword : Form
    {
        public forgetpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isfound, found;
            localhost.Service1 s = new localhost.Service1();
            s.change_password(comboBox1.Text, textBox2.Text,textBox3.Text, out found, out isfound);
            if (found)
            {
                MessageBox.Show("your password has been changed");
            }
            else
            {
                MessageBox.Show("incorrect information");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
