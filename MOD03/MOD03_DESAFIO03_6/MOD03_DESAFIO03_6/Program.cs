using System;

namespace MOD03_DESAFIO03_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcHipo(2, 2));
        }
        static double CalcHipo(int Num1, int Num2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(Num1, 2) + Math.Pow(Num2, 2)), 2);
        }
    }
}
