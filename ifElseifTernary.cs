using System;

namespace if_elseif_ternary
{
    class program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Date.Hour;

            if(time >= 6 && time<=11)
                Console.WriteLine("gunaydin");
            
            else if(time <= 18)
                Console.WriteLine("iyi gunler");

            else   
                Console.WriteLine("iyi geceler");

            string sonuc = time <=18 ? "iyi gunler" : "iyi geceler";

            sonuc = time >=6 && time <11 ? "gunaydın" : time <=18 ? "iyi gunler" : "iyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}