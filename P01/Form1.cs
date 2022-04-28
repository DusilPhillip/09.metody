using P01K;
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
       

private void button1_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int a2 = Convert.ToInt32(textBox3.Text);


            int soucet = Posloupnost.SoucetArPosl(a1, a2, n, out int posledniPrvek, out int diference, out int [] pole);

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
