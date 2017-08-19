using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GuncelSil()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.Remove();
            }
        }
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
           
            int a =Convert.ToInt32(numericUpDown3.Value);
            int kalan;
            DateTime bitisSure;
            bitisSure = dateTimePicker1.Value.AddYears(a);
            kalan =Convert.ToInt32(DateTime.Now.Year - bitisSure.Year);
            if (kalan<=0)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Stok s = new Stok();
                s.UrunKodu = Convert.ToInt32(textBox1.Text);
                s.UrunAdi = textBox2.Text;
                s.Fiyat = Convert.ToInt32(numericUpDown1.Value);
                s.StokMiktar = Convert.ToInt32(numericUpDown2.Value);
                s.UretimTarih = Convert.ToDateTime(dateTimePicker1.Value);


                ListViewItem ls = new ListViewItem();
                ls.Text = s.UrunKodu.ToString();
                ls.SubItems.Add(s.UrunAdi);
                ls.SubItems.Add(s.Fiyat.ToString());
                ls.SubItems.Add(s.StokMiktar.ToString());
                ls.SubItems.Add(s.UretimTarih.ToShortDateString());
                listView1.Items.Add(ls);
                Temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Alanları Eksiksiz Doldurunuz");
            }
          
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].Text;
            textBox2.Text= listView1.SelectedItems[0].SubItems[1].Text;
            numericUpDown1.Value =Convert.ToInt32( listView1.SelectedItems[0].SubItems[2].Text);
            numericUpDown2.Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            dateTimePicker1.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[4].Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                GuncelSil();
                Stok s = new Stok();
                s.UrunKodu = Convert.ToInt32(textBox1.Text);
                s.UrunAdi = textBox2.Text;
                s.Fiyat = Convert.ToInt32(numericUpDown1.Value);
                s.StokMiktar = Convert.ToInt32(numericUpDown2.Value);
                s.UretimTarih = Convert.ToDateTime(dateTimePicker1.Value);


                ListViewItem ls = new ListViewItem();
                ls.Text = s.UrunKodu.ToString();
                ls.SubItems.Add(s.UrunAdi);
                ls.SubItems.Add(s.Fiyat.ToString());
                ls.SubItems.Add(s.StokMiktar.ToString());
                ls.SubItems.Add(s.UretimTarih.ToShortDateString());
                listView1.Items.Add(ls);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Güncellemek istediğiniz ürünün ürün koduna çift tıklayınız");
            }
           
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Temizle();
            listView1.Items.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//Sadece Numara Girilsin
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
      

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//Sadece Harf Girilsin
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
