using System;

namespace CalculaAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            double Base, Altura, Area;

            Console.WriteLine("Digite o valor da base:");
            Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura:");
            Altura = double.Parse(Console.ReadLine());

            Area = (Base * Altura) / 2;

            Console.WriteLine(Area);

        }
    }
}
