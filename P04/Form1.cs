
using Matematika;
using PoleUtil;
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



namespace P04
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
            int x = Convert.ToInt32(textBox2.Text);
            int[] pole1 = Pole.Gen_pole(n);
            foreach( int i in pole1)
            {
                listBox1.Items.Add(i.ToString());
            }
            Retez.Policko(pole1, n, x, listBox2);
        }
    }
}
