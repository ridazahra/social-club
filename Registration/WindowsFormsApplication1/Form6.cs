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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
           BindingSource bs = new BindingSource();
           bs.DataSource = s.search_servant("servant");
            dataGridView1.DataSource = bs;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 z = new Form3();
            this.Hide();
            z.Show();
        }
    }
}
