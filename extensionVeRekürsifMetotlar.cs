using System;

namespace extensionVeRekürsifMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive: Özyinelemeli
            // 3 ^ 4

            int result = 1;
            for (int i = 0; i <= 4; i++)
            {
                result *= 3;
            }

            Console.WriteLine(result);

            Example instance = new();
            Console.WriteLine(instance.Pow(3, 4));

            // Extension Methods - C# 3.0
            string message = "C# JavaScript Java";
            bool hasSpace = message.HasSpace();
            Console.WriteLine(hasSpace);

            if (hasSpace)
            {
                string updatedMessage = message.RemoveWhiteSpaces();
                Console.WriteLine(updatedMessage);
            }

            Console.WriteLine(message.MakeUpperCase());
            Console.WriteLine(message.MakeLowerCase());

            //
            int[] arr = {42, 4, 16, 15, 23, 8};
            arr.SortArray();
            arr.Print();

            Console.WriteLine(4.IsEven());

            Console.WriteLine("C#".GetFirstCharacter());
        }
    }

    class Example
    {
        public int Pow(int number, int exponent)
        {
            if (exponent == 1)
            {
                return number;
            }

            return Pow(number, exponent - 1) * number;
        }
    }

    static class Extensions
    {
        public static bool HasSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            return param.Replace(" ", "");
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void Print(this int[] param)
        {
            Array.ForEach(param, el => Console.Write(el + " "));
            Console.WriteLine();
        }

        public static bool IsEven(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}