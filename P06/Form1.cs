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

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

       

        private void button1_Click(object sender, EventArgs e)
        {
            string veta1 = textBox1.Text;
            string nejdelsislovo;
            string nejkradsislovo;

            bool obsahuje = Retez.ObsahujeSlovo(veta1, out nejdelsislovo, out nejkradsislovo);

            if (obsahuje == true)
            {
                MessageBox.Show("textbox obsahuje slovo nejdelsi je:" + nejdelsislovo + "  nejkradsi:" + nejkradsislovo);

                Retez.Zobraz(label1, label2, nejdelsislovo, nejkradsislovo);
            }
            else
            {
                MessageBox.Show("veta neobsahuje slovo");
            }

        }
    }
}
