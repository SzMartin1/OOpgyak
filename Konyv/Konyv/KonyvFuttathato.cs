using System;

namespace Konyv
{
    class KonyvFuttathato
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            Konyv konyv = new Konyv("The song of ice and fire", "George R.R. Martin",year,2500);
            

            Console.WriteLine(konyv.ToString());

            konyv.AratMegnovel(25);

            Console.WriteLine(konyv.ToString());
        }
    }
}
