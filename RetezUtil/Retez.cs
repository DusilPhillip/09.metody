using System;
using System.Windows.Forms;

namespace RetezUtil
{
    public class Retez
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="veta">zadany text</param>
        /// <param name="soucetlich">promenna pro soucet lich cisel</param>
        /// <returns></returns>
        static public int ObsahujeCifru(string veta, out int soucetlich)
        {

            int pocet = 0;
            soucetlich = 0;
            foreach (char i in veta)
            {

                if (i >= '0' && i <= '9')
                {
                    pocet++;

                    if (i % 2 != 0)
                    {
                        soucetlich += (int)(i - 48);

                    }



                }


            }


            return pocet;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="veta">zadany text</param>
        /// <param name="nejdelsi">promenna pro nejdelsi slovo v textu</param>
        /// <param name="nejkradsi">promenna pro nejkradsi slovo v textu</param>
        /// <returns></returns>
        static public bool ObsahujeSlovo(string veta, out string nejdelsi, out string nejkradsi)
        {
            nejdelsi = "";
            nejkradsi = "";




            veta = veta.Replace("  ", " ");
            string[] slova = veta.Split(' ');

            int max = 0;
            int min = slova.Length;

            foreach (string i in slova)
            {
                int pocetpis = 0;
                foreach (char pismeno in i)
                {
                    pocetpis++;
                }
                if (pocetpis > max)
                {
                    max = pocetpis;
                    nejdelsi = i;

                }
                if (pocetpis < min)
                {
                    nejkradsi = i;
                    min = pocetpis;
                }

            }

            if (veta.Length == 0)
            {
                return false;
            }
            else return true;


        }
//--------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// 
/// </summary>
/// <param name="lb1">jmeno Label1</param>
/// <param name="lb2">jmeno Label2</param>
/// <param name="slovo1">zadane slovo1</param>
/// <param name="slovo2">zadane slovo2</param>
        static public void Zobraz(Label lb1, Label lb2, string slovo1, string slovo2)
        {
            lb1.Text = slovo1;
            lb2.Text = slovo2;

        }
//----------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// 
/// </summary>
/// <param name="text">zadany text</param>
/// <param name="pocetcifer"> promenna pro pocet cifer</param>
/// <param name="pocetmalychpismen">promenna pro pocet malych pismen</param>
/// <param name="jineznaky">promenna pro jine znaky</param>
/// <param name="prvocislo">bool promena pro zjisteni prvocisla</param>
/// <returns></returns>
        static public bool JeAlfanum(string text, out int pocetcifer, out int pocetmalychpismen, out int jineznaky, out bool prvocislo)
        {
            bool alf = true;
            pocetcifer = 0;
            pocetmalychpismen = 0;
            jineznaky = 0;
            prvocislo = true;
            foreach (char s in text)
            {
                if (s != ' ')
                {
                    if ((s >= 'a' && s <= 'z'))
                    {
                        pocetmalychpismen++;
                    }
                    else
                    {
                        if (s >= '0' && s <= '9')
                        {
                            pocetcifer++;
                        }
                        else
                        {
                            if (s >= 'A' && s <= 'Z')
                            {
                                alf = true;
                            }
                            else { alf = false; jineznaky++; }
                        }
                    }
                }
            }
            for (int i = 2; i < pocetcifer; i++)
            {
                if (pocetcifer % i == 0)
                {
                    prvocislo = false;
                }
            }
            return alf;
        }

//---------------------------------------------------------------------------------------------------//
/// <summary>
/// 
/// </summary>
/// <param name="text">zadany text</param>
/// <returns></returns>
        static public string Smaz(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }
            return text;
        }

//--------------------------------------------------------------------------------------------------------//
/// <summary>
/// 
/// </summary>
/// <param name="text">zadany text</param>
/// <returns></returns>
        static public string[] NaSlovo(string text)
        {
            string text1 = text.Trim();
            string[] slova = text1.Split(' ');
            string[] slova2 = new string[slova.Length];
            int pocet = 0;
            for (int i = 0; i < slova.Length; i++)
            {
                if (slova[i] != "") { slova2[pocet] = slova[i]; pocet++; }
            }
            string veta = string.Join(" ", slova2);
            string veta1 = veta.Trim();
            string[] slova3 = veta1.Split(' ');

            return slova3;
        }

//-----------------------------------------------------------------------------------------------------------------//
/// <summary>
/// 
/// </summary>
/// <param name="slova3">zadane slovo </param>
/// <param name="listBox1">jmeno Listbox</param>
        static public void Zobraz(string[] slova3, ListBox listBox1)
        {
            foreach (string s in slova3)
            {
                listBox1.Items.Add(s);
            }
        }

    }
}
