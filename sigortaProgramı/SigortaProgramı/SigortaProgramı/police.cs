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
    public partial class police : Form
    {
        VeriTabani vt = new VeriTabani();
        public police()
        {
            InitializeComponent();
        }
        public void veriGoster()
        {
            PoliceClass pc = new PoliceClass();
            DataTable table = pc.goster();
            dataPolice.DataSource = table;
        }
        public void Temizle()
        {
            txtID.Clear();
            txtBaslangic.Clear();
            txtBitis.Clear();
            txtFiyat.Clear();
        }


        public void comboMusteriListele()
        {
            vt.BaglantiAc();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM musteri ", vt.baglan);
            MySqlDataReader dr;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboMusteri.Items.Add(dr["musteri_adsoyad"]);
            }
            vt.BaglantiKapat();
        }

        public void comboTurListele()
        {
            vt.BaglantiAc();
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM sigorta ", vt.baglan);
            MySqlDataReader dr2;

            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboTur.Items.Add(dr2["sigorta_turu"]);
            }
            vt.BaglantiKapat();
        }

        public void comboSirketListele()
        {
            vt.BaglantiAc();
            MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM sirket ", vt.baglan);
            MySqlDataReader dr3;

            dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboSirket.Items.Add(dr3["sirket_ismi"]);
            }
            vt.BaglantiKapat();
        }

        private void police_Load(object sender, EventArgs e)
        {
            veriGoster();
            
            txtID.Enabled = false;
            label6.Enabled = false;
            
            comboTurListele();
            comboMusteriListele();
            comboSirketListele();

            vt.BaglantiAc();
            if (vt.baglan.State == ConnectionState.Open)
            {
                // SQL sorgusunu çalıştırın
                string sorgu = "SELECT sigorta_turu, COUNT(sigorta_turu) as sayi FROM police GROUP BY sigorta_turu ORDER BY sayi DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sorgu, vt.baglan);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblEnCok.Text = dr["sigorta_turu"].ToString();
                }
            }
            else
            {
                // Bağlantı açık değilse uygun bir hata mesajı gösterin
                MessageBox.Show("Veritabanı Açık Değil");
            }
            vt.BaglantiKapat();
            vt.BaglantiAc();
            if (vt.baglan.State == ConnectionState.Open)
            {
                // SQL sorgusunu çalıştırın
                string sorgu = "SELECT sirket_ismi, COUNT(sirket_ismi) as sayi FROM police GROUP BY sirket_ismi ORDER BY sayi DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sorgu, vt.baglan);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblEnCok2.Text = dr["sirket_ismi"].ToString();
                }
            }
            else
            {
                // Bağlantı açık değilse uygun bir hata mesajı gösterin
                MessageBox.Show("Veritabanı Açık Değil");
            }
            vt.BaglantiKapat();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                PoliceClass pc = new PoliceClass();




                pc.policeEkle(comboMusteri.Items[comboMusteri.SelectedIndex].ToString(), comboSirket.Items[comboSirket.SelectedIndex].ToString(), comboTur.Items[comboTur.SelectedIndex].ToString(), txtBaslangic.Text, txtBitis.Text, Convert.ToInt32(txtFiyat.Text));
                veriGoster();
                Temizle();
            }
            catch (Exception hata)
            {
                MessageBox.Show(""+hata);
                throw;
            }
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PoliceClass pc = new PoliceClass();
            pc.policeGuncelle(comboMusteri.SelectedValue.ToString(), comboSirket.SelectedValue.ToString(), comboTur.SelectedValue.ToString(), txtBaslangic.Text, txtBitis.Text, Convert.ToInt32(txtFiyat.Text), Convert.ToInt32(txtID.Text));
            veriGoster();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PoliceClass pc = new PoliceClass();
            pc.policeiSil(Convert.ToInt32(txtID.Text));
            veriGoster();
            Temizle();
        }

        private void dataPolice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataPolice.CurrentRow.Cells[0].Value.ToString();
            comboMusteri.SelectedValue = dataPolice.CurrentRow.Cells[1].Value.ToString();
            comboTur.SelectedValue = dataPolice.CurrentRow.Cells[2].Value.ToString();
            txtBaslangic.Text = dataPolice.CurrentRow.Cells[3].Value.ToString();
            txtBitis.Text = dataPolice.CurrentRow.Cells[4].Value.ToString();
            txtFiyat.Text = dataPolice.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataPolice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            policeListele listele = new policeListele();

            listele.Show();
        }
    }
}
