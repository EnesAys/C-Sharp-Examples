using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gun22LİB;


namespace Gun22
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbBatman.Visible = false;
            pbSpiderman.Visible = false;
            pbSuperman.Visible = false;
            groupBox1.Visible = false;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pbSuperman.Visible = true;
                    groupBox1.Visible = true;
                    break;
                case 1:
                    pbBatman.Visible = true;
                    break;
                case 2:
                    pbSpiderman.Visible = true;
                    break;
                default:
                    MessageBox.Show("Doğru Bir Seçim yapın");
                    break;
            }
        }

        SuperMan sp = new SuperMan();
        Spiderman OA = new Spiderman();
        Batman ba = new Batman();
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (radioButton1.Checked==true)
                    {
                        sp.AD = "Clark Kent";
                        label2.Text = "Clark Kent haliyle uçamaz";
                        label2.Visible = true;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        sp.AD = "Superman";
                        sp.ucarmi = true;
                        label2.Text = sp.Ucur();
                        label2.Visible = true;
                    }
                 
                    break;
                case 1:
                    ba.AD = "Bruce Wayne";
                    label2.Text="Bruce Wayne uçamaz yada ağ atamaz fakat büyük bir kahramandır";
                    break;
                case 2:
                    OA.AD = "Spiderman";
                    OA.AgAtarmi = true;
                    label2.Text = OA.Ucur();
                    label2.Visible = true;
                    break;
                default:
                    MessageBox.Show("Doğru Bir Seçim yapın");
                    break;
            }

        }
    }
}
