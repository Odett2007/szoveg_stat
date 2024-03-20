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
        static void Main(string[] args)
        {
            //0. 
            Console.Write("Be: ");
            string szoveg = Console.ReadLine();
            Console.WriteLine(" ");

            //1.
            string ket_szokoz = Ket_szokoz(szoveg);
            int szoszam = Szoszam(ket_szokoz);
            Console.WriteLine($"Szavak száma: {szoszam}");


            Console.ReadKey();
        }
    }
}
