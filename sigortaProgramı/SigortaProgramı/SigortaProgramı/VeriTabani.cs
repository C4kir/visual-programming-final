using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigortaProgramı
{
    internal class VeriTabani
    {
        public MySqlConnection baglan = new MySqlConnection("server=localhost;Database=sigortadb;uid=root;Pwd='secret';");
        public MySqlCommand komut;
        public MySqlDataAdapter adapter;
        public MySqlDataReader okuyucu;
        public DataTable dataset;

        public void BaglantiAc()
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
        }

        public void BaglantiKapat()
        {
            try
            {
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
        }
    }
}
