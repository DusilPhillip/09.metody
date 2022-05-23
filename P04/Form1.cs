
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



namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        static private int Mocnina(int X, int cislo)
        {

            
         
            for (int k = 1; k < X; k++)
            {
             cislo *= cislo;
             }



            return cislo;
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



            for (int i = 0; i < n; i ++)
            {
                if (pole1[i] < 0)
                {
                    pole1[i] = 0;
                }
                else {

                    pole1[i] = Mocnina(x, pole1[i]);
                
                }
            }
            foreach (int i in pole1)
            {
                listBox2.Items.Add(i.ToString());
            }
            
          
           

        }
    }
}
