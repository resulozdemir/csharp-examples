using System;

namespace if_elseif_ternary
{
    class program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Date.Hour;

            if(time >= 6 && time<=11)
                console.WriteLine("gunaydin");
            
            else if(time <= 18)
                console.WriteLine("iyi gunler");

            else   
                console.WriteLine("iyi geceler");

            string sonuc = time <=18 ? "iyi gunler" : "iyi geceler";

            sonuc = time >=6 && time <11 ? "gunaydın" : time <=18 ? "iyi gunler" : "iyi geceler";
            console.WriteLine(sonuc);
        }
    }
}