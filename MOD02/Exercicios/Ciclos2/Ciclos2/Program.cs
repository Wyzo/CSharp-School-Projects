using System;

namespace Ciclos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Fatorial = 1;

            Console.Write("Número (x > 0): ");
            Num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Num; i++)
            {
                Fatorial = Fatorial * i;
            }

            Console.Write("O fatorial de {0} é {1}.", Num, Fatorial);
            Console.ReadKey();
        }

    }

}
