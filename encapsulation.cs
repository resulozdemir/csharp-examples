using System;

namespace encapsulation
{
    class program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.Isim("ayse");
            ogrenci1.Soyisim("yılmaz");
            ogrenci1.OgrenciNo = 293;
            ogrenci1.Sinif = 3;

            ogrenci1.ogrenciBilgileri();

            ogrenci1.sinifAtlat();
            ogrenci1.ogrenciBilgileri();

            ogrenci ogrenci2 = new ogrenci("deniz","arda",256,1);
            ogrenci2.ogrenciBilgileri();

            ogrenci2.sinifDusur();
             
        }

        class ogrenci
        {
            private string isim;
            private string soyisim;
            private int ogrenciNo;
            private int sinif;

            public string Isim 
            { 
                get {return isim;} 
                set => isim = value; 
            }

            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
            public int Sinif 
            { 
                get => sinif; 
                set 
                {
                    if (value <= 1)
                    {
                        Console.WriteLine("sinif en az bir olabilir");
                        sinif=1;
                    }
                    else
                        sinif = value;
                     
                     
                } 
            }

            public ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
            {
                this.isim = isim;
                this.soyisim = soyisim;
                this.ogrenciNo = ogrenciNo;
                this.sinif = sinif;
            }

            public void ogrenciBilgileri()
            {
                Console.WriteLine("ogrenci adi : "+this.Isim);
                Console.WriteLine("ogrenci soyadi : "+this.Soyisim);
                Console.WriteLine("ogrenci no : "+this.OgrenciNo);
                Console.WriteLine("ogrenci sinif : "+this.Sinif);
            }

            public void sinifAtlat()
            {
                this.Sinif = this.Sinif +1;
            }

            public void sinifDusur()
            {
                this.Sinif = this.Sinif -1;
            }
        }
    }
}