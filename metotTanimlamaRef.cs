using System;

namespace metotTanimlama
{
    class program
    {
        static void Main(string[] args)
        {
            
            int a = 2;
            int b = 3;

            Console.WriteLine(a+b);

            int sonuc = topla(a,b);
            Console.WriteLine(sonuc);

            metotlar ornek = new metotlar();
            ornek.ekranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.arttirVeTopla(ref a, ref b);
            ornek.ekranaYazdir(Convert.ToString(sonuc2));
            ornek.ekranaYazdir(Convert.ToString(a+b));
 
        }

        static int topla(int deger1, int deger2)
        {
            return (deger1+deger2);
        }

    }

    class metotlar
    {
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        //ref asıl değişken üzerinde değişiklik yapar
        public int arttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return (deger1+deger2);
        }


    }




}