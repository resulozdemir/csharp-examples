using System;

namespace metotOverloadingOut
{
    class program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            //cevirebiliyorsan ikincisi olarak geri dondur
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("basarili");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("basarisiz");
            }

            metotlar instance = new metotlar();
            instance.topla(4,5,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //metot overloading 
            int ifade = 999;
            instance.ekranaYazdir(Convert.ToString(ifade));
            instance.ekranaYazdir(ifade);
            instance.ekranaYazdir("resul","özdemir");
            
            //metot imzası
            //metotAdi + parametre sayisi + parametre
            //public yerine private yazıp aynı metotu tekrardan yazarsan 
            //metot overloading olmaz,hata verir
            //geri dönüş tipini değiştirsende (int,void)
            //yine metot overloading olmaz,hata verir

        }

        class metotlar
        {
            public int topla(int a,int b,out int toplam)
            {
                toplam = a + b;
            }

            public void ekranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public void ekranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
        
            public void ekranaYazdir(string veri1,string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        
        
        
        
        }




    }
}