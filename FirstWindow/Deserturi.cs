using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace FirstWindow
{
    public partial class Deserturi : Form
    {
        public Deserturi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nr1 = int.Parse(textBox1.Text);
                int nr2 = int.Parse(textBox2.Text);
                int nr3 = int.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                TraceHandler th = new TraceHandler();
                th.ScriereFisier(ex.Message);
            }
        }
    }
}
