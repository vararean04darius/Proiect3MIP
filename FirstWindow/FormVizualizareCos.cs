using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindow
{
    public partial class FormVizualizareCos : Form
    {
        public FormVizualizareCos()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var res = from x in mdb.Produse
                          select new
                          {
                              x.IdProdus,
                              x.Denumire,
                              x.Cantitate
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }
    }
}
