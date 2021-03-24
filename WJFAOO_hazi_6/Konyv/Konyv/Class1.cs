using System;
using System.Collections.Generic;
using System.Text;

namespace SajatKonyvNevter

{
    class Konyv
    {
        private string cim;
        private string szerzo;
        private int megjelenesEve;
        private int ar;
        private int oldalszam;
        private static string kiado = "Móra";
        public int Oldalszam
        {
            get { return oldalszam; }
            set { oldalszam = value; }
        }

        public Konyv(string cim, string szerzo,int megjelenesEve, int ar,int oldalszam)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.megjelenesEve = megjelenesEve;
            this.ar = ar;
            this.oldalszam = oldalszam;
        }

        public Konyv(string cim, string szerzo)
        {
            this.cim = cim;
            this.szerzo = szerzo;
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
            return szerzo + ": " + cim + "  Megjelenés éve: " + megjelenesEve + "  Ár: " + ar+ "  Kiadó: "+kiado+" Oldalszám: "+oldalszam;
        }

        public void AratMegnovel(int szazalek)
        {
            ar += (int)(ar * szazalek / 100.0);
        }

        public static Konyv MelyikAHosszabbKonyv(Konyv konyv1,Konyv konyv2)
        {
            if (konyv1.oldalszam>konyv2.oldalszam)
            {
                return konyv1;
            }
            else
            {
                return konyv2;
            }
        }

        public static bool ParosOldalszam(Konyv konyv)
        {
            if (konyv.oldalszam%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
