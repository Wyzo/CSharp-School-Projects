using System;

namespace Desafio02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tempo1, Tempo2, Tempo3, Tempo4, Tempo5, Final;

            Tempo1 = int.Parse(Console.ReadLine());
            Tempo2 = int.Parse(Console.ReadLine());
            Tempo3 = int.Parse(Console.ReadLine());
            Tempo4 = int.Parse(Console.ReadLine());
            Tempo5 = int.Parse(Console.ReadLine());

            Final = Tempo1 + Tempo2 + Tempo3 + Tempo4 + Tempo5;

            Console.WriteLine("\n" + Final);

            Console.ReadKey();
        }
    }
}
