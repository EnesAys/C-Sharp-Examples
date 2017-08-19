using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelismisPizzaSiparis_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KarisikPizza KP = new KarisikPizza();
        SosyalPizza SP = new SosyalPizza();
        Mangal MP = new Mangal();
        AciliPizza AP = new AciliPizza();
        private void Form1_Load(object sender, EventArgs e)
        {
            rbKarisik.Text = KP.ad;
            rbSosyal.Text = SP.ad;
            rbMangal.Text = MP.ad;
            rbAcili.Text = AP.ad;

        }
        public void cbTemizle()
        {
            cbBiber.Checked = false;
            cbDomates.Checked = false;
            cbMantar.Checked = false;
            cbMisir.Checked = false;
            cbPeynir.Checked = false;
            cbSalam.Checked = false;
            cbSucuk.Checked = false;
            cbZeytin.Checked = false;

        }
        public void pbSakla()
        {
            pbAcili.Visible = false;
            pbKarisik.Visible = false;
            pbMangal.Visible = false;
            pbSosyal.Visible = false;
            pbCash.Visible = false;
            pbKart.Visible = false;

        }
        private void rbKarisik_CheckedChanged(object sender, EventArgs e)
        {
            cbTemizle();
            pbSakla();
            groupBox1.Enabled = true;
            pbKarisik.Visible = true;
            cbBiber.Checked = true;
            cbDomates.Checked = true;
            cbMantar.Checked = true;
            cbZeytin.Checked = true;
        }

        private void rbSosyal_CheckedChanged(object sender, EventArgs e)
        {
            cbTemizle();
            pbSakla();
            groupBox1.Enabled = true;
            pbSosyal.Visible = true;
            cbBiber.Checked = true;
            cbSalam.Checked = true;
            cbMisir.Checked = true;
            cbZeytin.Checked = true;
        }

        private void rbMangal_CheckedChanged(object sender, EventArgs e)
        {
            cbTemizle();
            pbSakla();
            groupBox1.Enabled = true;
            pbMangal.Visible = true;
            cbSalam.Checked = true;
            cbSucuk.Checked = true;
            cbMantar.Checked = true;
            cbZeytin.Checked = true;
        }

        private void rbAcili_CheckedChanged(object sender, EventArgs e)
        {
            cbTemizle();
            pbSakla();
            groupBox1.Enabled = true;
            pbAcili.Visible = true;
            cbPeynir.Checked = true;
            cbMisir.Checked = true;
            cbMantar.Checked = true;
            cbZeytin.Checked = true;
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (txtAd.Text==""||txtSoyad.Text==""||txtAdres.Text=="")
            {
                MessageBox.Show("Alanları Boş Geçmeyiniz");
            }
            else
            {
                int sayac = 0;
                pbSakla();
                lstEkstralar.Items.Clear();
                try
                {
                    foreach (Control c in groupBox1.Controls)
                    {

                        if (c is CheckBox && ((CheckBox)c).Checked == true)
                        {
                            lstEkstralar.Items.Add(((CheckBox)c).Text.ToString());
                            sayac++;
                        }
                    }
                    if (rbNakit.Checked == true)
                    {
                        pbCash.Visible = true;
                        
                    }
                    else
                    {
                        pbKart.Visible = true;
                        sayac += 5;//Kart ile ödemelerde 5 lira eklesin
                    }

                    lblAd.Text = txtAd.Text;
                    lblAdres.Text = txtAdres.Text;
                    lblSoyad.Text = txtSoyad.Text;
                    
                    if (rbKarisik.Checked == true)
                    {
                        lblPizzaTur.Text = KP.ad;
                        lblTutar.Text =((sayac-3)+ KP.fiyat).ToString();
                    }
                    else if (rbSosyal.Checked==true)
                    {
                        lblPizzaTur.Text = SP.ad;
                        lblTutar.Text = ((sayac - 3) + SP.fiyat).ToString();
                    }
                    else if (rbMangal.Checked==true)
                    {
                        lblPizzaTur.Text = MP.ad;
                        lblTutar.Text = ((sayac - 3) + MP.fiyat).ToString();
                    }
                    else 
                    {
                        lblPizzaTur.Text = AP.ad;
                        lblTutar.Text = ((sayac - 3) + AP.fiyat).ToString();
                    }
                  
                    
                    tabControl1.SelectedIndex = 2;//Tab Page Arası Geçiş
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen ALanları eksiksiz biçimde doldurunuz");
                }
            }
           
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//AD textboxına sadece harf girilsin
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)//Soyad textboxına sadece harf girilsin
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
