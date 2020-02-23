using System;

namespace TesteIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade;
            bool comp;
            char resp;
            Console.Write("Idade:");
            Idade = int.Parse(Console.ReadLine());
            Console.Write("Companheiro:(S/N)");
            resp = char.Parse(Console.ReadLine().ToUpper());
            if (Idade >= 18)
            {
                if (Idade >= 25)
                    Console.WriteLine("vip");
                else
                    Console.WriteLine("clube");
            }
            else
            {
                Console.WriteLine("novo");
            }
            /*Console.Write("Idade:");
            Idade = int.Parse(Console.ReadLine());
            if (Idade == 3)
                Console.Write("true");
            else*/
            Console.ReadKey();
        }
    }
}