using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void Topla() 
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label3.Text = (a + b).ToString();
        }
        public void Cikar()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label3.Text = (a - b).ToString();
        }
        public void Bol()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label3.Text = (a / b).ToString();
        }
        public void Carp()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label3.Text = (a * b).ToString();
        }
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = " ";
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            Topla();
        }

        private void btnÇıkar_Click(object sender, EventArgs e)
        {
            Cikar();
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            Bol();
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            Carp();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
