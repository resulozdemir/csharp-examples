using system;

namespace enum_program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(günler.pazar); //pazar
            Console.WriteLine((int)günler.cumartesi); //24

            int sıcaklık = 32;

            if (sıcaklık <= (int)havaDurumu.normal ) //enum nornalde string doner karsılastırma yapabilmemiz icin basına int yazmalıyız
            {
                Console.WriteLine("dısarıya cikmak icin havanın bıraz daha ısınmasını bekleyelim");
            }

            else if (sıcaklık >= (int)havaDurumu.sıcak )
            {
                Console.WriteLine("dısarıya cıkmak ıcın cok sıcak bir gun");
            }

            else if (sıcaklık >= (int)havaDurumu.cokSıcak )
            {
                Console.WriteLine("hadi dısarı cıkalım");
            }

        }
    }

    enum günler{
        pazartesi,
        sali,
        çarşamba,
        perşembe,
        cuma = 23,
        cumartesi,
        pazar
    }

    enum havaDurumu
    {
        soguk = 5,
        normal = 20,
        sıcak = 25,
        cokSıcak = 30
    }
}