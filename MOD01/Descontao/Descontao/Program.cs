using System;

namespace Descontao
{
    class Program
    {
        static void Main(string[] args)
        {
            int compra;
            double desconto10, desconto15;

            Console.WriteLine("Valor máximo de compra: 50000 euros");

            Console.WriteLine("\nQual é o preço total da compra ? ");
            compra = int.Parse(Console.ReadLine());

            if (compra < 1000)
            {
                Console.WriteLine("O valor da sua compra é {0} euros, sem desconto", compra);
            }
            else if (compra >= 1000 && compra < 5000)
            {
                desconto10 = 0.9 * compra;
                Console.WriteLine("O valor da sua compra é {0} euros, com 10% de desconto", desconto10);
            }
            else if (compra > 5000 && compra < 50000)
            {
                desconto15 = 0.85 * compra;
                Console.WriteLine("O valor da sua compra é de {0} euros, com 15% de desconto", desconto15);
            }
            else
            {
                Console.WriteLine("A sua compra excede o valor máximo");
            }
        }
    }
}
