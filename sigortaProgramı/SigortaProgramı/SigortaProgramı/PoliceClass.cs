using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySQL.Data;
using MySql.Data.MySqlClient;

namespace SigortaProgramı
{
    internal class PoliceClass
    {
        VeriTabani vt = new VeriTabani();
        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("SELECT * FROM Police", vt.baglan);
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
        public void policeEkle(string adsoyad, string sirket, string turu, string baslangic, string bitis, int fiyat)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("INSERT INTO Police(musteri,sirket_ismi,sigorta_turu,police_baslangic,police_bitis,police_fiyat)values(@musteri,@sirket_ismi,@sigorta_turu,@police_baslangic,@police_bitis,@police_fiyat)", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri", adsoyad);
                vt.komut.Parameters.AddWithValue("@sirket_ismi", sirket);
                vt.komut.Parameters.AddWithValue("@sigorta_turu", turu);
                vt.komut.Parameters.AddWithValue("@police_baslangic", baslangic);
                vt.komut.Parameters.AddWithValue("@police_bitis", bitis);
                vt.komut.Parameters.AddWithValue("@police_fiyat", fiyat);
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
        public void policeiSil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("DELETE FROM Police WHERE police_id=@police_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@police_id", id);
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
        public void policeGuncelle(string adsoyad,string sirket ,string turu, string baslangic, string bitis, int fiyat, int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("UPDATE Police set musteri=@musteri,sirket_ismi=@sirket_ismi,sigorta_turu=@sigorta_turu,police_baslangic=@police_baslangic,police_bitis=@police_bitis,police_fiyat=@police_fiyat Where police_id=@police_id", vt.baglan);

                vt.komut.Parameters.AddWithValue("@musteri", adsoyad);
                vt.komut.Parameters.AddWithValue("@sirket_ismi", sirket);
                vt.komut.Parameters.AddWithValue("@sigorta_turu", turu);
                vt.komut.Parameters.AddWithValue("@police_baslangic", baslangic);
                vt.komut.Parameters.AddWithValue("@police_bitis", bitis);
                vt.komut.Parameters.AddWithValue("@police_fiyat", fiyat);
                vt.komut.Parameters.AddWithValue("@police_id", id);
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
