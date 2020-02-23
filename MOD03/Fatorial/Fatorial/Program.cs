using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Num = int.Parse(Console.ReadLine());

            int Fatorial = CalculaFatorial(Num);
            if(Fatorial < 0)
                Console.WriteLine("ERROR - O valor deve ser um número inteiro positivo.");
            else
                Console.WriteLine("{0}! = {1}", Num, Fatorial);
        }
        static int CalculaFatorial(int Num)
        {
            int Resultado = 1;
            int i = 1;
            if (Num < 0)
                return -1;
            else
                while (i <= Num)
                {
                    Resultado *= i;
                    i++;
                }
            return Resultado;
        }
    }
}
