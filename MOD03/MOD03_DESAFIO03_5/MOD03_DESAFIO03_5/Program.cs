using System;

namespace MOD03_DESAFIO03_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Troca(ref a, ref b);
            Console.WriteLine("{0} e {1}", a, b);
        }
        static void Troca(ref int Num1, ref int Num2)
        {
            int Temp;

            Temp = Num1;
            Num1 = Num2;
            Num2 = Temp;
        }
    }
}
