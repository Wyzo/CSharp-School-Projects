using System;

namespace Desafio02_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor;
            double ValorFinal   = 0;

            int Taxa;
            int Anos;

            Console.Write("Valor inicial: ");
            Valor = double.Parse(Console.ReadLine());

            Console.Write("Nº anos: ");
            Anos = int.Parse(Console.ReadLine());

            Console.Write("Taxa: ");
            Taxa = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Anos ; i++)
            {
                ValorFinal = Math.Round(Valor + (Valor / 100) * Taxa, 0);
                Valor = ValorFinal;
                Console.WriteLine("{0}º ano = {1} euros.", i, ValorFinal);
            }
            Console.ReadKey();
        }
    }
}
