﻿
using Matematika;
using RetezUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            int pocet;
            int soucet;
            bool jePrv = true;

            pocet = Retez.ObsahujeCifru(veta, out soucet);
            jePrv = mati.JePrvocislo(soucet);

            MessageBox.Show(" veta obsahuje " + pocet + " cifer a soucet lich je " + soucet);

            if (jePrv == true)
            {
                MessageBox.Show("soucet lich je prvocislo");

            }
            else MessageBox.Show("soucet lich neni prvocislo");
        }
    }
}
