using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun15_Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
           
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NotHesapla not = new NotHesapla();
            not.Ad = textBox1.Text;
            not.Soyad = textBox2.Text;
            string dersismi = comboBox1.Text;
            not.S1 = Convert.ToInt32(textBox3.Text);
            not.S2 = Convert.ToInt32(textBox4.Text);
            not.Sozlu= Convert.ToInt32(textBox5.Text);
            textBox6.Text = not.Ort.ToString();
            listBox1.Items.Add(not.Ad + " " + not.Soyad + " " + dersismi + " " + not.Ort);

            ListViewItem ListV = new ListViewItem();//Listviem ekleme
            ListV.Text = not.Ad + " " + not.Soyad;//bu kural 1.sutun ve 1.satır eklenceği zaman gereklidir.
            ListV.SubItems.Add(dersismi);
            ListV.SubItems.Add(not.Ort.ToString());
            //ListV.ImageKey = "ikon1";//resim eklemek için bu kod
            listView1.Items.Add(ListV);
        
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayac = listView1.Items.Count;
            MessageBox.Show(sayac.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i <= listView1.SelectedItems.Count; i++) //---- for la silme
            //{
            //    listView1.Items.Remove(listView1.SelectedItems[0]);

            //}
            foreach (ListViewItem b in listView1.SelectedItems)//---- foreach ile silme
            {
                b.Remove();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //resim ekleme
            //ImageList imageList1 = new ImageList();

            //// Resimleri ekle
            //imageList1.Images.Add("ikon1", Image.FromFile("C:\\Users\\Wissen\\Documents\\Visual Studio 2015\\Projects\\Enesays\\Gun15-Class\\Gun15-Class\\ikon1.jpg"));

            // listView1.SmallImageList = imageList1;

        }
    }
}

