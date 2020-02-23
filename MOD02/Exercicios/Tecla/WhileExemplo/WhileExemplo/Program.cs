using System;

namespace WhileExemplo
{
    class Program
    {   
        static void Main(string[] args)
        {
            int Nivel;
            //1 - 10 || 1 - 100 || 1 - 10000
            Console.Write("Nível: (1 = Easy || 2 = Medium || 3 = Hard)");
            Nivel = int.Parse(Console.ReadLine());
            int NumEsc;
            int ten = 0;

            Random random = new Random();
            int Num = random.Next(1, (int) Math.Pow(10, Nivel));

            DateTime InicioJogo = DateTime.Now;

            do
            {
                Console.Write("Num: ");
                NumEsc = int.Parse(Console.ReadLine());
                if (Num <= NumEsc)
                {
                    Console.WriteLine("O numero é mais pequeno.");

                }
                else
                    Console.WriteLine("O numero é maior.");
                ten++;
            }
            while (Num != NumEsc);

            Console.WriteLine("O número é {0}", Num);
            Console.WriteLine("Tentativas {0}", ten);
            Console.ReadKey();
        }
    }
}
