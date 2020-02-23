using System;

namespace NumPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Divisores = 0;

            Num = int.Parse(Console.ReadLine());

            for (int i = Num - 1; i > 1 ; i--)
            {
                if (Num % i == 0)
                {
                    Divisores++;
                    break;
                }
            }
            if (Divisores == 0)
            {
                Console.WriteLine("é primo");
            }
            else
            {
                Console.WriteLine("não é primo");
            }
            Console.ReadKey();
        }
    }
}
