using System;

namespace Desafio1_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroDeAcoes;

            Console.Write("Nº de Ações: ");
            NumeroDeAcoes = int.Parse(Console.ReadLine());

            int[] Compra = new int[NumeroDeAcoes];
            int[] Venda = new int[NumeroDeAcoes];

            int Valor = 0;

            for (int i = 0; i < NumeroDeAcoes; i++)
            {
                Console.Write("Valor de compra: ", i);
                Valor = int.Parse(Console.ReadLine());
                Compra[i] = Valor;
                Console.Write("Valor de venda: ", i);
                Valor = int.Parse(Console.ReadLine());
                Venda[i] = Valor;
            }

            int ValorTotal = 0;

            for (int i = 0; i < NumeroDeAcoes; i++)
                ValorTotal += Venda[i] - Compra[i];

            Console.WriteLine("Montante acumulado = {0} euros", ValorTotal);
        }
    }
}
