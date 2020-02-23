using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int Jurados;
            Console.Write("Jurados: ");
            Jurados = int.Parse(Console.ReadLine());

            string[] Votacoes = new string[Jurados];

            int A = 0, B = 0;
            string Nota;

            for (int i = 0; i < Votacoes.Length; i++)
            {
                Votacoes = Console.ReadLine().ToLower().Split(' ');
                if (Votacoes[i] == "a")
                    A++;
                else
                    B++;
            }
            if (A > B)
                Console.WriteLine("A");
            else if(B > A)
                Console.WriteLine("B");
            else
                Console.WriteLine("Empate");*/
            Console.Write("Jurados:");
            int Jurados = int.Parse(Console.ReadLine());

            int A = 0, B = 0;

            string Resultados = Console.ReadLine().ToLower();
            string[] valores = Resultados.Split().ToArray();

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == "a")
                    A++;
                else
                    B++;
            }

            if(A > B)
                Console.WriteLine("A");
            else if(B > A)
                Console.WriteLine("B");
            else
                Console.WriteLine("Empate");
        }
    }
}
