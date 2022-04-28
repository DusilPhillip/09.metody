using PoleUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole;
            //metoda1
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                int x = Convert.ToInt32(textBox2.Text);
                int y = Convert.ToInt32(textBox3.Text);

                pole = Pole.Rozhrani(n, x, y);
            }
            else
            {
                pole = Pole.Rozhrani(n);
            }



            //metoda2
            Pole.Kopirovani(listBox1, pole);

            //metoda3;
            int lich;
            int soucet = Pole.SoucetPocet(out lich, pole);

            MessageBox.Show("soucet sudych:" + soucet + " soucet lichych:" + lich);


            //metoda4

            bool rostouci = Pole.Posloupnost(pole);
            if (rostouci == true)
            {
                MessageBox.Show("posloupnost je rostouci");

            }
            else
            {
                MessageBox.Show(" posloupnost roustouci neni");
            }


            Pole.Prohozeni(pole);
            Pole.Kopirovani(listBox2, pole);
        }
    }
}
    

