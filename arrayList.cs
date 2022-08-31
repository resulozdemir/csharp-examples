using System;
using System.Collections;
using System.Collections.Generic;


namespace arrayList
{
    class program
    {
        static void Main(string[] args)
        {
 
            //System.Collections namespace

            ArrayList liste = new arrayList();
            liste.Add("ayse");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisindeki verilere erişme
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            //add range (icerisinde dizi ekleme)
            Console.WriteLine("***** Add Range *****");
            string[] renkler = {"kırmızı","sarı","yeşil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //sort (sıralama) eger icerisinde sadece int degerler varsa calısır yoksa hata verir
            Console.WriteLine("*** sort ***");
            liste.Sort();

            //binary search (duzgun calisabilmesi icin sıralanması lazım)
            Console.WriteLine("**binary search**");
            Console.WriteLine(liste.BinarySearch(9)); //9 rakamının bulundugu indexi getirir

            //reverse   (listeyi tam ortasından aynalar) 
            Console.WriteLine("**reverse**");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //clear (listeyi temizler)
            Console.WriteLine("**clear**");
            
            liste.Clear();
            
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


        }



    }
}