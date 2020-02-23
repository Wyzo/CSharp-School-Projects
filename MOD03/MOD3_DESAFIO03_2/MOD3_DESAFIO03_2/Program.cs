using System;

namespace MOD3_DESAFIO03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Num = int.Parse(Console.ReadLine());

            cemMultiplos(Num);
        }
        static void cemMultiplos(int Num)
        {
            int Resultado;
            int Multiplos = 0;
            for (int i = 1; i <= 100; i++)
            {
                Resultado = i * Num;
                Multiplos++;
                Console.WriteLine("{0} x {1} = {2}", Num, i, Resultado);
            }
            Console.WriteLine("{0} multiplos.", Multiplos);
        }
    }
}
