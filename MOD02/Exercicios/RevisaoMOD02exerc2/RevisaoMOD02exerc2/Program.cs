using System;

namespace RevisaoTesteMOD22exer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            double  ValorAquisicao,
                    ValorComercialAtual,
                    ValorDesvalorizaMaxima,
                    DesvalorizaTotal = 0,
                    TaxaDesvaloriza,
                    ValorComercialMin;

            int     Anos = 0;

            Console.Write("Valor da Aquisiçao: ");
            ValorAquisicao = double.Parse(Console.ReadLine());

            Console.Write("Valor máximo de desvalorização: ");
            ValorDesvalorizaMaxima = double.Parse(Console.ReadLine());

            ValorComercialAtual = ValorAquisicao;
            ValorComercialMin = ValorAquisicao - ValorDesvalorizaMaxima;

            while (ValorComercialAtual > ValorComercialMin)
            {
                if (Anos < 5)
                    TaxaDesvaloriza = 0.15;
                else if (Anos < 10)
                    TaxaDesvaloriza = 0.1;
                else
                    TaxaDesvaloriza = 0.05;
                ValorComercialAtual -= ValorComercialAtual * TaxaDesvaloriza;
                if (ValorComercialAtual > ValorComercialMin)
                {
                    Anos++;
                    DesvalorizaTotal = ValorAquisicao - ValorComercialAtual;
                    Console.WriteLine("{0}º ano = {1:F2} euros.", Anos, ValorComercialAtual);
                }
                DesvalorizaTotal = ValorAquisicao - ValorComercialAtual;
            }
            Console.WriteLine("Para perder menos de {0} pode ficar com o carro {1} anos.", ValorDesvalorizaMaxima, Anos);
            Console.WriteLine("Neste periodo perdeu {0} euros.", DesvalorizaTotal);

            Console.ReadKey();
        }
    }
}
