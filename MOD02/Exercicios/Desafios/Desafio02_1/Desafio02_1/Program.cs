using System;

namespace Desafio02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Resultado;

            for (int i = 1; i <= 1; i++)
            {
                for (int j = 0, x = 0; j < 10 && x >= -2; j++, x--)
                {
                    System.Console.WriteLine("FOR: i={0}, x={1}", i, x);
                }

                /*for (int k = 1; k <= 100; k++)
                {
                    //Console.WriteLine("{0} + {1} = {2}", i, j, Resultado);
                }*/
            }
            Console.ReadKey();
        }
    }
}
