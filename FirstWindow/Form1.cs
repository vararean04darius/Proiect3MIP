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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comandabtn_Click(object sender, EventArgs e)
        {
            using (MagazinDbContext context = new MagazinDbContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [TableName]");
            }
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
