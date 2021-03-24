using System;
using SajatKonyvNevter;

namespace KonyvFuttathato
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            Konyv[] konyvespolc = new Konyv[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < konyvespolc.Length; i++)
            {
                Console.WriteLine("{0}. könyv",i+1);
                Console.WriteLine("Szerző:");
                string nev = Console.ReadLine();
                Console.WriteLine("Cím:");
                string cim = Console.ReadLine();
                Console.WriteLine("Megjelenés éve:");
                int megjelenesEve = currentYear;
                Console.WriteLine("Ára:");
                int ar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Oldalszám:");
                int oldalszam = Convert.ToInt32(Console.ReadLine());
                konyvespolc[i] = new Konyv(cim, nev, megjelenesEve, ar, oldalszam);


            }

            for (int i = 0; i < konyvespolc.Length; i++)
            {
                Console.WriteLine(konyvespolc[i].ToString());
            }

            int max = 0;
            for (int i = 0; i < konyvespolc.Length; i++)
            {
                if (konyvespolc[i].Oldalszam>konyvespolc[max].Oldalszam)
                {
                    max = i;
                }
            }

            Console.WriteLine("A leghosszabb könyv:{0}",konyvespolc[max].ToString());

            int maxIndex = -1;
            for (int i = 0; i < konyvespolc.Length; i++)
            {
                if (Konyv.ParosOldalszam(konyvespolc[i]))
                {
                    maxIndex = i;
                }
                
            }
            int max2 = 0;
            if (maxIndex>=0)
            {
                for (int i = maxIndex; i < konyvespolc.Length; i++)
                {
                    if (konyvespolc[i].Oldalszam>konyvespolc[max2].Oldalszam)
                    {
                        max2 = i;
                    }
                }
            }
            else
            {
                Console.WriteLine("Nincs páros oldalszámú könyv.");
            }

            Console.WriteLine("A leghosszabb páros oldalszámú könyv:{0}", konyvespolc[max2].ToString());
            



        }
    }
}
