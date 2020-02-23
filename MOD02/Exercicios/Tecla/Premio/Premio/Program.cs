using System;

namespace Premio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double Dinheiro, Premios = 0;
            int Lugar = 1;

            Console.Write("Valor para distribuir: ");
            Dinheiro = int.Parse(Console.ReadLine());
            
            do
            {
                Console.WriteLine("{0}º lugar - {1} euros!", Lugar, Dinheiro / 2);
                Lugar++;
                Dinheiro -= Math.Round(Dinheiro / 2, 0);
                Premios += Dinheiro;
            } while (Dinheiro / 4 > 50);

            Console.ReadKey();
        }
    }
}