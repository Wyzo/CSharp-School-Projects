using System;
using System.Linq;

namespace Desafio1_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Malas = new string[10];

            for (int i = 0; i != Malas.Length; i++)
            {
                Console.Write("Nome do passageiro: ");
                string Passageiro = Console.ReadLine();
                Malas[i] = Passageiro;
            }
            Console.WriteLine("Desembarque");
            reverterMalas(Malas);
        }
        static void reverterMalas(string[] Malas) 
        {
            for (int i = Malas.Length - 1; i >= 0; i--) Console.WriteLine(Malas[i]);
        }
    }
}
