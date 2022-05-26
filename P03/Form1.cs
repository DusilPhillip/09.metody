using Matematika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            //ctverec
            int obsah;
            int a = Convert.ToInt32(textBox1.Text);
            double uhl = mati.Ctverec(a,out obsah);

            MessageBox.Show(" obsah čtverce je:" + obsah + " uhlopříčka je:" + uhl);

            //obdelnik
            int obsahob;
            int b = Convert.ToInt32(textBox2.Text);

          
            double uhl2 = mati.Obdelnik(a, b, out obsahob);
            MessageBox.Show(" obsah obdelniku je:" + obsahob + " uhlopříčka je:" + uhl2);

            //krychle
            int objem;
            double Tuhl = mati.Krychle(a, out objem);

            MessageBox.Show("objem krychle je:" + objem + " telesna uhlopricka je:" + Tuhl);

            //kvádr
            int c = Convert.ToInt32(textBox3.Text);
            int objem2;
            double Tuhlo2 = mati.Kvadr(a, b, c, out objem2);

            MessageBox.Show("objem Kvádru je:" + objem2 + " telesova uhlopricka je:" + Tuhlo2);


            
        }
    }
}
