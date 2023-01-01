using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigortaProgramı
{
    public partial class fiyatHesapla : Form
    {
        public fiyatHesapla()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem.ToString() == "Ocak" || comboBox1.SelectedItem.ToString() == "Şubat" || comboBox1.SelectedItem.ToString() == "Mart")
            {
                if (comboBox2.SelectedItem.ToString() == "Taksi" || comboBox2.SelectedItem.ToString() == "Minibüs")
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "500₺";
                    }
                    else
                    {
                        label5.Text = "650₺";
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "Otomobil")
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "300₺";
                    }
                    else
                    {
                        label5.Text = "450₺";
                    }
                }
                else
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "800₺";
                    }
                    else
                    {
                        label5.Text = "950₺";
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Nisan" || comboBox1.SelectedItem.ToString() == "Mayıs" || comboBox1.SelectedItem.ToString() == "Haziran")
            {
                if (comboBox2.SelectedItem.ToString() == "Taksi" || comboBox2.SelectedItem.ToString() == "Minibüs")
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "600₺";
                    }
                    else
                    {
                        label5.Text = "700₺";
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "Otomobil")
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "400₺";
                    }
                    else
                    {
                        label5.Text = "550₺";
                    }
                }
                else
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "800₺";
                    }
                    else
                    {
                        label5.Text = "950₺";
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Temmuz" || comboBox1.SelectedItem.ToString() == "Ağustos" || comboBox1.SelectedItem.ToString() == "Eylül")
            {
                if (comboBox2.SelectedItem.ToString() == "Taksi" || comboBox2.SelectedItem.ToString() == "Minibüs")
                {
                    if (comboBox3.SelectedIndex.ToString() == "Özel")
                    {
                        label5.Text = "550₺";
                    }
                    else
                    {
                        label5.Text = "700₺";
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "Otomobil")
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "350₺";
                    }
                    else
                    {
                        label5.Text = "500₺";
                    }
                }
                else
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "850₺";
                    }
                    else
                    {
                        label5.Text = "1000₺";
                    }
                }
            }
            else if(comboBox1.SelectedItem.ToString() == "Ekim" || comboBox1.SelectedItem.ToString() == "Kasım" || comboBox1.SelectedItem.ToString() == "Aralık")
            {
                if (comboBox2.SelectedItem.ToString() == "Taksi" || comboBox2.SelectedItem.ToString() == "Minibüs")
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "350₺";
                    }
                    else
                    {
                        label5.Text = "450₺";
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "Otomobil")
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "200₺";
                    }
                    else
                    {
                        label5.Text = "350₺";
                    }
                }
                else
                {
                    if (comboBox3.SelectedItem.ToString() == "Özel")
                    {
                        label5.Text = "700₺";
                    }
                    else
                    {
                        label5.Text = "850₺";
                    }
                }
            }
        }

        private void fiyatHesapla_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
