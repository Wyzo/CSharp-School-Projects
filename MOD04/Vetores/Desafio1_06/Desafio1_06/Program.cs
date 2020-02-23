using System;

namespace Desafio1_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Peixe = new string[5];
            string[] Carne = new string[5];

            string Nome = "";

            for (int i = 0; i < Peixe.Length; i++)
            {
                Console.Write("Prato de peixe: ");
                Nome = Console.ReadLine();
                Peixe[i] = Nome;
            }

            for (int i = 0; i < Carne.Length; i++)
            {
                Console.Write("Prato de carne: ");
                Nome = Console.ReadLine();
                Carne[i] = Nome;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Carne[i]);
                Console.WriteLine(Peixe[i]);
            }
        }
    }
}
