using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double NumInteiro, NumDecimal, ParteDecimal;

            Console.Write("Digite o número real: ");
            NumDecimal = double.Parse(Console.ReadLine());

            ParteDecimal = NumDecimal - Math.Truncate(NumDecimal);
            NumInteiro = NumDecimal - ParteDecimal;

            Console.WriteLine("A parte inteira é {0} e a decimal é {1:F2}", NumInteiro, ParteDecimal);
        }
    }
}