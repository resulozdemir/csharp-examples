using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /**
            * *1 den başlayarak console kadar olan sayıların ortlaması (girilen dahil)
            */
            int toplam = 0;
            double ort = 0;
            int sayi;
            Console.WriteLine("Sayiyi gir ");
            sayi = Convert.ToInt32(Console.ReadLine());
            int temp =sayi;

            while (sayi > 0)
            {
                toplam += sayi;
                sayi--;
            }
            Console.WriteLine("Toplam "+toplam);
            ort = (double)toplam/(double)temp;
            
            Console.WriteLine("ORT :"+ort);

            /**
             a dan z ye kadar olan tüm harfleri yaz
            **/
            char character='a';
            while (character<='z')
            {
                Console.WriteLine(character);
                character++;
            }

            /**
            Foreach
            **/
            string[] arabalar={"BMW","FORD","FERRARI"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}