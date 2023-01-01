using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SigortaProgramı
{
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }
        public void veriGoster()
        {
            MusteriClass mc = new MusteriClass();
            DataTable table = mc.goster();
            dataMusteri.DataSource = table;
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            veriGoster();
            txtID.Enabled = false;
            label5.Enabled = false;
        }

        public void temizle()
        {
            txtID.Clear();
            txtMusteri.Clear();
            txtMusteriTel.Clear();
            txtMusteriAdres.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriClass mc = new MusteriClass();
            mc.musteriEkle(txtMusteri.Text, txtMusteriTel.Text, txtMusteriAdres.Text);
            veriGoster();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriClass mc = new MusteriClass();
            mc.musteriSil(Convert.ToInt32(txtID.Text));
            veriGoster();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MusteriClass mc = new MusteriClass();
            mc.musteriGuncelle(txtMusteri.Text, txtMusteriTel.Text, txtMusteriAdres.Text, Convert.ToString(txtID.Text));
            veriGoster();
            temizle();
        }

        private void dataMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataMusteri.CurrentRow.Cells[0].Value.ToString();
            txtMusteri.Text = dataMusteri.CurrentRow.Cells[1].Value.ToString();
            txtMusteriTel.Text = dataMusteri.CurrentRow.Cells[2].Value.ToString();
            txtMusteriAdres.Text = dataMusteri.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtMusteriTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            musteriListele musterilistele = new musteriListele();

            musterilistele.Show();
        }
    }
}
