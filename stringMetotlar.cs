using System;

namespace stringMetot
{
    class program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz!";
            string degisken2 = "CSharp";

            //lenght (degiskenin uzunlugunu bulmana yarar)
            Console.WriteLine(degisken.Length);

            //ToUpper,ToLower (upper butun stringi buyuk harf yapar , lower butn stringi kucuk harf yapar)
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat (concat ile ekleme yapılır)
            Console.WriteLine(String.Concat(degisken," merhaba"));

            //Compare,CompareTo (karsılastırma yapar)
            Console.WriteLine(degisken.CompareTo(degisken));//-1,0,1
            Console.WriteLine(String.Compare(degisken,degisken2,true));//-1,0,1
            Console.WriteLine(String.Compare(degisken,degisken2,false));//-1,0,1
            //true dersen buyuk kucuk harf duyarsız sekilde kıyaslar
            //false dersen buyuk kucuk harf duyarlı kıyaslar

            //Contains (string icerisinde baska bir stringi arama)
            Console.WriteLine(degisken.Contains(degisken2)); //bulursa true doner
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); //degisken tırnak icerisindeki yazı ile mi bitiyor diye kontrol eder
            Console.WriteLine(degisken.StartsWith("Merhaba!")); //degisken tırnak icerisindeki yazı ile mi baslıyormu diye kontrol eder

            //IndexOf (harfin veya kelimenin bulundugu indexi bulmanı saglar)
            Console.WriteLine(degisken.IndexOf("CSharp")); //C nin indexini döner bulamazsa -1 döner
            Console.WriteLine(degisken.IndexOf("Resul"));
            Console.WriteLine(degisken.LastIndexOf("i")); //degiskenin icerisinde bulunan en son i harfinin indexini ekrana yazdirir

            //Insert (ekleme yapar)
            Console.WriteLine(degisken.Insert(0,"Merhaba ")); //0 dan baslayayarak merhaba ekle
             
            //PedLeft PedRight (ekleme islemi)
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //degisken2 nin sonuna 30 a tamamlayana kadar(30 tane bosluk eklemez) bosluk ekler
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken + degisken2);

            //remove
            Concole.WriteLine(degisken.Remove(10)); // 10 karakterden sonrasını siler
            Concole.WriteLine(degisken.Remove(5,3)); //5 den basla 3 karakter sil
            Concole.WriteLine(degisken.Remove(0,1)); //0 dan basla 1 karakter sil

            //replace (değiştirme)
            Console.WriteLine(degisken.Replace("CSharp","C#")); //ilkini ikincisi ile degistir
            Console.WriteLine(degisken.Replace(" ","*")); //boslukları yıldıza cevirme

            //Split
            Console.WriteLine(degisken.Split(' '[1])); // bosluga gore parcala ve birinciyi getir

            //Substring
            Console.WriteLine(degisken.Substring(4)); //4. indexten baslayarak sonuna kadar getir
            Console.WriteLine(degisken.Substring(4,6)); //4.indexten baslayarak 6 karakter getir
        
        
        }



    }
}