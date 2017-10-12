using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.BLL.Repository;
using Northwind.DAL;
     

namespace Northwind.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ShipperRepository srepo = new ShipperRepository();
        private void getir()
        {
            dataGridView1.DataSource = srepo.SelectAll();

        }
        private void temizle(Control.ControlCollection koleksiyon)// Başka bir grupbox eklenmesine karşın koleksiyon ismini verdik parametre olarak 
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    temizle(gb.Controls);
                }       
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                getir();
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt bulunamadı");
            }
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int seciliid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Shipper s = srepo.SelectByID(seciliid);
                textBox2.Text = s.CompanyName;
                textBox3.Text = s.Phone;
            }
            catch (Exception)
            {

                MessageBox.Show("Seçim doğru şekilde yapılamadı");
            }
          
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int seciliid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                srepo.Delete(seciliid);
                getir();
            }
            catch (Exception)
            {

                MessageBox.Show("Silinemedi");
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
             
                MessageBox.Show("Alanları boş bırakmayınız");
            }
            else
            {
                Shipper s = new Shipper();
                s.CompanyName = textBox2.Text;
                s.Phone = textBox3.Text;
                srepo.Insert(s);
                getir();
                temizle(this.Controls);// içerisine argumen olarak vermek gerekir. Recrusieve Function
            }
          
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count<0)
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
            else
            {
                int seciliid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Shipper s = srepo.SelectByID(seciliid);
                s.CompanyName = textBox2.Text;
                s.Phone = textBox3.Text;
                srepo.Update(s);
                getir();
            }
                    
            
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = srepo.getir(textBox1.Text);
        }
    }
}
