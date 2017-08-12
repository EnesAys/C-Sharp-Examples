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
    public partial class Form2_metotlar_ : Form
    {
        public Form2_metotlar_()
        {
            InitializeComponent();
        }

        private void Form2_metotlar__Load(object sender, EventArgs e)
        {
            //public-açık/ static-sınıf ile çağrılabilir/ private-özel
            
        }
        //static void Merhaba()
        //{
        //    MessageBox.Show("Merhaba");
        //}
        //public void AlanHesap(int a,int b)
        //{
        //   MessageBox.Show(" "+ (a * b));

        //}
        public void Hesapla()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(a*b);
            label1.Text = (a * b).ToString();
            checkBox1.Checked = true;
            
           

        }
        public void kaydet()
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Clear();
                checkBox1.Checked = false;
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
        }
        public void Temizle()
        {
            listBox1.Items.Clear();
            checkBox1.Checked = false;
            textBox1.Text = " ";
            textBox2.Text = " ";
            label1.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Merhaba();
            //int sayi1 = Convert.ToInt32(textBox1.Text);
            //int sayi2 = Convert.ToInt32(textBox2.Text);
            //AlanHesap(sayi1,sayi2);
            Hesapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int sayi1 = Convert.ToInt32(textBox1.Text);
            //int sayi2 = Convert.ToInt32(textBox2.Text);
            //AlanHesap(sayi1, sayi2);
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kaydet();
        }
    }
}
