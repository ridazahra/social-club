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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool isfound, found;
            localhost.Service1 s = new localhost.Service1();
            s.search(textBox1.Text, textBox2.Text, out isfound, out found);
            if (isfound)
            {
                MessageBox.Show("user has been login");
            }
            else
            {
                MessageBox.Show("plz enter valid information");
            }
            Form3 f = new Form3();
            this.Hide();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword f = new forgetpassword();
            f.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_login d = new admin_login();
            this.Hide();
            d.Show();
        }
    }
}
