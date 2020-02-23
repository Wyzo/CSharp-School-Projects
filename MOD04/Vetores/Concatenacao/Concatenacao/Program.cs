using System;

namespace Concatenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str1, Str2;

            Str1 = Console.ReadLine();
            Str2 = Console.ReadLine();

            Str1 = String.Concat(Str1, Str2);
            Console.WriteLine(Str1);
        }
    }
}
