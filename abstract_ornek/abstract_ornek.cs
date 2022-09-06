using System;

namespace program
{
    class abstract_ornek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Interface****");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());
        
            Console.WriteLine("****************");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            
            Console.WriteLine("****Abstract****");
            newFocus focus1 = new newFocus();
            Console.WriteLine(focus1.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            Console.WriteLine("****************");
            newCivic civic1 = new newCivic();
            Console.WriteLine(civic1.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur());
            Console.WriteLine(civic1.StandartRengiNe().ToString());


        }
    }
}