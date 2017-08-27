using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun18
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form1 a = new Form1();

            a.txtAd.Text = listView1.SelectedItems[0].SubItems[0].Text;
            a.maskedtxtTel.Text = listView1.SelectedItems[0].SubItems[1].Text;
            a.txtMail.Text = listView1.SelectedItems[0].SubItems[2].Text;
           
            a.Show();
            this.Hide();

        }

       
    }
}
