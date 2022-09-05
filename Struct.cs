using System;

namespace yapi
{
    class program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.KisaKenar = 3;
            dikdörtgen.UzunKenar = 4;

            Console.WriteLine("dikdörtgenin alani : "+dikdörtgen.AlanHesapla());

            Dikdörtgen_Struct dikdörtgen_Struct = new Dikdörtgen_Struct(3,4);
           

            Console.WriteLine("dikdörtgenin alani : "+dikdörtgen_Struct.AlanHesapla());

        }

        class Dikdörtgen
        {
            public int KisaKenar;

            public int UzunKenar;

            public Dikdörtgen()
            {
                KisaKenar = 3;
                UzunKenar = 4;
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }
        }

        struct Dikdörtgen_Struct
        {
            public int KisaKenar;

            public int UzunKenar;

            public Dikdörtgen_Struct(int kisaKenar, int uzunKenar)
            {
                KisaKenar = kisaKenar;
                UzunKenar = uzunKenar;
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }
        }
    }
}