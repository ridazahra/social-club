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
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_forgetpassword f = new admin_forgetpassword();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool l,k;
            localhost.Service1 s = new localhost.Service1();
            s.isadmin(txtname.Text, txtpassword.Text,out l,out k);
            if (l)
            {
                Form7 f = new Form7();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("enter  valid information");
            }

        }
    }
}
