using System;

namespace RevisaoTesteMOD2
{
    class Program
    {
        static void Main(string[] args)
        {
            int PrecoBase;
            string Pais;

            Console.Write("Preço base: ");
            PrecoBase = int.Parse(Console.ReadLine());

            Console.Write("País de origem: ");
            Pais = Console.ReadLine().ToLower().Trim();

            caluculaPrecoFinal(PrecoBase, Pais);

            Console.ReadKey();

        }
        static double caluculaPrecoFinal(int PrecoBase, string Pais)
        {
            double PrecoFinal   = 0;
            double Taxa         = 0;

            if (PrecoBase < 0)
                Console.WriteLine("O preço dos livros deverá ser superior que zero.");
            else{
                PrecoFinal = PrecoBase;
                //if(Pais.Equals("portugal", StringComparison.OrdinalIgnoreCase))
                /*if(Pais == "portugal")
                    Taxa = 0;
                else if(Pais == "moçambique" || Pais == "angola" || Pais == "cabo verde" || Pais == "brasil")
                    Taxa = 0.05;
                else
                    Taxa = 0.1*/
                switch (Pais)
                {
                    case "portugal":
                        Taxa = 0;
                        break;
                    case "moçambique":
                    case "angola":
                    case "cabo verde":
                    case "brasil":
                        Taxa = 0.05;
                        break;
                    default:
                        Taxa = 0.1;
                        break;
                }
            }
            PrecoFinal += PrecoFinal * Taxa;
            if (PrecoBase >= 50)
                PrecoFinal = PrecoFinal + 2;

            Console.WriteLine("Preço final {0} euros.", Math.Round(PrecoFinal, 2));

            return PrecoFinal;
        }
    }
}
