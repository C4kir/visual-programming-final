using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQL.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SigortaProgramı
{
    internal class KayitClass
    {
        MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=sigortadb;uid=root;Pwd='secret';");
        MySqlCommand komut;
        MySqlDataReader read;
        Form2 anasayfa = new Form2();

        public MySqlDataReader kullanici(TextBox kullaniciadi,TextBox sifre)
        {
            baglanti.Open();
            komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from kayit where kullanici_adi='"+kullaniciadi.Text+"'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (sifre.Text==read["kullanici_sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    anasayfa.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz","Hata1");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz", "Hata2");

            }
            
            baglanti.Close();
            return read;
            
        }
        public void yeniKullanici(TextBox kullanici_adi,TextBox kullanici_sifre,GroupBox grup)
        {
                baglanti.Open();
                komut=new MySqlCommand();
                komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO kayit (kullanici_adi, kullanici_sifre) VALUES ('" + kullanici_adi.Text + "', '" + kullanici_sifre.Text + "')";
            komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Üye Eklendi");
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";

        }
    }
}
