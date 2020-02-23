using System;

namespace AplicacoesBancarias
{
    class Program
    {
        static void Main(string[] args)
        {
            double Deposito, ValorTaxa, ValorTaxaFinal, ValorFinal;

            Console.Write("Montante do depósito: ");
            Deposito = int.Parse(Console.ReadLine());

            if (Deposito <= 2000)
            {
                ValorTaxa = Deposito * 0.03;
                ValorTaxaFinal = ValorTaxa * 0.72;
                ValorFinal = Deposito + ValorTaxaFinal;
                Console.WriteLine(ValorFinal);
            }
            else if (Deposito >= 2001 || Deposito <= 3000)
            {
                ValorTaxa = Deposito * 0.034;
                ValorTaxaFinal = ValorTaxa * 0.72;
                ValorFinal = Deposito + ValorTaxaFinal;
                Console.WriteLine(ValorFinal);
            }
            else if (Deposito >= 3001 || Deposito <= 8000)
            {
                ValorTaxa = Deposito * 0.037;
                ValorTaxaFinal = ValorTaxa * 0.72;
                ValorFinal = Deposito + ValorTaxaFinal;
                Console.WriteLine(ValorFinal);
            }
            else
            {
                ValorTaxa = Deposito * 0.04;
                ValorTaxaFinal = ValorTaxa * 0.72;
                ValorFinal = Deposito + ValorTaxaFinal;
                Console.WriteLine(ValorFinal);
            }
            Console.ReadKey();
        }
    }
}
