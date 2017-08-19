using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun13
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower()=="enes")
            {
                Form a = new Form1();
                    a.Show();
               
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Enes ! Doğru yazınız");
            }
        }
    }
}
