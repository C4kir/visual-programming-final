using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL.Data;
using MySql.Data.MySqlClient;

namespace SigortaProgramı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            musteri frmmusteri = new musteri();
            
            frmmusteri.Show();
        }

        private void btnEvSigortasi_Click(object sender, EventArgs e)
        {
            sigorta frmsigorta = new sigorta();
            
            frmsigorta.Show();
        }

        private void btnPolice_Click(object sender, EventArgs e)
        {
            police frmpolice = new police();
            
            frmpolice.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDoviz_Click(object sender, EventArgs e)
        {
            doviz frmdoviz = new doviz();

            frmdoviz.Show();
        }

        private void btnSirket_Click(object sender, EventArgs e)
        {
            sirket frmsirket = new sirket();

            frmsirket.Show();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            fiyatHesapla hesapla = new fiyatHesapla();

            hesapla.Show();
        }
    }
}
