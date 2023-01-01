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
    public partial class musteriListele : Form
    {
        public musteriListele()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=sigortadb;uid=root;Pwd='secret';");
        DataSet daset = new DataSet();

        private void musteriListele_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
            txtID.Enabled = false;
            label1.Enabled = false;
        }
        private void Kayit_Goster()
        {
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from musteri", baglanti);
            adtr.Fill(daset, "musteri");
            dataGridView1.DataSource = daset.Tables["musteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["musteri_id"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["musteri_adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["musteri_tel"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["musteri_adres"].Value.ToString();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("update musteri set musteri_adsoyad=@musteri_adsoyad,musteri_tel=@musteri_tel,musteri_adres=@musteri_adres where musteri_id=@musteri_id", baglanti);
            komut.Parameters.AddWithValue("@musteri_id", txtID.Text);
            komut.Parameters.AddWithValue("@musteri_adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@musteri_tel", txtTelefon.Text);
            komut.Parameters.AddWithValue("@musteri_adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Müşteri Kaydı Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from musteri where musteri_id='" + dataGridView1.CurrentRow.Cells["musteri_id"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtIDAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from musteri where musteri_tel like '%" + txtTelAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
