using System;

namespace Soru4
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lutfen bir cumle giriniz : ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');
            string harfler = string.Join("", kelimeler);

            Console.WriteLine("girilen cumledeki toplam kelime sayisi : " + kelimeler.Length);
            Console.WriteLine("girilen cumledeki toplam harfler sayisi : " + harfler.Length);
        }
    }
}