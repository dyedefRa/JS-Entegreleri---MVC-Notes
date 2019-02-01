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

namespace YahooApi_KonumBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader okuyucu = new XmlTextReader("http://ip-api.com/xml");
            while(okuyucu.Read())
            {
                if (okuyucu.NodeType==XmlNodeType.Element)
                {
                    if (okuyucu.Name=="lat")
                    {
                        okuyucu.Read();
                        textBox2.Text = okuyucu.Value.ToString();
                    }
                    if (okuyucu.Name=="lon")
                    {
                        okuyucu.Read();
                        textBox3.Text = okuyucu.Value.ToString();
                    }
                    if (okuyucu.Name== "city")
                    {
                        okuyucu.Read();
                        textBox4.Text = okuyucu.Value.ToString();
                    }
                }
            }
            okuyucu.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adres = $"https://geocode-maps.yandex.ru/1.x/?geocode={textBox4.Text}&ll={textBox2.Text},{textBox3.Text}&spn=2.5,2.5&lang=en-US";

            XmlTextReader okuyucu = new XmlTextReader(adres);
            while (okuyucu.Read())
            {
                if (okuyucu.NodeType == XmlNodeType.Element)
                {
                    if (okuyucu.Name == "AddressLine")
                    {
                        okuyucu.Read();
                        textBox1.Text = okuyucu.Value.ToString();
                    }
                   
                }
            }
            okuyucu.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = GetIp();
        }

        public string GetIp()
        {
            var strHostName = "";
            strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            var addr = ipEntry.AddressList;
            return addr[2].ToString();
        }
    }
}
