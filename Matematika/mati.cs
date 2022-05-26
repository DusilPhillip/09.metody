using System;

namespace Matematika
{
    public class mati
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"> zadana strana </param>
        /// <param name="obsah">promenna pro vypocet</param>
        /// <returns></returns>
        static public double Ctverec(int a, out int obsah)
        {
            double uhlopricka;
            uhlopricka = a * Math.Sqrt(2);
            obsah = a * a;

            return uhlopricka;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="">strana a</param>
        /// <param name="b">strana b</param>
        /// <param name="obsah">promenna pro vypocet</param>
        /// <returns></returns>
        static public double Obdelnik(int a, int b, out int obsah)
        {
            obsah = a * b;
            double uhlopricka = Math.Sqrt(a * a + b * b);

            return uhlopricka;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">zadana strana</param>
        /// <param name="objem">promenna pro vypocet</param>
        /// <returns></returns>
        static public double Krychle(int a, out int objem)
        {
            objem = a * a * a;
            double uhlopricka = a * Math.Sqrt(3);

            return uhlopricka;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">zadana hodnota a</param>
        /// <param name="b">zadana hodnota b</param>
        /// <param name="c">zadana hodnota c</param>
        /// <param name="objem">promenna pro vypocet</param>
        /// <returns></returns>
        static public double Kvadr(int a, int b, int c, out int objem)
        {
            objem = a * b * c;
            double uhlopricka = Math.Sqrt((a * a) + (b * b) + (c * c));

            return uhlopricka;
        }
    }
}
