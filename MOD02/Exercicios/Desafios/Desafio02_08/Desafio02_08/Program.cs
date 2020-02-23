using System;

namespace Desafio02_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int Peso;
            int Malas               = 0;
            int PesoTotalDeMalas    = 0;

            int PrecoFinal;

            const int PESO_MAXIMO   = 1000;
            const int TAXA          = 20;

            do
            {
                Console.WriteLine("Peso da mala?");
                Peso = int.Parse(Console.ReadLine());

                PesoTotalDeMalas+=Peso;
                Malas++;
            } while (PesoTotalDeMalas < PESO_MAXIMO);

            PrecoFinal = TAXA * Malas;

            Console.WriteLine("O preço total, com juros, pelas {0} malas é de {1} euros.", Malas, PrecoFinal);

            Console.ReadKey();
        }
    }
}
