﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            if (a=="admin" && b=="admin")
            {
              
                Form2 f2 = new Form2();
                f2.Show();

                this.Hide();
              
                f2.label1.Text ="Hoşgeldiniz "+ a;
            }
            else
            {
                this.Close();
            }

        }
    }
}
