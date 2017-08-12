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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            try
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                label1.Text = (sayi1 + sayi2).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("sayı girinizz");
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("sayı alanına sayıdan başka bir tür girilemez yada boş bırakılamaz");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            try
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                label1.Text = (sayi1 - sayi2).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("sayı girinizz");
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("sayı alanına sayıdan başka bir tür girilemez yada boş bırakılamaz");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            try
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                label1.Text = (sayi1 / sayi2).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("sayı girinizz");
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("sayı alanına sayıdan başka bir tür girilemez yada boş bırakılamaz");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            try
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                label1.Text = (sayi1 * sayi2).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("sayı girinizz");
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("sayı alanına sayıdan başka bir tür girilemez yada boş bırakılamaz");
                }
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
    }

