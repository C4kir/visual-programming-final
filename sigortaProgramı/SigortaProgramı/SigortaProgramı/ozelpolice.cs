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
    public partial class ozelpolice : Form
    {
        public ozelpolice()
        {
            InitializeComponent();
        }

        private void ozelpolice_Load(object sender, EventArgs e)
        {
            comboSirket.Items.Add("HDI");
        }
    }
}
