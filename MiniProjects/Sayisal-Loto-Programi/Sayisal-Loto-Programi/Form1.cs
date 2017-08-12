using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayisal_Loto_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a;
            int sayac = 0;
            int[] numaralar = new int[6];
            while (sayac < 6)
            {
                a = rnd.Next(1, 50);
                if (!numaralar.Contains(a))
                {
                    numaralar[sayac] = a;
                    sayac++;
                }
            }
            Array.Sort(numaralar);
            textBox1.Text = numaralar[0].ToString();
            textBox2.Text = numaralar[1].ToString();
            textBox3.Text = numaralar[2].ToString();
            textBox4.Text = numaralar[3].ToString();
            textBox5.Text = numaralar[4].ToString();
            textBox6.Text = numaralar[5].ToString();
        }
    }
}
