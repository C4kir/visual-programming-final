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
    public partial class policeListele : Form
    {
        public policeListele()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=sigortadb;uid=root;Pwd='secret';");
        DataSet daset = new DataSet();

        private void policeListele_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }
        private void Kayit_Goster()
        {
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from police", baglanti);
            adtr.Fill(daset, "police");
            dataGridView1.DataSource = daset.Tables["police"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
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

        private void txtPoliceIDAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from police where police_id like '%" + txtPoliceIDAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
