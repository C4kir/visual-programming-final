using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigortaProgramı
{
    public partial class sigorta : Form
    {
        public sigorta()
        {
            InitializeComponent();
        }
        public void veriGoster()
        {
            SigortaClass sc = new SigortaClass();
            DataTable table = sc.goster();
            dataSigorta.DataSource = table;
        }
        public void temizle()
        {
            txtID.Clear();
            txtSigortaTuru.Clear();
        }
        private void sigorta_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            label1.Enabled = false;
            veriGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataSigorta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataSigorta.CurrentRow.Cells[0].Value.ToString();
            txtSigortaTuru.Text = dataSigorta.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SigortaClass sc = new SigortaClass();
            sc.sigortaEkle(txtSigortaTuru.Text);
            veriGoster();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SigortaClass sc = new SigortaClass();
            sc.sigortaGuncelle(txtSigortaTuru.Text, txtID.Text);
            veriGoster();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SigortaClass sc = new SigortaClass();
            sc.sigortaSil(Convert.ToInt32(txtID.Text));
            veriGoster();
            temizle();
        }

        private void btnSigortaAra_Click(object sender, EventArgs e)
        {
            sigortaMusteriListele listele = new sigortaMusteriListele();

            listele.Show();
        }
    }
}
