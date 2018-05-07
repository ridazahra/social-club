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
    public partial class admin_forgetpassword : Form
    {
        public admin_forgetpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool change_p,c;
            localhost.Service1 s = new localhost.Service1();
            s.change(txtname.Text, txtpassword.Text, txtkey.Text, out change_p, out c);
            if (change_p)
            {
                MessageBox.Show("password has been changed");
            }
            else {
                MessageBox.Show("enter valid info");
            }


        }
    }
}
