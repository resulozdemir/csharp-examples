using System;

namespace hata_yonetimi
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi : " + sayi);
            }

            catch(Exception ex)
            {
                console.WriteLine("Hata : " + ex.Message.ToString());
            }

            //finally
            //{
            //    console.WriteLine("islem tamamlandı.");
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000000");
            }

            catch(ArgumentNullException ex)
            {
                console.WriteLine("bos deger girdiniz");
                console.WriteLine(ex);
            }

            catch(FormatException ex)
            {
                console.WriteLine("veri tipi uygun degil");
                console.WriteLine(ex); 
            }

            catch(OverflowException ex)
            {
                console.WriteLine("cok kucuk yada cok buyuk bir deger girdiniz");
                console.WriteLine(ex);
            }

            finally
            {
                console.WriteLine("islem basariyla tamamlanmıstır");
            }
        }
    }
}