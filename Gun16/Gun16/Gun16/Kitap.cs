using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun16
{
    class Kitap
    {
        string kitapAdi, yazari, turu, yayinEvi;
        int ISBN, sayfaSayi;
        DateTime yayinTarihi;
       
        public string KitapAdi
        {
            get
            {
                return kitapAdi;
            }

            set
            {
                kitapAdi = value;
            }
        }

        public string Yazari
        {
            get
            {
                return yazari;
            }

            set
            {
                yazari = value;
            }
        }

        public string Turu
        {
            get
            {
                return turu;
            }

            set
            {
                turu = value;
            }
        }

        public string YayinEvi
        {
            get
            {
                return yayinEvi;
            }

            set
            {
                yayinEvi = value;
            }
        }

        public int ISBN1
        {
            get
            {
                return ISBN;
            }

            set
            {
                ISBN = value;
            }
        }

        public int SayfaSayi
        {
            get
            {
                return sayfaSayi;
            }

            set
            {
                sayfaSayi = value;
            }
        }

        public DateTime YayinTarihi
        {
            get
            {
                return yayinTarihi;
            }

            set
            {
                yayinTarihi = value;
            }
        }
    }
}
