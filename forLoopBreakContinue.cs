using System;

namespace forLoopBreakContinue
{
    class program
    {

        static void Main(string[] args)
        {
            //Ekrana girilen sayiya kadar olan tek sayilari ekrana yazdirma
            Console.WriteLine("bir sayi giriniz : ");
            int sayac = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=sayac;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }

            //1ile 1000 arasındaki tek ve çift sayıların ken içlerinde toplamlarını ekrana yazdır.
            int tekToplam=0;
            int ciftToplam=0;
            for(int i=1;1000;i++)
            {
                if(i%2==1)
                    tekToplam+=i;

                else
                    ciftToplam+=i;

            }

            Console.WriteLine("tek toplam : "+ tekToplam);
            Console.WriteLine("cift toplam : "+ ciftToplam);

            //break,continue

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);   
            }

            //break kosul saglandıgında donguyu bitirir
            //continue kosul saglandıgında onu atlar dongu devam eder

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);   
            }


        }
    }



}