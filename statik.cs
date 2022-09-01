using System;

namespace statik
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calisan sayisi : "+Calisan.CalisanSayisi());

            Calisan calisan1 = new Calisan("ayse","yilmaz","IK");   //sınıftan olusturulan nesne ile erisilir static değil ise sinif
            Console.WriteLine("calisan sayisi : "+Calisan.CalisanSayisi());

            Calisan calisan2 = new Calisan("mehmet","ziya","developer");
            Calisan calisan3 = new Calisan("resul","ozdemir","developer");
            
            Console.WriteLine("calisan sayisi : "+Calisan.CalisanSayisi());

            Console.WriteLine("-*-*-*-*-*-");

            Islemler islemler = new Islemler();
            Conole.WriteLine("toplama islemi : "+Islemler.topla(5,2)); 
            //static sinifin ogelerine sinifin adi ile erisilir

            Conole.WriteLine("toplama islemi : "+Islemler.cikar(5,2)); 

        }

        class Calisan
        {
            private static int calisanSayisi;

            public static int CalisanSayisi { get => calisanSayisi; }

            private string isim;

            private string soyisim;

            private string departman;

            static Calisan()
            {
                calisanSayisi = 0;
            }

            public Calisan(string isim, string soyisim, string departman)
            {
                this.isim = isim;
                this.soyisim = soyisim;
                this.departman = departman;
                calisanSayisi++;
            }
        }

        static class Islemler   //static sinif icerisinde static olmayan herhangi bir sey kullanamazsın
        //static siniflara kalıtım isleri uygulanamaz
        {
            public static long topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }
            public static long cikar(int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }
        }



    }
}