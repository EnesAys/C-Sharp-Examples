using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Stok f3 = new Stok();
            //f3.Show();
            new Stok().Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Cari().Show();
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Masraf().Show();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
