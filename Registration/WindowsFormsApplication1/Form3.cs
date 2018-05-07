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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 t = new Form4();
            this.Hide();
            t.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 p = new Form5();
            this.Hide();
            p.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            this.Hide();
            s.Show();

        }
    }
}
