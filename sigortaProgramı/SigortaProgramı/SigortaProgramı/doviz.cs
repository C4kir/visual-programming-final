using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SigortaProgramı
{
    public partial class doviz : Form
    {
        public doviz()
        {
            InitializeComponent();
        }

        private void doviz_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            label1.Text = string.Format("Tarih {0} USD Satış; {1}", tarih.ToShortDateString(), USD);

            string USD2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteBuying").InnerXml;
            label2.Text = string.Format("Tarih {0} USD Alış; {1}", tarih.ToShortDateString(), USD2);

            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            label3.Text = string.Format("Tarih {0} EURO Satış; {1}", tarih.ToShortDateString(), EURO);

            string EURO2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteBuying").InnerXml;
            label4.Text = string.Format("Tarih {0} EURO Alış; {1}", tarih.ToShortDateString(), EURO2);

            string GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            label5.Text = string.Format("Tarih {0} GBP Satış; {1}", tarih.ToShortDateString(), GBP);

            string GBP2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteBuying").InnerXml;
            label6.Text = string.Format("Tarih {0} GBP Alış; {1}", tarih.ToShortDateString(), GBP2);

            string AZN = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/BanknoteSelling").InnerXml;
            label7.Text = string.Format("Tarih {0} AZN Satış; {1}", tarih.ToShortDateString(), AZN);

            string AZN2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/BanknoteBuying").InnerXml;
            label8.Text = string.Format("Tarih {0} AZN Alış; {1}", tarih.ToShortDateString(), AZN2);


        }

        private void btnDoviz_Click(object sender, EventArgs e)
        {
            
        }
    }
}
