using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            char Resposta;
            int Quantia;
            
            Console.Write("--------------------------------------");
            Console.Write("\nIniciar processo de compra [S/N]");
            Console.Write("\n> ");
            Resposta = char.Parse(Console.ReadLine().ToLower());
            switch (Resposta)
            {
                case 's':
                    Console.Clear();
                    Console.WriteLine("Começe a digitar o nome dos produtos e depois o preço.");
                    Console.Write("--terminar para terminar o processo.\n\n");
                    Console.WriteLine("Digite o nome do produto separado por '_'");
                    Console.WriteLine("Ex: NOME_PRODUTO PRECO");
                    Console.Write("Quantia: ");
                    Quantia = int.Parse(Console.ReadLine());
                    registrarCompras(Quantia);
                    break;
                case 'n':
                    break;
            }
        }
        static void registrarCompras(int QuantiaProdutos)
        {
            string[] NomeProdutos = { };
            double[] Precos = { };

            string[] Nome;

            for (int i = 0; i < QuantiaProdutos; i++)
            {
                Console.Write("> ");
                Nome = Console.ReadLine().Split();
                NomeProdutos = Nome[i];
                Precos[i] = double.Parse(Nome[i + 1]);
                if (Nome[i] == "--terminar")
                    break;
            }
        }
        static double precoFinal(double[] Precos)
        {
            double PrecoFinal = 0;

            foreach (double item in Precos)
                PrecoFinal += item;

            return PrecoFinal;
        }
    }
}
