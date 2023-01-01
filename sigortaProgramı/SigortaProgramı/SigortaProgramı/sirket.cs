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
    public partial class sirket : Form
    {
        public sirket()
        {
            InitializeComponent();
        }
        public void veriGoster()
        {
            SirketClass sc = new SirketClass();
            DataTable table = sc.goster();
            dataSirket.DataSource = table;
        }
        public void temizle()
        {
            txtID.Clear();
            txtIsim.Clear();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SirketClass sc = new SirketClass();
            sc.sirketEkle(txtIsim.Text);
            veriGoster();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SirketClass sc = new SirketClass();
            sc.sirketGuncelle(txtIsim.Text, txtID.Text);
            veriGoster();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SirketClass sc = new SirketClass();
            sc.sirketSil(Convert.ToInt32(txtID.Text));
            veriGoster();
            temizle();
        }

        private void dataSirket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataSirket.CurrentRow.Cells[0].Value.ToString();
            txtIsim.Text = dataSirket.CurrentRow.Cells[1].Value.ToString();
        }

        private void sirket_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            label1.Enabled = false;
            veriGoster();
        }

        private void btnSirketAra_Click(object sender, EventArgs e)
        {
            sirketMusteriListele listele = new sirketMusteriListele();

            listele.Show();
        }
    }
}
