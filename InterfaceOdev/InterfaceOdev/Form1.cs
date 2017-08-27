using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceOdevLIB;

namespace InterfaceOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbPozisyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbKaleci.Visible = false;
            pbOyuncu.Visible = false;
            groupBox1.Visible = false;
            switch (cbPozisyon.SelectedIndex)
            {
                case 0:
                    groupBox1.Visible = true;
                    pbKaleci.Visible = true;
                    break;
                case 1:
                    pbOyuncu.Visible = true;
                    break;
                default:
                    break;
            }
        }
        kaleci k = new kaleci();
        oyuncu o = new oyuncu();
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbPozisyon.Text !="" && txtAd.Text != "" && txtSoyad.Text != "")
            {
                switch (cbPozisyon.SelectedIndex)
                {
                    case 0:
                        k.ad = txtAd.Text;
                        k.soyad = txtSoyad.Text;
                        k.mevki = cbPozisyon.Text;
                        if (radioButton1.Checked==true || radioButton4.Checked==true)
                        {
                            k.elizin = true;
                            lblYazi.Text = k.elleTut();
                        }
                        else
                        {
                            k.elizin = false;
                            lblYazi.Text = k.elleTut();
                        }

                        break;
                    case 1:
                        o.ad = txtAd.Text;
                        o.soyad = txtSoyad.Text;
                        o.mevki = cbPozisyon.Text;
                        lblYazi.Text = o.elleTut();
                        lblYazi.Visible = true;
                        break;
                    default:
                        break;
                }



            }
            else
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz");
            }
        }
    }
}
