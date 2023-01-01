using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SigortaProgramı
{
    public partial class sigortaMusteriListele : Form
    {
        public sigortaMusteriListele()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=sigortadb;uid=root;Pwd='secret';");
        DataSet daset = new DataSet();

        private void Kayit_Goster()
        {
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from police", baglanti);
            adtr.Fill(daset, "police");
            dataGridView1.DataSource = daset.Tables["police"];
            baglanti.Close();
        }
        private void sigortaMusteriListele_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
            label1.Enabled = false;
            label2.Enabled = false;
            label8.Enabled = false;
            label3.Enabled = false;
            label5.Enabled = false;
            label7.Enabled = false;

            txtAdSoyad.Enabled = false;
            txtFiyat.Enabled = false;
            txtPoliceBaslangic.Enabled = false;
            txtPoliceBitis.Enabled = false;
            txtPoliceID.Enabled = false;
            txtSirketIsmi.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from musteri where police_id='" + dataGridView1.CurrentRow.Cells["police_id"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["police"].Clear();
            Kayit_Goster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPoliceID.Text = dataGridView1.CurrentRow.Cells["police_id"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["musteri"].Value.ToString();
            txtSirketIsmi.Text = dataGridView1.CurrentRow.Cells["sirket_ismi"].Value.ToString();
            txtSigortaTuru.Text = dataGridView1.CurrentRow.Cells["sigorta_turu"].Value.ToString();
            txtPoliceBaslangic.Text = dataGridView1.CurrentRow.Cells["police_baslangic"].Value.ToString();
            txtPoliceBitis.Text = dataGridView1.CurrentRow.Cells["police_bitis"].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells["police_fiyat"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("update police set musteri=@musteri,sirket_ismi=@sirket_ismi,sigorta_turu=@sigorta_turu,police_baslangic=@police_baslangic,police_bitis=@police_bitis,police_fiyat=@police_fiyat where police_id=@police_id", baglanti);
            komut.Parameters.AddWithValue("@police_id", txtPoliceID.Text);
            komut.Parameters.AddWithValue("@musteri", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@sirket_ismi", txtSirketIsmi.Text);
            komut.Parameters.AddWithValue("@sigorta_turu", txtSigortaTuru.Text);
            komut.Parameters.AddWithValue("@police_baslangic", txtPoliceBaslangic.Text);
            komut.Parameters.AddWithValue("@police_bitis", txtPoliceBitis.Text);
            komut.Parameters.AddWithValue("@police_fiyat", txtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["police"].Clear();
            Kayit_Goster();
            MessageBox.Show("Poliçe Kaydı Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtSigortaAdi_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from police where sigorta_turu like '%" + txtSigortaAdi.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
