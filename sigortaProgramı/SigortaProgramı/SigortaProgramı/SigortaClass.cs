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
    internal class SigortaClass
    {
        VeriTabani vt = new VeriTabani();
        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("SELECT * FROM Sigorta", vt.baglan);
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
        public void sigortaEkle(string tur)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("INSERT INTO Sigorta(sigorta_turu)values(@sigorta_turu)", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sigorta_turu", tur);
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
        public void sigortaSil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("DELETE FROM Sigorta WHERE sigorta_id=@sigorta_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sigorta_id", id);
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
        public void sigortaGuncelle(string tur, string id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new MySqlCommand("UPDATE Sigorta set sigorta_turu=@sigorta_turu Where sigorta_id=@sigorta_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sigorta_turu", tur);
                vt.komut.Parameters.AddWithValue("@sigorta_id", id);
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
