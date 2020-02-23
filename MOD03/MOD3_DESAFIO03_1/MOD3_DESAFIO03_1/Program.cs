using System;

namespace MOD3_DESAFIO03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Num = int.Parse(Console.ReadLine());

            Multiplos(Num);
        }
        static void Multiplos(int Num)
        {
            int Resultado;
            int Multiplos = 0;
            for (int i = 1; i < Num; i++)
            {
                Resultado = Num * i;
                Multiplos++;
                Console.WriteLine("{0} x {1} = {2}", Num, i, Resultado);
            }
            Console.WriteLine("O {0} tem {1} multiplos.", Num, Multiplos);
        }
    }
}
