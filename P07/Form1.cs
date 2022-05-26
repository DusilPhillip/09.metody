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

namespace p07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int pocetcifer;
            int pocetmalychpismen;
            int jineznaky;
            bool prvocislo;


            bool alf = Retez.JeAlfanum(text, out pocetcifer, out pocetmalychpismen, out jineznaky, out prvocislo);


            if (alf) { MessageBox.Show("retezec je alfanumerický"); }
            
            
            else { MessageBox.Show("Retezec neni alfanumerický."); }


            if (pocetcifer != 0) {
                
                if (prvocislo) { MessageBox.Show("Pocet cifer je prvocislo."); } 
                
                
                   else { MessageBox.Show("Pocet cifer neni prvocislo."); } }

                           MessageBox.Show("Pocet malych pismen v retezci = " + pocetmalychpismen + ", pocet cifer je " + pocetcifer + " a pocet jinych znaku je " + jineznaky);
        }
    }
}
