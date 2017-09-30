using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace gun25_09_17_WebAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xDoc = new XmlDocument();
        private void Form1_Load(object sender, EventArgs e)
        {

            string url = "http://www.tcmb.gov.tr/kurlar/today.xml";//xml i çekiceğimiz url
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.Default;// dil desteğini default alsın(utf-8 gibi)
            string Xmldata = wc.DownloadString(url);
            xDoc.LoadXml(Xmldata);
            XmlNodeList kurlar = xDoc.DocumentElement.SelectNodes("Currency");//Currency Root olduğu için onu alıyoruz.Ana kök ne ise onu alırız.
            foreach (XmlNode item in kurlar)
            {
                string kurismi = item.SelectSingleNode("CurrencyName").InnerText;
                comboBox1.Items.Add(kurismi);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex!=-1)
            {
                XmlNode secilikur = xDoc.DocumentElement.SelectSingleNode(string.Format("Currency[CurrencyName='{0}']",comboBox1.SelectedItem));
                if (secilikur.SelectSingleNode("BanknoteBuying")==null || secilikur.SelectSingleNode("BanknoteSelling")==null || secilikur==null)
                {
                    return;
                }

                label4.Text = secilikur.SelectSingleNode("Isim").InnerText;
                label5.Text = secilikur.SelectSingleNode("BanknoteBuying").InnerText;
                label6.Text = secilikur.SelectSingleNode("BanknoteSelling").InnerText;
            }
        }
    }
}
