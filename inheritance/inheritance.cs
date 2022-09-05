using System;

namespace inheritance
{
    class program 
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = tohumluBitkiler();
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("***********");

            Kuslar marti = new Kuslar();
            marti.Ucmak();


        }
    }
}