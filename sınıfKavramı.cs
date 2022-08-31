using System;

namespace sınıfKavramı
{
    class program
    {
        static void Main(string[] args)
        {
         
            calisan calisan1 = new calisan();
            calisan1.ad("resul");
            calisan1.soyad("ozdemir");
            calisan1.no=1254;
            calisan1.departman("yazılım gelistirme");

            calisan1.calisanBilgileri(); 

            Console.WriteLine("******");

            calisan calisan2 = new calisan();
            calisan2.ad("ahmet");
            calisan2.soyad("yılmaz");
            calisan2.no=654;
            calisan2.departman("insan kaynaklari");

            calisan2.calisanBilgileri();
        }

        class calisan
        {
            public string ad;
            public string soyad;
            public string no;
            public string departman;
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