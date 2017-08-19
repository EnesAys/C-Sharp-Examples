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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUrunAdi.Items.Clear();
            if (cbUrunKategori.SelectedIndex==0)
            {
                cbUrunAdi.Items.Add("İphone");
                cbUrunAdi.Items.Add("Samsung");
                cbUrunAdi.Items.Add("Nexus");
            }
            else if (cbUrunKategori.SelectedIndex == 1)
            {
                cbUrunAdi.Items.Add("Mac Book");
                cbUrunAdi.Items.Add("Asus");
                cbUrunAdi.Items.Add("Lenovo");
            }
            else if (cbUrunKategori.SelectedIndex == 2)
            {
                cbUrunAdi.Items.Add("Mercedes");
                cbUrunAdi.Items.Add("Honda");
                cbUrunAdi.Items.Add("Ford");
            }
        }

        private void cbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fiyat = 0;
            int stok = 0;
            if (cbUrunKategori.SelectedIndex == 0 && cbUrunAdi.SelectedIndex == 0)
            {
                fiyat = 4000;
                stok = 10;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }
            if (cbUrunKategori.SelectedIndex == 0 && cbUrunAdi.SelectedIndex == 1)
            {
                fiyat = 3000;
                stok = 8;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }
            if (cbUrunKategori.SelectedIndex == 0 && cbUrunAdi.SelectedIndex == 2)
            {
                fiyat = 2000;
                stok = 20;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }
            if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 0)
            {
                fiyat = 6000;
                stok = 5;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }
            if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 1)
            {
                fiyat = 5000;
                stok = 15;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }
            if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 2)
            {
                fiyat = 3000;
                stok = 25;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }
            if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 0)
            {
                fiyat = 500000;
                stok = 3;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }
            if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 1)
            {
                fiyat = 40000;
                stok = 10;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }
            if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 2)
            {
                fiyat = 30000;
                stok = 20;
                label10.Text = stok.ToString();
                txtUrunFiyat.Text = fiyat.ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            lstSepet.Items.Add(cbUrunAdi.Text +" Adet "+txtAdet.Text+" Ödemeniz Gereken Tutar "+ txtToplam.Text);
            lstSepet.Visible = true;
            button2.Enabled = true;
        }
        public void fiyatHesap()
        {
            int fiyat= 0; int stok = 0; int sonFiyat = 0; int topfiyat = 0;
            int adet = Convert.ToInt32(txtAdet.Text);
            int pesinat = Convert.ToInt32(txtPesinat.Text);
            if (cbUrunKategori.SelectedIndex==0)
            {
                switch (cbUrunAdi.SelectedIndex)
                {
                    case 0:
                        fiyat = 4000;
                        stok = 10;
                        break;
                    case 1:
                        fiyat = 3000;
                        stok = 8;
                        break;
                    case 2:
                        fiyat = 2000;
                        stok = 20;
                        break;
                    default:
                        break;
                }
            }
            if (cbUrunKategori.SelectedIndex == 1)
            {
                switch (cbUrunAdi.SelectedIndex)
                {
                    case 0:
                        fiyat = 6000;
                        stok = 5;
                        break;
                    case 1:
                        fiyat = 5000;
                        stok = 15;
                        break;
                    case 2:
                        fiyat = 3000;
                        stok = 25;
                        break;
                    default:
                        break;
                }
            }
            if (cbUrunKategori.SelectedIndex == 2)
            {
                switch (cbUrunAdi.SelectedIndex)
                {
                    case 0:
                        fiyat = 500000;
                        stok = 3;
                        break;
                    case 1:
                        fiyat = 40000;
                        stok = 10;
                        break;
                    case 2:
                        fiyat = 30000;
                        stok = 20;
                        break;
                    default:
                        break;
                }
            }
            topfiyat = adet * fiyat;
            
            sonFiyat = topfiyat - pesinat;
            double aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);
            txtToplam.Text = sonFiyat.ToString();
            txtAylıkTaksit.Text = aylik.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fiyatHesap();
            //int fiyat = 0; int stok = 0;int sonFiyat = 0;int topfiyat = 0;
            //int adet = Convert.ToInt32(txtAdet.Text);
            //int pesinat= Convert.ToInt32(txtPesinat.Text);
           
    
          

            //if (cbUrunKategori.SelectedIndex==0 && cbUrunAdi.SelectedIndex==0)
            //{
            //    fiyat = 4000;
            //    stok = 10;
            //    topfiyat = adet * fiyat;
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);

            //    sonFiyat = topfiyat - pesinat;
             
            //    txtToplam.Text = sonFiyat.ToString();
            //    txtAylıkTaksit.Text = aylik.ToString();
                
            ////}
            //if (cbUrunKategori.SelectedIndex == 0 && cbUrunAdi.SelectedIndex == 1)
            //{
            //    fiyat = 3000;
            //    stok = 8;
            //    topfiyat = adet * fiyat;
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);

            //    sonFiyat = topfiyat - pesinat;
              
          
            //    txtToplam.Text = sonFiyat.ToString();
            //    txtAylıkTaksit.Text = aylik.ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 0 && cbUrunAdi.SelectedIndex == 2)
            //{
            //    fiyat = 2000;
            //    stok = 20;
            //    topfiyat = adet * fiyat;
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);

            //    sonFiyat = topfiyat - pesinat;
           
              
            //    txtToplam.Text = sonFiyat.ToString();
            //    txtAylıkTaksit.Text = aylik.ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 0)
            //{
            //    fiyat = 6000;
            //    stok = 5;
            //    topfiyat = adet * fiyat;
             

            //    sonFiyat = topfiyat - pesinat;
             
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);
            //    txtToplam.Text = sonFiyat.ToString();
            //    txtAylıkTaksit.Text = aylik.ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 1)
            //{
            //    fiyat = 5000;
            //    stok = 15;
            //    topfiyat = adet * fiyat;
              

            //    sonFiyat = topfiyat - pesinat;
              
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);
            //    txtToplam.Text = sonFiyat.ToString();
            //    txtAylıkTaksit.Text = aylik.ToString();
            ////}
            //if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 2)
            //{
            //    fiyat = 3000;
            //    stok = 25;
            //    topfiyat = adet * fiyat;
               

            //    sonFiyat = topfiyat - pesinat;
              
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);
            ////    txtToplam.Text = sonFiyat.ToString();
            ////    txtAylıkTaksit.Text = aylik.ToString();
            ////}
            //if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 0)
            //{
            //    fiyat = 500000;
            //    stok = 3;
            //    topfiyat = adet * fiyat;
               

            //    sonFiyat = topfiyat - pesinat;
             
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);
            //    txtToplam.Text = sonFiyat.ToString();
            //    txtAylıkTaksit.Text = aylik.ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 1)
            //{
            //    fiyat = 40000;
            //    stok = 10;
            //    topfiyat = adet * fiyat;
              

            //    sonFiyat = topfiyat - pesinat;
               
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);
            //    txtToplam.Text = sonFiyat.ToString();
            //    txtAylıkTaksit.Text = aylik.ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 2)
            //{
            //    fiyat = 30000;
            //    stok = 20;
            //    topfiyat = adet * fiyat;
              

            //    sonFiyat = topfiyat - pesinat;
              
            //    int aylik = sonFiyat / Convert.ToInt32(cbTaksit.Text);
            //    txtToplam.Text = sonFiyat.ToString();
            //    txtAylıkTaksit.Text = aylik.ToString();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int stok = 0;
            int adet = Convert.ToInt32(txtAdet.Text);
            if (cbUrunKategori.SelectedIndex == 0)
            {
                switch (cbUrunAdi.SelectedIndex)
                {
                    case 0:
                        stok = 10;
                        break;
                    case 1:
                        stok = 8;
                        break;
                    case 2:
                        stok = 20;
                        break;
                    default:
                        break;
                }

                label10.Text = (stok - adet).ToString();

            }
            if (cbUrunKategori.SelectedIndex == 1)
            {
                switch (cbUrunAdi.SelectedIndex)
                {
                    case 0:
                        stok = 5;
                        break;
                    case 1:
                        stok = 15;
                        break;
                    case 2:
                        stok = 25;
                        break;
                    default:
                        break;
                }

                label10.Text = (stok - adet).ToString();

            }
            if (cbUrunKategori.SelectedIndex == 2)
            {
                switch (cbUrunAdi.SelectedIndex)
                {
                    case 0:
                        stok = 3;
                        break;
                    case 1:
                        stok = 10;
                        break;
                    case 2:
                        stok = 20;
                        break;
                    default:
                        break;
                }

                label10.Text = (stok - adet).ToString();
            }
        }
            //if (cbUrunKategori.SelectedIndex == 0 && cbUrunAdi.SelectedIndex == 1)
            //{

            //    label10.Text = (stok - adet).ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 0 && cbUrunAdi.SelectedIndex == 2)
            //{


            //    label10.Text = (stok - adet).ToString();
            ////}
            //if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 0)
            //{

            //    stok = 5;
            //    label10.Text = (stok - adet).ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 1)
            //{

            //    stok = 15;
            //    label10.Text = (stok - adet).ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 1 && cbUrunAdi.SelectedIndex == 2)
            //{

            //    stok = 25;
            //    label10.Text = (stok - adet).ToString();
            //}


            //}
            //if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 0)
            //{

            //    stok = 3;
            //    label10.Text = (stok - adet).ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 1)
            //{

            //    stok = 10;
            //    label10.Text = (stok - adet).ToString();
            //}
            //if (cbUrunKategori.SelectedIndex == 2 && cbUrunAdi.SelectedIndex == 2)
            //{

            //    stok = 20;
            //    label10.Text = (stok - adet).ToString();
            //}

            //label10.Text = (stok - adet).ToString();
            //}

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
