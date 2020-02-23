using System;

namespace Desafio02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double Temperatura = 0;
            int Temp1, Temp2;
            int Maior = 0, Menor = 0;

            for (int i = 1; i <= 8; i++)
            {
                Temp2 = int.Parse(Console.ReadLine());
                if (Temp2 > Temperatura)
                {
                    Maior = Temp2;
                    Menor = Temperatura;
                }
                else
                {
                    Maior = Temp1;
                    Menor = Temp2;
                }
                Console.WriteLine("teste");
            }
            Console.WriteLine("Maior {0} menor {1}", Maior, Menor);
            Console.ReadKey();
        }
    }
}
