using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //if ((int)e.KeyChar >= 48 && (int)e.KeyChar < = 57)
            //{
            //    e.Handled = false;//eğer rakamsa  yazdır.
            //}
            //else
            //{
            //    e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            //}
        }
        public void Temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                      txt.Clear();

                }
                else if(item is NumericUpDown)
                {
                    NumericUpDown nu = (NumericUpDown)item;
                    nu.Value = 0;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }

            }
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox4.Clear();
            //textBox5.Clear();
           
            //numericUpDown1.Value = 0;
            //lstKitaplar.Items.Clear();

        }
        Kitap k = new Kitap();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
               
                k.KitapAdi = textBox1.Text;
                k.Yazari = textBox2.Text;
                k.ISBN1 = Convert.ToInt32(textBox3.Text);
                k.Turu = textBox4.Text;
                k.YayinEvi = textBox5.Text;
                k.YayinTarihi = Convert.ToDateTime(dateTimePicker1.Text);
                k.SayfaSayi = Convert.ToInt32(numericUpDown1.Value);
                lstKitaplar.Items.Add(k.KitapAdi + " " + k.Yazari + " " + k.ISBN1 + " " + k.Turu + " " + k.YayinEvi + " " + k.YayinTarihi + " " + k.SayfaSayi);
            }
            catch (Exception)
            {

                MessageBox.Show("Gerekli Alanları Doldurun");
            }
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
      
        private void btnGuncel_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            k.KitapAdi = textBox1.Text;
            k.Yazari = textBox2.Text;
            k.ISBN1 = Convert.ToInt32(textBox3.Text);
            k.Turu = textBox4.Text;
            k.YayinEvi = textBox5.Text;
            k.YayinTarihi = Convert.ToDateTime(dateTimePicker1.Text);
            k.SayfaSayi = Convert.ToInt32(numericUpDown1.Value);
            lstKitaplar.Items.Remove(lstKitaplar.SelectedItem);
            lstKitaplar.Items.Add(k.KitapAdi + " " + k.Yazari + " " + k.ISBN1 + " " + k.Turu + " " + k.YayinEvi + " " + k.YayinTarihi + " " + k.SayfaSayi);
        }
    }
}
