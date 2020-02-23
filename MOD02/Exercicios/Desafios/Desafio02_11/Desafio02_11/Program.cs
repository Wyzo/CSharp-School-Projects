using System;

namespace Desafio02_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int Resultado = 0;

            Console.Write("Número: ");
            Num = int.Parse(Console.ReadLine());

            for (int i = 1; i < Num; i++)
            {
                Resultado = i * Num;
            }
            Console.WriteLine("O Fatorial de {0} é {1}", Num, Resultado);
            Console.ReadKey();
        }
    }
}
