using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm = new Form2();
       
        insan i = new insan();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                i.ad = txtAd.Text;
                i.tel = maskedtxtTel.Text;
                i.Mail = txtMail.Text;
                if (txtMail.Text.Contains("@"))
                {
                    ListViewItem ls = new ListViewItem();
                    ls.Text = i.ad;
                    ls.SubItems.Add(i.tel);
                    ls.SubItems.Add(i.Mail);
                    frm.listView1.Items.Add(ls);
                    frm.Show();
                    txtAd.Clear();
                    txtMail.Clear();
                    maskedtxtTel.Clear();
                }
                else
                {
                    MessageBox.Show("Mail formatı eksik");
                }
                

                //frm.listView1.Columns.Add("columnAd", txtAd.Text);
                //frm.listView1.Columns.Add("columnTel", maskedtxtTel.Text);
                //frm.listView1.Columns.Add("columnMail", txtMail.Text);
             
            }
            catch (Exception)
            {

                MessageBox.Show("Sıkıntı Var");
            }
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frm.listView1.Items.Remove(frm.listView1.Items[0]);
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Bulunamadı");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i.ad = txtAd.Text;
            i.Mail = txtMail.Text;
            i.tel = maskedtxtTel.Text;
           
            ListViewItem c = new ListViewItem();
            c.Text = i.ad;
            c.SubItems.Add(i.tel);
            c.SubItems.Add(i.Mail);
            frm.listView1.Items.Add(c);
            frm.Show();
            //frm.listView1.Items.Remove(frm.listView1.SelectedItems[0]);
            //txtAd.Clear();
            //txtMail.Clear();
            //maskedtxtTel.Clear();
        }
    }
}
