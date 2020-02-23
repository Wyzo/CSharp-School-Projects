using System;

namespace Revisoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //O index do vetor representa a etapa;
            //O item do vetor representa o número do piloto vencedor.
            int[] Resultados = { 1, 2, 2, 5, 2, 5, 1, 2 };
            int pilotoVencedor = 0;
            int contarMax = 0;

            Console.WriteLine("O dakar tem {0} etapas.", Resultados.Length);

            for (int i = 0; i < Resultados.Length; i++)
            {
                int contar = 0;
                for (int k = 0; k < Resultados.Length; k++)
                {
                    if (Resultados[i] == Resultados[k])
                        contar++;
                }
                if (contar > contarMax)
                {
                    pilotoVencedor = i;
                    contarMax = contar;
                }
            }
            Console.WriteLine("Etapas ganhas pelo piloto");
            for (int j = 0; j < Resultados.Length; j++)
            {
                if (Resultados[pilotoVencedor] == Resultados[j])
                    Console.Write("{0} ", j);
            }
            Console.WriteLine("\nO piloto que venceu mais etapas foi o {0}", Resultados[pilotoVencedor]);
        }
    }
}
