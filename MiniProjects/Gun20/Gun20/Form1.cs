using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.Value = DateTime.Now;
                }

            }



        }
        Personel p = new Personel();
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            p.TC = txtTC.Text;
            p.ad = txtAd.Text ;
            p.soyad = txtSoyad.Text;
            p.isegirisTarih = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            p.Tel = maskedTextBox1.Text;
            p.Mail = txtMail.Text;
            string[] yazilacak = { p.TC,p.ad,p.soyad,p.isegirisTarih.ToString(),p.Tel,p.Mail};
            ListViewItem ls = new ListViewItem(yazilacak);  
            ls.Tag = p;
            listView1.Items.Add(ls);
            temizle();
            maskedTextBox1.Clear();
        }

        Personel guncelP;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                guncelP = (Personel)listView1.SelectedItems[0].Tag;
                txtTC.Text = guncelP.TC;
                txtAd.Text = guncelP.ad;
                txtSoyad.Text = guncelP.soyad;
                dateTimePicker2.Value = guncelP.isegirisTarih;
                maskedTextBox1.Text = guncelP.Tel;
                txtMail.Text = guncelP.Mail;
            }
            else
            {
                MessageBox.Show("Seçili İtem bulunmuyor");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.TC = txtTC.Text;
            p.ad = txtAd.Text;
            p.soyad = txtSoyad.Text;
            p.isegirisTarih = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            p.Tel = maskedTextBox1.Text;
            p.Mail = txtMail.Text;
            string[] guncel = { p.TC, p.ad, p.soyad, p.isegirisTarih.ToString(),p.Tel, p.Mail };
            ListViewItem lsnew = new ListViewItem(guncel);
            lsnew.Tag = guncelP;
            int yeni = listView1.SelectedItems[0].Index;
            listView1.Items.RemoveAt(yeni);
            listView1.Items.Insert(yeni,lsnew);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
            maskedTextBox1.Clear();
            listView1.Items.Clear();
        }
    }
}
