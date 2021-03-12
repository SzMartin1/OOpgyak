using System;
using System.Collections.Generic;
using System.Text;

namespace Konyv
{
    class Konyv
    {
        private string cim;
        private string szerzo;
        private int megjelenesEve;
        private int ar;

        public Konyv(string cim, string szerzo)
        {
            this.cim = cim;
            this.szerzo = szerzo;
        }

        public Konyv(string cim, string szerzo, int megjelenesEve, int ar)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.megjelenesEve = megjelenesEve;
            this.ar = ar;
        }

        public int KonyvAr
        {
            get { return ar; }
            set { ar = value; }
        }


        public int MegjelenesEve
        {
            get { return megjelenesEve; }
            set { megjelenesEve = value; }
        }


        public string KonyvSzerzo
        {
            get { return szerzo; }
            set { szerzo = value; }
        }


        public string KonyvCim
        {
            get { return cim; }
            set { cim = value; }
        }

        public override string ToString()
        {
            return szerzo + ": " + cim + "  Megjelenés éve: " + megjelenesEve + "  Ár: " + ar;
        }

        public void AratMegnovel(int szazalek)
        {
            ar += (int)(ar * szazalek / 100.0);
        }

        public string InformaciotKiir()
        {
            return szerzo + ": " + cim + "  Megjelenes eve: " + megjelenesEve + "  Ar: " + ar;
        }
    }
}
