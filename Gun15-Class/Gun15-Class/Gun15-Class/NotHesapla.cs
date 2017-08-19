using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Class
{
    class NotHesapla
    {
        string ad, soyad, ders;
        int s1, s2, sozlu, ort;

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

      

        public int S1
        {
            get
            {
                return s1;
            }

            set
            {
                Math.Abs(value);
            }
        }

        public int S2
        {
            get
            {
                return s2;
            }

            set
            {
                Math.Abs(value);
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public int Sozlu
        {
            get
            {
                return sozlu;
            }

            set
            {
                sozlu = Math.Abs(value);
            }
        }
        public double Ort
        { 
                get { return ort = ((S1 + S2 + Sozlu) / 3); }
        }
    }
}
