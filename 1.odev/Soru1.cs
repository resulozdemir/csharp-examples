using System;

namespace Soru1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen bir sayi giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1) + ".Elemanı giriniz : ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(dizi[i]%2==0)
                    Console.WriteLine(dizi[i]);
            }
        }
    }
}