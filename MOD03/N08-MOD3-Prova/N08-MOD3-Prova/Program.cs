using System;

namespace N08_MOD3_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            string Divisa;
            string Taxa;
            double Preco;
            string Moeda;

            Console.WriteLine("==================================");

            Console.Write("Consultar Taxas? (S/N): ");
            Taxa = Console.ReadLine().ToLower();
            Console.Write("Preço do Produto (Euros): ");
            Preco = double.Parse(Console.ReadLine());
            Console.Write("Divisa (R/D/L/T): ");
            Divisa = Console.ReadLine().ToLower();

            Console.WriteLine();
            ConsultarTaxas(Taxa);
            Console.WriteLine();

            Moeda = Pais(Divisa);
            double PrecoFinal = Math.Round(PrecoTotal(Preco, Divisa),2 );

            Console.WriteLine("Preço do produto: {0} {1}", PrecoFinal, Moeda);
            Console.ReadKey();
        }
        static double PrecoTotal(double Preco, string Divisa)
        {
            double PrecoFinal = 0;

            double PrecoTaxa = 0, TotalDaTaxa = 0;

            const double TAXA_BRASIL    = 3.22;
            const double TAXA_EUA       = 1.37;
            const double TAXA_UK        = 0.82;
            const double TAXA_TURQUIA   = 2.19;

            if (Divisa == "r")
            {
                PrecoTaxa = Preco * TAXA_BRASIL;
                TotalDaTaxa = PrecoTaxa * 0.1;
                PrecoFinal += TotalDaTaxa + PrecoTaxa;
                return PrecoFinal;
            }
            if (Divisa == "d")
            {
                PrecoTaxa = Preco * TAXA_EUA;
                TotalDaTaxa = PrecoTaxa * 0.1;
                PrecoFinal = TotalDaTaxa + PrecoTaxa;
                return PrecoFinal;
            }
            if (Divisa == "l")
            {
                PrecoFinal += Preco * TAXA_UK;
                return PrecoFinal;
            }
            else if (Divisa == "t")
            {
                PrecoFinal += Preco * TAXA_TURQUIA;
                return PrecoFinal;
            }
            return PrecoFinal;
        }
        static void ConsultarTaxas(string Taxa)
        {
            if (Taxa == "s")
            {
                Console.WriteLine("Taxas:");
                Console.WriteLine("R-> 3,22");
                Console.WriteLine("D-> 1,37");
                Console.WriteLine("L-> 0,82");
                Console.WriteLine("T-> 2,19");
            }
        }
        static string Pais(string Divisa)
        {
            string Moeda = "";

            if (Divisa == "d")
                Moeda = "Dólares [ EUA ]";
            if (Divisa == "l")
                Moeda = "Libras Estrelinas [ UK ]";
            if (Divisa == "r")
                Moeda = "Reais [ Brasil ]";
            else if (Divisa == "t")
                Moeda = "Libras Turcas [ Turquia ]";

            return Moeda;
        }
    }
}