using System;

namespace VerificacaoDoCC
{
    class Program
    {
        static void Main(string[] args)
        {
            int NIC, CD, Veri;

            Console.Write("NIC: ");
            NIC = int.Parse(Console.ReadLine());
            Console.Write("CD: ");
            CD = int.Parse(Console.ReadLine());

            Veri = NIC + CD % 3;

            if (Veri > 0)
            {
                Console.WriteLine("Incorreto.");
            }
            else if(Veri <= 0)
            {
                Console.WriteLine("Correto.");
            }


            Console.ReadKey();
        }
    }
}
