using System;

namespace MOD03_DESAFIO3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;

            Num1 = int.Parse(Console.ReadLine());
            Num2 = int.Parse(Console.ReadLine());

            for (int i = Num1; i <= Num2; i++)
            {
                if (numPares(i))
                {
                    Console.WriteLine("{0} é par.", i);
                }
            }
        }

        public static bool numPares(int Num)
        {
            return Num % 2 == 0;
        }
    }
}
