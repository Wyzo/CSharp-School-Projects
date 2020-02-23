using System;

namespace Desafio02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int         Alunos;
            double      Notas, PercentagemNegativa;
            int         Negativas           = 0;
            int         Positivas           = 0;

            Alunos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Alunos; i++)
            {
                Notas = double.Parse(Console.ReadLine());
                if (Notas < 9.5)
                {
                    Console.WriteLine("Negativa");
                    Negativas++;
                }
                else
                {
                    Console.WriteLine("Positiva");
                    Positivas++;
                }
            }

            PercentagemNegativa = (100.0 / Alunos) * Negativas;

            Console.WriteLine("Negativas: " + Negativas);
            Console.WriteLine("Positivas: " + Positivas);
            Console.WriteLine("Percentagem de negativas = {0}%", PercentagemNegativa);
            Console.ReadKey();
        }
    }
}
