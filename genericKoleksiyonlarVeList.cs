using System;
using System.Collections.Generic;

namespace genericKoleksiyonlarVeList
{
    class program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T-> object turundedir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            //Foreach ve list foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);               
            }

            //foreach in kısa ve pratik kullanımı
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //listeden eleman sil
            sayiListesi.Remove(4);  //4 ü sil
            renkListesi.Remove("yeşil");    //yesili sil

            sayiListesi.RemoveAt(0); //sıfırıncı ındısındekini sil
            renkListesi.RemoveAt(1); //birinci indisindekini sil

            //liste icerisindeki arama
            if (sayiListesi.Contains(10))   //10 u liste icerisinde arama
            {
                Console.WriteLine("10 liste icerisinde bulundu");
            }

            //eleman ile indexe erişme
            //BinarySearch ü kullanabilmek için arama yapılacak listenin sıralı olması lazım, liste sıralı olmadıgı içinde hatalı deger döndürüyor.
            Console.WriteLine(renkListesi.BinarySearch("sari")); //sari renginin indexini ekrana yazdırır


            //diziyi Liste cevirme
            string[] hayvanlar = {"kedi","köpek","kus"};
            List<string> hayvanListesi = new List<string>(hayvanlar);   

            //listeyi nasıl temizleriz
            hayvanListesi.Clear();

            //liste icerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new Kullanıcılar();
            
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim="ayse";
            kullanıcı1.Soyisim="yılmaz";
            kullanıcı1.Yas=26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim="mehmet";
            kullanıcı2.Soyisim="ali";
            kullanıcı2.Yas=52;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim="deniz",
                Soyisim="arda",
                Yas=24
                
            });


            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("kullanıcı adi : "+ kullanıcı.Isim);
                Console.WriteLine("kullanıcı soyisim : "+ kullanıcı.Soyisim);
                Console.WriteLine("kullanıcı yas : "+ kullanıcı.Yas);
            }


            yeniListe.Clear();


        }

    
    }
    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim{get => isim; set => isim= value;}
        public string Soyisim{get=>soyisim;set=>soyisim=value;}
        public int Yas{get => yas; set => yas= value;}
    }
}