using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun9_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int not1, not2;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                not1 = Convert.ToInt32(textBox4.Text);
                not2 = Convert.ToInt32(textBox5.Text);
                string ad = textBox1.Text;
                string tc = textBox2.Text;
                string okulNo = textBox3.Text;

                throw new Exception();

            }
            catch (Exception)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Ad kısmı boş geçilemez");
                }
                if (textBox2.Text == "" || textBox2.TextLength!=11)
                {
                    MessageBox.Show("TC kısmı boş geçilemez ve 11 haneli olmalı");
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Okul No kısmı boş geçilemez");
                }
               if (textBox4.Text == "")
                {
                        MessageBox.Show("No kısmı boş geçilemez");
                }
                if (textBox5.Text == "")
                {
                    MessageBox.Show("No kısmı boş geçilemez");
                }

            }
            if (not1 == 0 || not2 == 0 || not1 < 0 || not1 > 100 || not2 < 0 || not2 > 100)
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen notlarınızı doğru formatta giriniz");
                }
            }
            textBox6.Text = ((not1 + not2) / 2).ToString();
        }
    }
}
