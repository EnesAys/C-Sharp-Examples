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

namespace gun26_09_17_YoutubeApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                string link = listView1.SelectedItems[0].SubItems[1].Text;//Linki seçtirdik
                System.Diagnostics.Process.Start(link);// Linki açmasını sağladık.
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string url = string.Format("https://www.youtube.com/feeds/videos.xml?channel_id=UCi4_FLeTvoNs8cgV2cTBSWQ");
            WebClient wc = new WebClient();//WebClient oluşturularak linkdeki xml dosyanını içerisine bilgileri indirdik 
            string XmlData = wc.DownloadString(url);
            XmlDocument xDoc = new XmlDocument();//xml içerisine bilgileri yükledik
            xDoc.LoadXml(XmlData);
            XmlNodeList girisler = xDoc.DocumentElement.GetElementsByTagName("entry");// hangi taglar arasında arayacağı
            foreach (XmlNode item in girisler)
            {
                string title = item.ChildNodes[3].InnerText;

                if (!string.IsNullOrEmpty(title) && title.ToLower().Contains(textBox1.Text.ToLower()))// title ve textbox kıs-
                //mını tolover ile eşitledik  ve title contins içerisinde textbox texti varmı diye bakıyoruz.
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = title;
                    lv.SubItems.Add(item.ChildNodes[4].Attributes["href"].InnerText);
                    listView1.Items.Add(lv);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string url = string.Format("https://www.youtube.com/feeds/videos.xml?channel_id=UCi4_FLeTvoNs8cgV2cTBSWQ");
            WebClient wc = new WebClient();//WebClient oluşturularak linkdeki xml dosyanını içerisine bilgileri indirdik 
            string XmlData = wc.DownloadString(url);
            XmlDocument xDoc = new XmlDocument();//xml içerisine bilgileri yükledik
            xDoc.LoadXml(XmlData);
            XmlNodeList girisler = xDoc.DocumentElement.GetElementsByTagName("entry");// hangi taglar arasında arayacağı
            foreach (XmlNode item in girisler)
            {
                string title = item.ChildNodes[3].InnerText;

                if (!string.IsNullOrEmpty(title))// t
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = title;
                    lv.SubItems.Add(item.ChildNodes[4].Attributes["href"].InnerText);
                    listView1.Items.Add(lv);
                }

            }
        }
    }

}
