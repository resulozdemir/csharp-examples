using System;
using System.Collections.Generic;


namespace dictionary
{
    class program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic

            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();


            kullanıcılar.Add(10,"ayse yilmaz");
            kullanıcılar.Add(12,"ahmet yilmaz");
            kullanıcılar.Add(18,"deniz arda");
            kullanıcılar.Add(20,"ozcan cosar");

            //dizinin elemanlarına erişsim
            Console.WriteLine("** elemanlara erisme**");
            Console.WriteLine(kullanıcılar[12]); //12 key'ine sahip elemanı getir
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
 
            //Count 
            Console.WriteLine("**count**");
            Console.WriteLine(kullanıcılar.Count);  //kac tane elemandan olustugunu soyler
 
            //Contains (key vaya value varmı diye kontrol eder ve true veya false doner)
            Console.WriteLine("**Contains**");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("resul ozdemir"));
 
            //remove (eleman silme)
            Console.WriteLine("**remove**");
            kullanıcılar.Remove(12); //12 key'ine sahip veriyi siler

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value); //bu sekilde sadece valuelerini yazdırabilirsin
            }

            //keys
            Console.WriteLine("**keys**");

            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }


            //values
            Console.WriteLine("**values**");
            
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}