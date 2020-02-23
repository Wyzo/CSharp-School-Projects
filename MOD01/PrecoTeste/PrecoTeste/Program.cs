using System;

namespace PrecoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados de entrada
            double Preco, Quantia;

            //Cálculos auxiliares
            double Resto, Percentagem;

            int QuantiaDeProdutos;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Qual o preço do produto (Euros): ");
            Preco = double.Parse(Console.ReadLine());

            Console.Write("Qual a sua quantia de dinheiro: ");
            Quantia = double.Parse(Console.ReadLine());

            QuantiaDeProdutos = (int) (Quantia / Preco);
            Resto = (Quantia % Preco);
            Percentagem = (Resto / Quantia) * 100;
            
            Console.WriteLine("{0} embalagens.", QuantiaDeProdutos);
            Console.WriteLine("Sobra(m) {0:F2} euro(s) e {1:F2}% da quantia inicial.", Resto, Percentagem);
        }
    }
}
