using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun19_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(BiletTipi)))
            {
                comboBox1.Items.Add(item);
            }
        }
        Normal n = new Normal();
        Ogrenci o = new Ogrenci();
        Kampanya k = new Kampanya();
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedIndex==0)
            {
                
                MessageBox.Show(n.Fiyat().ToString()+" "+ BiletTipi.Normal);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                
                textBox1.Visible = true;
                label2.Visible = true;
                if (textBox1.Text == "enes")
                {
                    MessageBox.Show((k.Fiyat() - 10).ToString() +" "+ BiletTipi.İndirimli);
                }
                else
                {
                    MessageBox.Show(k.Fiyat().ToString() +" "+ BiletTipi.İndirimli);
                }
                
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                MessageBox.Show(o.Fiyat().ToString()+BiletTipi.Ogrenci);
            }
         

        }
    }
}
