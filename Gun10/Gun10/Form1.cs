using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUrunler.Items.Clear();
            if (cbKategoriler.SelectedIndex==0)
            {
                lstUrunler.Items.Add ("iPhone");
                lstUrunler.Items.Add("Samsung");
                lstUrunler.Items.Add("Nexus");
            }
            else if (cbKategoriler.SelectedIndex==1)
            {
                lstUrunler.Items.Add("Asus");
                lstUrunler.Items.Add("Monster");
                lstUrunler.Items.Add("MacBook");
            }
            else if (cbKategoriler.SelectedIndex == 2)
            {
                lstUrunler.Items.Add("Çamaşır Makinesi");
                lstUrunler.Items.Add("Buzdolabı");
                lstUrunler.Items.Add("Bulaşık Makinesi");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Add(lstUrunler.SelectedItem);
            label4.Text = "Sepetinizde"+(lstSepet.Items.Count).ToString()+"Adet ürün bulunmaktadır";
        
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //lstUrunler.Items.Add(lstSepet.SelectedItem);
            lstSepet.Items.Remove(lstSepet.SelectedItem);
            label4.Text = "Sepetinizde" + (lstSepet.Items.Count).ToString() + "Adet ürün bulunmaktadır";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for (int i = lstUrunler.SelectedIndices.Count-1; i >=0 ; i--)
            {
                lstSepet.Items.Add(lstUrunler.SelectedItems[i]);
                lstSepet.Sorted = true;
            }
         
            label4.Text = "Sepetinizde" + (lstSepet.Items.Count).ToString() + "Adet ürün bulunmaktadır";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = lstSepet.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstSepet.Items.Remove(lstSepet.SelectedItems[i]);
                lstSepet.Sorted = true;
            }
            label4.Text = "Sepetinizde" + (lstSepet.Items.Count).ToString() + "Adet ürün bulunmaktadır";
            //lstUrunler.Items.Add(lstSepet.Items);
            //lstSepet.Items.Clear();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            lstTumSiparisler.Items.Clear();
            string a = txtAd.Text;
            if (txtAd.Text==" ")
            {
                MessageBox.Show("Lütfen Adınızı Giriniz");
            }
            
            if (rBind1.Checked==true)
            {
                lstTumSiparisler.Items.Add(lstSepet.Items.Count+" ADET ÜRÜN"+a+" "+rBind1.Text);
                lstSepet.Items.Clear();
                lstUrunler.Items.Clear();
                label4.Text = "";
                cbKategoriler.Text = " ";
            }
            else if (rBind2.Checked == true)
            {
                lstTumSiparisler.Items.Add(lstSepet.Items.Count + " ADET ÜRÜN" + a + " " + rBind2.Text);
                lstSepet.Items.Clear();
                lstUrunler.Items.Clear();
                label4.Text = "";
                cbKategoriler.Text = " ";
            }
            else if (rBind3.Checked == true)
            {
                lstTumSiparisler.Items.Add(lstSepet.Items.Count + " ADET ÜRÜN" + a + " " + rBind3.Text);
                lstSepet.Items.Clear();
                lstUrunler.Items.Clear();
                label4.Text = "";
                cbKategoriler.Text = " ";
            }
            else
            {
                MessageBox.Show("Lütfen indirim seçiniz");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lstUrunler.SelectionMode = SelectionMode.One;
            btn3.Visible = false;
            btn4.Visible = false;
            btn1.Visible = true;
            btn2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lstUrunler.SelectionMode = SelectionMode.MultiSimple;
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = true;
            btn4.Visible = true;
        }
    }
}
