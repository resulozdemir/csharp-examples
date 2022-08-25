using System;

namespace Soru3
{
    class program
    {
        static void Main(string[] args)
        {
            
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


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