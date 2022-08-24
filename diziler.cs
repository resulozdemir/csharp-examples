using System;

namespace diziler
{
    class program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim

            renkler[0] = "mavi";
            dizi[3] = 10;
            
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[0]);

            //döngüler ile dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("dizinin eleman sayısını giriniz : ");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for(int i=0;i<diziUzunlugu;i++)
            {
                Console.Write("Lutfen"+ i+1 +"sayısını giriniz :");
                sayiDizisi[i]=Convert.ToInt32(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama : " +toplam/diziUzunlugu);


        }


    }
}