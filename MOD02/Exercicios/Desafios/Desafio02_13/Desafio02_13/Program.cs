using System;

namespace Desafio02_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;

            Console.Write("Digite o número: ");
            Num = int.Parse(Console.ReadLine());

            if (Num == 0 || Num == 1)
            {
                Console.WriteLine("{0} não é primo.", Num);
                Console.ReadLine();
            }
            else
            {
                if (Num % 2 == 0)
                {
                    Console.WriteLine("{0} não é primo.", Num);
                }
                else
                {
                    Console.WriteLine("{0} é primo.", Num);
                }
            }
            Console.ReadKey();
        }
    }
}
