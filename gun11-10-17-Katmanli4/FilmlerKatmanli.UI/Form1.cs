using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmlerKatmanli.BLL;

namespace FilmlerKatmanli.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilmRepository frepo = new FilmRepository();
        Yonetmen_Repo yrepo = new Yonetmen_Repo();
        private void getir()
        {
            comboBox1.DataSource = yrepo.SelectYonetmen();
            comboBox1.DisplayMember = "YonetmenAdi";
            comboBox1.ValueMember = "YonetmenID";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int secili =(int) comboBox1.SelectedValue;
            listBox1.DataSource = frepo.SelectFilm(secili);
            listBox1.DisplayMember = "FilmAdi";
            listBox1.ValueMember = "FilmID";
        }
    }
}
