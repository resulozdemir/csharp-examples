using System;

namespace dateTimeVeMathMetotlar
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // günün tarihini getiri.
            Console.WriteLine(DateTime.Now.Date); //saati default olarak 12 getirir
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın gununu string olarak yazar
            Console.WriteLine(DateTime.Now.DayOfYear); //yıkın kacıncı gununde oldugunu getirir

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString);
            Console.WriteLine(DateTime.Now.ToShortTimeString);

            Console.WriteLine(DateTime.Now.AddDays(2)); //ekleme icin kullanılır
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now. AddMonths(5));
            Console.WriteLine(DateTime.Now..AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));// 24
            Console.WriteLine(DateTime.Now.ToString("ddd"));// Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));// Saturday
            Console.WriteLine(DateTime.Now.ToString("MM"));// 04
            Console.WriteLine(DateTime.Now.ToString("MMM"));// Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));// April
            Console.WriteLine(DateTime.Now.ToString("yy"));// 21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));// 2021

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // 25;
            Console.WriteLine(Math.Sin(10));                      
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            Console.WriteLine(Math.Ceiling(22.3)); // 23
            Console.WriteLine(Math.Round(22.3)); // 22
            Console.WriteLine(Math.Round(22.7)); // 23
            Console.WriteLine(Math.Floor(22.7)); // 22
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.min(2,6));
            Console.WriteLine(Math.Pow(3,4)); //3^4üverir.81.
            Console.WriteLine(Math.Sqrt(9)); // karekök alır.3
            Console.WriteLine(Math.Log(9)); //9un e tabanındaki logoritmik karşılığını getirir.
            Console.WriteLine(Math.Exp(3)); //e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı.

        }



    }
}