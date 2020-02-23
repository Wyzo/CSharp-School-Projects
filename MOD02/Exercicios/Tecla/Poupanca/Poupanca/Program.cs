using System;

namespace Poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double Dinheiro, Juros;
            int Anos;

            Console.Write("Digite o montante a depositar: ");
            Dinheiro = double.Parse(Console.ReadLine());

           do
            {
                Console.Write("Digite o montante a depositar: ");
                Dinheiro = double.Parse(Console.ReadLine());
            } while (Dinheiro <= 0);

            Console.Write("Juros da poupança: ");
            Juros = int.Parse(Console.ReadLine());

            Console.Write("Quantia de anos: ");
            Anos = int.Parse(Console.ReadLine());

            for (int i = 1; i < Anos + 1; i++)
            {
                Dinheiro += Dinheiro * (Juros / 100);
                Console.WriteLine("{0}º ano = {1:F2}", i, Dinheiro);
            }
            Console.ReadKey();
        }
    }
}
