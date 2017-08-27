using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
      {
            //    Kedi k = new Kedi();
            //    k.ad = "Lokum";
            //    k.kilo = 300;
            //    k.Yas = 1;
            //    k.sokakKedisimi = true;
            //    MessageBox.Show(k.ad+" "+k.kilo+" "+k.Yas+" "+k.sokakKedisimi+k.SesCikar());
            Besiktas bjk = new Besiktas();
            bjk.ad = "Beşiktaş Jimnastik Kulübü";
            bjk.Simge = "Kartal";
            bjk.taraftarSayisi = 42000;
            MessageBox.Show(bjk.ad + " " + bjk.Simge + " " + bjk.taraftarSayisi + " " + bjk.Tezahurat());

            // ctrl+alt+space ile yardım kapatılabilir.

            trabzon tr = new trabzon();
            tr.ad = "Trabzonspor";
            tr.Simge = "Hamsi";
            tr.taraftarSayisi = 20000;
            MessageBox.Show(tr.ad + " " + tr.Simge + " " + tr.taraftarSayisi + " " + tr.Tezahurat());


        }
    }
}
