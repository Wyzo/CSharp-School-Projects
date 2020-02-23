using System;

namespace Desafio1_05_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroAcoes;
            int Montante = 0;
            int Num;
            bool Valido;

            Console.Write("Número de ações: ");
            NumeroAcoes = int.Parse(Console.ReadLine());

            int[,] Acoes = new int[2, NumeroAcoes]; //Matriz de duas linhas e N ações colunas.
            //a linha com indice 0 corresponde à compra, a linha com indice 1 corresponde à venda.

            string[] Valor;
            
            for (int i = 0; i < NumeroAcoes; i++)
            {
                Console.Write("Compra e venda da ação nº{0}: ", i + 1);
                Valor = Console.ReadLine().Split(' ');
                if (Valor.Length == 2)
                {
                    /*Valido = int.TryParse(Valor[0], out Num);
                    if (!Valido)
                        Console.WriteLine("Erro");*/
                    int.TryParse(Valor[0], out Num);
                    //Acoes[0, i] = int.Parse(Valor[0]);
                    Acoes[0, i] = Num;
                    int.TryParse(Valor[1], out Num);
                    //Acoes[1, i] = int.Parse(Valor[1]);
                    Acoes[1, i] = Num;
                }
            }

            for (int i = 0; i < NumeroAcoes; i++)
                Montante += Acoes[1, i] - Acoes[0, i];

            Console.WriteLine("Montante acumulado = {0} euros.", Montante);
        }
    }
}
