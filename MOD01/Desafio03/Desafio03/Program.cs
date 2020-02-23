using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            string Nome1, Nome2, Nome3;
            double Pontos1, Pontos2, Pontos3, Maior;


            Console.Write("Qual é o nome do primeiro aluno? ");
            Nome1 = Console.ReadLine();
            Console.Write("Qual é o nome do segundo aluno? ");
            Nome2 = Console.ReadLine();
            Console.Write("Qual é o nome do terceiro aluno? ");
            Nome3 = Console.ReadLine();
            Console.Write("Quantos pontos teve o(a) {0}: ", Nome1);
            Pontos1 = double.Parse(Console.ReadLine());
            Console.Write("Quantos pontos teve o(a) {0}: ", Nome2);
            Pontos2 = double.Parse(Console.ReadLine());
            Console.Write("Quantos pontos teve o(a) {0}: ", Nome3);
            Pontos3 = double.Parse(Console.ReadLine());

            if (Pontos1 > Pontos2)
            {
                if (Pontos1 > Pontos3)
                {
                    Maior = Pontos1;
                }
                else
                {
                    Maior = Pontos3;
                }
            }
            else if (Pontos2 > Pontos3)
                Maior = Pontos2;
            else
                Maior = Pontos3;
            Console.WriteLine("Pessoa(s) com mais pontos: ");
            if ((Maior == Pontos2) || (Maior == Pontos3) || (Maior == Pontos1))
            {
                Console.Write("Houve um empate!");
            }

            Console.ReadKey();
        }
    }
}
