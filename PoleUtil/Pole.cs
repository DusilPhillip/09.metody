using System;
using System.Windows.Forms;

namespace PoleUtil
{
    public class Pole
    {
        static public int[] Rozhrani(int n, int dol = 1, int hor = 100)
        {
            int[] pole = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {

                pole[i] = rnd.Next(dol, hor);

            }


            return pole;

        }

        static public void Kopirovani(ListBox lb, int[] pole)
        {
            lb.Items.Clear();
            foreach (int i in pole)
            {

                lb.Items.Add(i.ToString());
            }

        }
        static public int SoucetPocet(out int lich_pocet, int[] pole)
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

        static public bool Posloupnost(int[] pole)
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
        static public void Prohozeni(int[] pole)
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
        static public int[] Gen_pole(int n)
        {

            int[] pole = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {

                pole[i] = rnd.Next(-100, 101);
            }

            return pole;
        }


    }
}
