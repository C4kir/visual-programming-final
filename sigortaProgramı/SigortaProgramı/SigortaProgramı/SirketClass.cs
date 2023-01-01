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
    internal class SirketClass
    {
        VeriTabani vt = new VeriTabani();
        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("SELECT * FROM sirket", vt.baglan);
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
        public void sirketEkle(string tur)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("INSERT INTO sirket(sirket_ismi)values(@sirket_ismi)", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sirket_ismi", tur);
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
        public void sirketSil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("DELETE FROM sirket WHERE sirket_id=@sirket_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sirket_id", id);
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
        public void sirketGuncelle(string tur, string id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("UPDATE sirket set sirket_ismi=@sirket_ismi Where sirket_id=@sirket_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sirket_ismi", tur);
                vt.komut.Parameters.AddWithValue("@sirket_id", id);
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
