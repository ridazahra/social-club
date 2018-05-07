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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            s.add(txtname.Text, txtpassword.Text, comboq.Text, txtanswer.Text);
            MessageBox.Show("User has been registered");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 l = new Form2();
            this.Hide();
            l.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
