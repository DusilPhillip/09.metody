using System;

namespace P01K
{
    public class Posloupnost
    {
   /// <summary>
   /// resi soucet,rozdil,
   /// </summary>
   /// <param name="a">1. člen aritmetické posloupnosti</param>
   /// <param name="b">2. člen aritmeticke posloupnosti</param>
   /// <param name="n">počet členů aritmetické posloupnosti</param>
   /// <param name="posledni">posldeni člen</param>
   /// <param name="rozdil">rozdil čísel a-b </param>
   /// <param name="pole">pole n prvku artimeticke posloupnosti</param>
   /// <returns></returns>
        static public int SoucetArPosl(int a, int b, int n, out int posledni, out int rozdil, out int[] pole)
        {

            int vetsi = 0;
            rozdil = 0;
            pole = new int[n];
            int soucet = a + b;

            if (a < b)
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
    }
}
