using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoveg_stat
{
    class Program
    {
        static string Ket_szokoz(string sz)
        {
            string result = sz.Trim();
            //Ötlet: 1. szóközök cseréje (); 2. )( törlése; 3. () cseréje szóközre
            result = result.Replace(" ", "()").Replace(")(", "").Replace("()", " ");
            return result;
        }
        static int Szoszam(string s)
        {
            int szam = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]==' ')
                {
                    szam++;
                }
            }
            return szam;
        }
        static string Visszafele(string szoveg)
        {
            int index = szoveg.Length;
            string eredmeny = "";
            for (int i = index - 1; i >= 0; i--)
            {
                eredmeny += szoveg[i];
            }
            return eredmeny;
        }

        static void Main(string[] args)
        {
            //0. 
            Console.Write("Be: ");
            string szoveg = Console.ReadLine();

            //1. A szöveg ? szóból áll.
            string ket_szokoz = Ket_szokoz(szoveg);
            int szoszam = Szoszam(ket_szokoz);
            Console.WriteLine($"Szavak száma: {szoszam}");

            //2. A szöveg visszafelé: ?
            string visszafele = Visszafele(szoveg);
            Console.WriteLine($"A szoveg visszafele: {visszafele}");


            Console.ReadKey();
        }
    }
}
