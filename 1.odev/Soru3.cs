using System;

namespace Soru3
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lutfen bir sayi giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] kelimeler = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + ". kelimeyi girin : ");
                kelimeler[i] = Console.ReadLine();
            }

            for (int j = n - 1; j >= 0; j--)
            {
                Console.WriteLine(kelimeler[j]);
            }
        }
    }
}