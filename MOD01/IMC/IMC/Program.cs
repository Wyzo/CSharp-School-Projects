using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            int Peso;
            double Altura, IMC;

            Console.Write("Peso:");
            Peso = int.Parse(Console.ReadLine());
            Console.Write("Altura:");
            Altura = double.Parse(Console.ReadLine());

            IMC = Math.Round(Peso / Math.Pow(Altura, 2));
            Console.Write("IMC: {0:F2}.", IMC);

            Console.ReadKey();
        }
    }
}
