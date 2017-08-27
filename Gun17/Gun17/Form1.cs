using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //public enum Cinsiyet                  // Enumlar
            //{ Erkek,Kadin,ErkekCocuk,KadinCocuk}
            //public enum Malzeme
            //{ Suet, Deri, Rugan, Kumas }
            //public enum Tip
            //{ Spor, Klasik, Kundura, GeceAyakkabi }


            /* Class içerisine class ile aynı adda
             public classismi()
             {
             
             }  COnstructor yapıcı metodu oluyor  */
            araba a = new araba();

            foreach (var i in Enum.GetValues(typeof(araba.yakitTuru)))
            {
                comboBox1.Items.Add(i);
            }

            //comboBox1.DataSource = Enum.GetValues(typeof(Tip));

            a.YakitTuru = araba.yakitTuru.benzin;
            a.ArabaninSinifi = araba.tip.otomobil;
            a.arabaYasi = 15;
            MessageBox.Show("Arabanın Türü "+a.ArabaninSinifi+" Arabanın Yaşı "+a.arabaYasi+" Arabanın yakıt Türü " + a.YakitTuru);

           
        }
    }
}
