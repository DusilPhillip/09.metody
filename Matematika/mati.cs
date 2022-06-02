using System;

namespace Matematika
{
    public class mati
    {
        /// <summary>
        /// resi uhlopricku a obsah
        /// </summary>
        /// <param name="a"> zadana strana </param>
        /// <param name="obsah">promenna pro vypocet</param>
        /// <returns>vraci uhlopricku</returns>
        static public double Ctverec(int a, out int obsah)
        {
            double uhlopricka;
            uhlopricka = a * Math.Sqrt(2);
            obsah = a * a;

            return uhlopricka;
        }
        /// <summary>
        /// resi uhlopricku a obsah
        /// </summary>
        /// <param name="">strana a</param>
        /// <param name="b">strana b</param>
        /// <param name="obsah">promenna pro vypocet</param>
        /// <returns>vraci uhlopricku</returns>
        static public double Obdelnik(int a, int b, out int obsah)
        {
            obsah = a * b;
            double uhlopricka = Math.Sqrt(a * a + b * b);

            return uhlopricka;
        }
        /// <summary>
        /// resi uhlopricku a objem
        /// </summary>
        /// <param name="a">zadana strana</param>
        /// <param name="objem">promenna pro vypocet</param>
        /// <returns>vraci uhlopricku</returns>
        static public double Krychle(int a, out int objem)
        {
            objem = a * a * a;
            double uhlopricka = a * Math.Sqrt(3);

            return uhlopricka;
        }
        /// <summary>
        /// resi uhlopricku a objem
        /// </summary>
        /// <param name="a">zadana hodnota a</param>
        /// <param name="b">zadana hodnota b</param>
        /// <param name="c">zadana hodnota c</param>
        /// <param name="objem">promenna pro vypocet</param>
        /// <returns>vraci uhlopricku</returns>
        static public double Kvadr(int a, int b, int c, out int objem)
        {
            objem = a * b * c;
            double uhlopricka = Math.Sqrt((a * a) + (b * b) + (c * c));

            return uhlopricka;
        }

        /// <summary>
        /// zjisti T or F u prvocisla
        /// </summary>
        /// <param name="soucty">soucet lich cisel</param>
        /// <returns> vrcai T or F prvocislo</returns>
        /// 

        static public bool JePrvocislo(int soucty)
        {
            bool prvocislo = true;
            if (soucty == 1 || soucty != 2 && soucty % 2 == 0)
            {
                prvocislo = false;
            }
            else
            {
                for (int i = 3; i < soucty; i += 2)
                {
                    if (soucty % i == 0)
                    {
                        prvocislo = false;
                    }
                }
            }
            return prvocislo;

        }
        /// <summary>
        /// cisla na urcitou mocninu
        /// </summary>
        /// <param name="X">kolikata mocnina</param>
        /// <param name="cislo">cisla ktere umocnujeme</param>
        /// <returns>vrci se umocnene cislo</returns>
        static public int Mocnina(int X, int cislo)
        {

            int mocnina = 1;

            if (X >= 0)
            {
                for (int k = 0; k < X; k++)

                {
                    mocnina *= cislo;
                }
            }
            else
            {

                X = X * (-1);

                for (int j = 0; j < X; j++)

                {
                    mocnina *= cislo;
                }
                mocnina = 1 / mocnina;

            }

            return mocnina;
        }
    }
}
