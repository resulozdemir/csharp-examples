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
                case 1: console.WriteLine("ocak ayi");
                break;

                case 2: console.WriteLine("subat ayi");
                break;

                case 3: console.WriteLine("mart ayi");
                break;

                case 4: console.WriteLine("nisan ayi");
                break;

                case 5: console.WriteLine("mayis ayi");
                break;

                case 6: console.WriteLine("haziran ayi");
                break;

                case 7: console.WriteLine("temmuz ayi");
                break;

                case 8: console.WriteLine("agustos ayi");
                break;

                case 9: console.WriteLine("eylul ayi");
                break;

                case 10: console.WriteLine("ekim ayi");
                break;

                case 11: console.WriteLine("kasim ayi");
                break;
                
                case 12: console.WriteLine("aralik ayi");
                break;

                default: console.WriteLine("islem basari ile gerceklesti");
                break;
            }

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                console.WriteLine("kis ayindasiniz");
                break;

                case 3:
                case 4:
                case 5:
                console.WriteLine("ilkbahar ayindasiniz");
                break;

                case 6:
                case 7:
                case 8:
                console.WriteLine("yaz ayindasiniz");
                break;

                case 9:
                case 10:
                case 11:
                console.WriteLine("sonbahar ayindasiniz");
                break;




                default: console.WriteLine("islem basari ile gerceklesti");
                break;
            }





        }







    }




}