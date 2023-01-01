using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SigortaProgramı
{
    internal class MusteriClass
    {
        VeriTabani vt = new VeriTabani();
        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("SELECT * FROM Musteri", vt.baglan);
                vt.okuyucu = vt.komut.ExecuteReader();
                DataTable tablo = new DataTable();
                tablo.Load(vt.okuyucu);

                vt.BaglantiKapat();

                return tablo;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }

        }
        public void musteriEkle(string adsoyad, string tel, string adres)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("INSERT INTO Musteri(musteri_adsoyad,musteri_tel,musteri_adres)values(@musteri_adsoyad,@musteri_tel,@musteri_adres)", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri_adsoyad", adsoyad);
                vt.komut.Parameters.AddWithValue("@musteri_tel", tel);
                vt.komut.Parameters.AddWithValue("@musteri_adres", adres);
                vt.komut.ExecuteNonQuery();

                vt.BaglantiKapat();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Kayıt İşlemi Başarılı");
            }
        }
        public void musteriSil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("DELETE FROM Musteri WHERE musteri_id=@musteri_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri_id", id);
                vt.komut.ExecuteNonQuery();

                vt.BaglantiKapat();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Silme İşlemi Başarılı");
            }

        }
        public void musteriGuncelle(string adsoyad, string tel, string adres, string id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("UPDATE Musteri set musteri_adsoyad=@musteri_adsoyad,musteri_tel=@musteri_tel,musteri_adres=@musteri_adres Where musteri_id=@musteri_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri_adsoyad", adsoyad);
                vt.komut.Parameters.AddWithValue("@musteri_tel", tel);
                vt.komut.Parameters.AddWithValue("@musteri_adres", adres);
                vt.komut.Parameters.AddWithValue("@musteri_id", id);
                vt.komut.ExecuteNonQuery();

                vt.BaglantiKapat();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Güncelleme İşlemi Başarılı");
            }

        }
    }
}
