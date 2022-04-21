using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private int SoucetArPosl(int a, int b, int n,  out int posledni, out int rozdil, out int[] pole) {

        int vetsi = 0;
        rozdil = 0;
        pole = new int[n];
        int soucet = a + b;

            if (a<b)
            {
                vetsi = b;
                pole[0] = a;
                pole[1] = b;

                rozdil = b - a;
            }
            else
            {

                vetsi = a;
                pole[0] = b;
                pole[1] = a;

                rozdil = a - b;
            }

        for (int i = 2; i < n; i++)
{


        pole[i] = vetsi + rozdil;
        soucet += pole[i];
        vetsi = pole[i];


}
            posledni = pole[n - 1];
            return soucet;

    }

private void button1_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int a2 = Convert.ToInt32(textBox3.Text);


            int soucet = SoucetArPosl(a1, a2, n, out int posledniPrvek, out int diference, out int [] pole);

            label5.Text = diference.ToString();
            label6.Text = soucet.ToString();
            label7.Text = posledniPrvek.ToString();

            foreach ( int i in pole)
            {
                listBox1.Items.Add(i.ToString());
            }
        }
    }
}
