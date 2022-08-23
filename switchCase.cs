using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int ay = DateTime.Now.Month;

            switch (ay)
            {
                case 1: Console.WriteLine("ocak ayi");
                break;

                case 2: Console.WriteLine("subat ayi");
                break;

                case 3: Console.WriteLine("mart ayi");
                break;

                case 4: Console.WriteLine("nisan ayi");
                break;

                case 5: Console.WriteLine("mayis ayi");
                break;

                case 6: Console.WriteLine("haziran ayi");
                break;

                case 7: Console.WriteLine("temmuz ayi");
                break;

                case 8: Console.WriteLine("agustos ayi");
                break;

                case 9: Console.WriteLine("eylul ayi");
                break;

                case 10: Console.WriteLine("ekim ayi");
                break;

                case 11: Console.WriteLine("kasim ayi");
                break;
                
                case 12: Console.WriteLine("aralik ayi");
                break;

                default: Console.WriteLine("islem basari ile gerceklesti");
                break;
            }

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("kis ayindasiniz");
                break;

                case 3:
                case 4:
                case 5:
                Console.WriteLine("ilkbahar ayindasiniz");
                break;

                case 6:
                case 7:
                case 8:
                Console.WriteLine("yaz ayindasiniz");
                break;

                case 9:
                case 10:
                case 11:
                Console.WriteLine("sonbahar ayindasiniz");
                break;




                default: Console.WriteLine("islem basari ile gerceklesti");
                break;
            }





        }







    }




}