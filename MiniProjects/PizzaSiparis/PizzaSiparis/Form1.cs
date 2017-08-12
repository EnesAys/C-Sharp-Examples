using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Temizle()
        {
            cbPizza.Text = " ";
            cbBoy.Text = " ";
            cbKenar.Text = " ";
            cbHamur.Text = " ";
            cbBoy.Enabled = false;
            cbKenar.Enabled = false;
            cbHamur.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            lstSepet.Visible = false;
            lstSepet.Items.Clear();
        }
        public int FiyatHesapla()
        {
            int fiyat = 0;
            switch ((cbPizza.SelectedIndex))
            {
                case 0:
                    fiyat += 5;
                    break;
                case 1:
                    fiyat += 3;
                    break;
                case 2:
                    fiyat += 10;
                    break;
                default:
                    MessageBox.Show("Lütfen Pizza Seçiniz");
                    break;
            }

            switch ((cbBoy.SelectedIndex))
            {
                case 0:
                    fiyat += 3;
                    break;
                case 1:
                    fiyat += 5;
                    break;
                case 2:
                    fiyat += 10;
                    break;
                default:
                    MessageBox.Show("Lütfen Boy Seçiniz");
                    break;
            }

            switch ((cbKenar.SelectedIndex))
            {
               
                case 1:
                    fiyat += 2;
                    break;
                case 2:
                    fiyat += 3;
                    break;
                default:
                    MessageBox.Show("Lütfen Kenar Seçiniz");
                    break;
            }

            if (checkBox1.Checked==true && checkBox2.Checked==true && checkBox3.Checked==true && checkBox4.Checked==true)
            {
                fiyat++;// Sadece bir arttırdım. 3 den fazla seçimde bir artacak toplam 4 checkBoxım bulunuyor yani 1 lira artması için hepsinin seçili olması gerek.
            }

            return fiyat;
        }

        private void cbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBoy.Enabled = true;
        }

        private void cbBoy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKenar.Enabled = true;
        }

        private void cbKenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHamur.Enabled = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            int tutar= FiyatHesapla();
            lstSepet.Items.Add(cbPizza.Text+" - "+cbBoy.Text+" - "+cbKenar.Text+" - "+cbHamur.Text+" Fİyat = "+tutar.ToString()+" tl");
            lstSepet.Visible = true;
        }
    }
}
