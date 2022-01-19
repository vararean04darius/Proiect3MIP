﻿using System;
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
    public partial class Bauturi : Form
    {
        public Bauturi()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
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
                int nr4 = int.Parse(textBox4.Text);
                int nr5 = int.Parse(textBox5.Text);
            }
            catch (Exception ex)
            {
                TraceHandler th = new TraceHandler();
                th.ScriereFisier(ex.Message);
            }
            using (MagazinDbContext context = new MagazinDbContext())
            {
                Produs p = new Produs();
                p.Cantitate = int.Parse(textBox1.Text);
                p.Denumire = textBox2.Text;
                context.Produse.Add(p);
                context.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
