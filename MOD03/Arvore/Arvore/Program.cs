using System;

namespace Arvore
{
    class Program
    {
        static void Main(string[] args)
        {
            desenhaTopo(10);
        }
        static void desenhaTopo(int Altura)
        {
            int i, j;

            for (i = 0; i < Altura; i++)
            {
                for (j = 1; j <= Altura - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
        static void desenhaTronco() 
        {

        }
    }
}
