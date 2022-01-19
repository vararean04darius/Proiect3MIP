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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bauturi b = new Bauturi();
            b.ShowDialog();
           
        }

        private void garnituribtn_Click(object sender, EventArgs e)
        {
            Garnituri g = new Garnituri();
            g.ShowDialog();
        }

        private void carnebtn_Click(object sender, EventArgs e)
        {
            Carne c = new Carne();
            c.ShowDialog();
        }

        private void deserturibtn_Click(object sender, EventArgs e)
        {
            Deserturi d = new Deserturi();
            d.ShowDialog();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
