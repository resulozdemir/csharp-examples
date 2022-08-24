using System;

namespace arraySınıIMethodları
{
    class program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            
            Console.WriteLine("*** sırasız liste ***");

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("** sirali liste ***");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //clear
            Console.WriteLine("*** bu array clear ***");

            //sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanını 0'lar
            Array.Clear(sayiDizisi,2,2);
            
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //reverse
            Console.WriteLine("*** bu array clear ***");

            Array.Reverse(sayiDizisi);
            
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //indexOf
            Console.WriteLine("*** indexOf ***");

            Array.IndexOf(sayiDizisi,23);
            
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //resize
            Console.WriteLine("*** resize ***");

            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }




        }

    }
}