using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int Altura, Largura;
   
            Altura = int.Parse(Console.ReadLine());
            Largura = int.Parse(Console.ReadLine());

            /*  Formas de utilizar o i:
             *  i++
             *  i=1+1
             *  i+=1
             */

            /*
             * Desenhar o retângulo
             */

            /*for (int i = 0; i < Largura; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < Altura - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < Largura - 2; j++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                    Console.Write("\n");
                }
            }
            for (int i = 0; i < Altura; i++)
            {
                Console.Write("*");
                Console.Write("\n");
            }

            /*for (int i = 0; i < Largura; i++)
            {
                Console.Write("*");
            }
            for (int a = 0; a <= Largura; a++)
            {
                Console.WriteLine("");
                Console.Write("*");
            }
            for (int c = 0; c <= Altura; c++)
            {
                Console.WriteLine("   *");
            }
            for (int d = 0; d <= Altura; d++)
            {
                Console.Write("*");
                Console.WriteLine("   *");
            }
            for (int e = 0; e < Largura; e++)
            {
                Console.Write("*");
            }
            Console.ReadLine();*/
            for (int i = 1; i <= Altura; i++)
            {
                for (int j = 1; j <= Largura; j++)
                {
                    if (i == 1 || i == Altura)
                        Console.Write("*");
                    else
                        if (j == 1 || j == Largura)
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
