﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayitSistemi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciDetay detay = new OgrenciDetay();

            detay.numara = maskedTextBox1.Text;

            detay.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text=="0101")
            {
                OgretmenDetay ogretmenDetay = new OgretmenDetay();
                ogretmenDetay.Show();
            }
        }
    }
}
