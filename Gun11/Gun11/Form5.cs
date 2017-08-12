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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public int a(int b)
        {
            int d = b * b;
            return d ;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text);
            int yazi= a(c);
            MessageBox.Show(yazi.ToString());
        }
    }
}
