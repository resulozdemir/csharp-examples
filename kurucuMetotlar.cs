using System;

namespace sınıfKavramı
{
    class program
    {
        static void Main(string[] args)
        {
         
            calisan calisan1 = new calisan("resul","ozdemir",1254,"yazılım gelistirme");

            calisan1.calisanBilgileri(); 

            Console.WriteLine("******");

            calisan calisan2 = new calisan();
            calisan2.ad("ahmet");
            calisan2.soyad("yılmaz");
            calisan2.no=654;
            calisan2.departman("insan kaynaklari");

            calisan2.calisanBilgileri();

            Console.WriteLine("******");
            calisan calisan3 = new calisan("veli","ozturk");
            calisan3.calisanBilgileri();
        }

        class calisan
        {
            public string ad;
            public string soyad;
            public string no;
            public string departman;

            public calisan(string ad,string soyad,int no,string departman)
            {
                this.ad=ad;
                this.soyad=soyad;
                this.no=no;
                this.departman=departman;
            }

            public calisan(string ad,string soyad)
            {
                this.ad=ad;
                this.soyad=soyad;
            }

            public calisan(){}

            public void calisanBilgileri()
            {
                Console.WriteLine("Calisan adi : "+ad);
                Console.WriteLine("Calisan soyadi : "+soyad);
                Console.WriteLine("Calisan no : "+no);
                Console.WriteLine("Calisan departman : "+departman);
            }
        }
    }
}