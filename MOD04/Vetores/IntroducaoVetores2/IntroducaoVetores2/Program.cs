using System;
using System.Linq;

namespace IntroducaoVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Alturas = { 190, 195, 205, 198, 176 };
            string[] Nomes = { "Carlos", "Pedro", "Filipe", "Paulo", "Gaspar"};
            char[] Letras = { 'A', 'B', 'C', 'D' };

            int Largura = Nomes[0].Length;
            int maiValor = Alturas.Max();
            int maiIndex = Alturas.ToList().IndexOf(maiValor);

            for (int j = 0; j < Nomes.Length; j++)
            {
                if (Nomes[j].Length > Largura)
                    Largura = Nomes[j].Length;
            }
            for (int i = 0; i < Alturas.Length; i++) 
            { 
               Console.WriteLine("{0," + Largura + "}:{1} cm", Nomes[i], Alturas[i]); 
            }

            Console.WriteLine("O atleta com maior altura é {0}", Nomes[maiIndex]);
            Console.WriteLine("Média dos atletas: {0} cm", Math.Round(Alturas.Average(), 1));
            //Para centralizar algo na consola
            /*string hello = "Hello, World!";
            Console.SetCursorPosition(Console.WindowWidth / 2 - hello.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(hello);*/

            string Num = Console.ReadLine();
            for (int i = Num.Length - 1; i >= 0; i--)
            {
                Console.Write(Num[i]);
            }

            /*char[] Reverter = Num.ToString().ToCharArray();
            Array.Reverse(Reverter);
            Console.WriteLine(int.Parse(new string(Reverter)));*/
        }
    }
}