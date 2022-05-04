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

        static private double Ctverec(int a,out int obsah)
        {
            double uhlopricka;
            uhlopricka = a * Math.Sqrt(2);
            obsah = a * a;

            return uhlopricka;
        }

        static private double Obdelnik(int a, int b, out int obsah)
        {
            obsah = a * b;
            double uhlopricka = Math.Sqrt(a * a + b * b);

            return uhlopricka;
        }
        static private double Krychle(int a, out int objem)
        {
            objem = a * a * a;
            double uhlopricka = a * Math.Sqrt(3);

            return uhlopricka;
        }
        static private double Kvadr(int a, int b, int c, out int objem)
        {
            objem = a * b * c;
            double uhlopricka = Math.Sqrt((a * a) + (b * b) + (c * c));

            return uhlopricka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ctverec
            int obsah;
            int a = Convert.ToInt32(textBox1.Text);
            double uhl = Ctverec(a,out obsah);

            MessageBox.Show(" obsah čtverce je:" + obsah + " uhlopříčka je:" + uhl);

            //obdelnik
            int obsahob;
            int b = Convert.ToInt32(textBox2.Text);

          
            double uhl2 = Obdelnik(a, b, out obsahob);
            MessageBox.Show(" obsah obdelniku je:" + obsahob + " uhlopříčka je:" + uhl2);

            //krychle
            int objem;
            double Tuhl = Krychle(a, out objem);

            MessageBox.Show("objem krychle je:" + objem + " telesna uhlopricka je:" + Tuhl);

            //kvádr
            int c = Convert.ToInt32(textBox3.Text);
            int objem2;
            double Tuhlo2 = Kvadr(a, b, c, out objem2);

            MessageBox.Show("objem Kvádru je:" + objem2 + " telesova uhlopricka je:" + Tuhlo2);


            
        }
    }
}
