using System;

namespace Soru2
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lutfen iki adet pozitif sayi girin : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + ".Elemanı giriniz : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (sayilar[i] % m == 0 && sayilar[i]!=0)
                    Console.WriteLine(sayilar[i]);
            }

        }
    }
}