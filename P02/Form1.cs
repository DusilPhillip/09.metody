﻿using System;
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
        static private int [] Rozhrani (int n,int dol = 1,int hor = 100)
        {
            int[] pole = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {

                pole[i] = rnd.Next(dol, hor);
                
            }


            return pole;

        }

        static private void Kopirovani(ListBox lb, int [] pole)
        {
            lb.Items.Clear();
            foreach (int i in pole)
            {

                lb.Items.Add(i.ToString());
            }
 
        }
        static private int SoucetPocet ( out int lich_pocet,int [] pole)
        {
           int sud_soucet = 0;
            lich_pocet = 0;
            foreach (int i in pole)
            {
                if (i % 2 == 0)
                {
                    sud_soucet += i;
                }
                else
                {
                    lich_pocet++;
                }
            }
            return sud_soucet;

        }

        static private bool Posloupnost( int [] pole)
        {
            for (int i = 0; i < pole.Length - 1; i++)
            {
                if (pole[i + 1] < pole[i])
                {
                    return false;
                }
            }
            return true;
            
        }
       static private void Prohozeni(int [] pole)
        {


            int max = pole[0];
            int pozicemax = 0;
            int posledni = pole[pole.Length - 1];
            int poziceposledni = pole.Length - 1;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max)
                {
                    max = pole[i];
                    pozicemax = i;
                }
            }

            pole[pozicemax] = posledni;
            pole[poziceposledni] = max;

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

                pole = Rozhrani(n, x, y);  
            }
            else
            {
                pole = Rozhrani(n);
            }



            //metoda2
            Kopirovani(listBox1, pole);

            //metoda3;
            int lich;
            int soucet = SoucetPocet(out lich, pole);

            MessageBox.Show("soucet sudych:" + soucet + " soucet lichych:" + lich);


            //metoda4

            bool rostouci = Posloupnost(pole);
            if (rostouci == true)
            {
                MessageBox.Show("posloupnost je rostouci");

            }
            else
            {
                MessageBox.Show(" posloupnost roustouci neni");
            }


            Prohozeni(pole);
            Kopirovani(listBox2, pole);
        }
    }
}
    

