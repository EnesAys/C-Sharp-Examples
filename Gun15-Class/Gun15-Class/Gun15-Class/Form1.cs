using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun15_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Class içerisinde prob tab tab kısa get,set metodu oluşturur.
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            double imdb = Convert.ToDouble(textBox2.Text);
            TvDizisi a = new TvDizisi();
            a.Isim = isim;
            a.Imdb = imdb;
            MessageBox.Show("Dizi ismi " + isim + " dizinin puanı " + imdb);
        }
    }
}
