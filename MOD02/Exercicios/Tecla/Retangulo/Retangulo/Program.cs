using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Altura, Comprimento;
            
            Console.Write("Altura: ");
            Altura = int.Parse(Console.ReadLine());

            Console.Write("Comprimento: ");
            Comprimento = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Altura; i++)
            {
                for (int j = 1; j <= Comprimento; j++)
                {
                    if (i == 1 || i == Altura)
                        Console.Write("*");
                    else
                        if (j == 1 || j == Comprimento)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
