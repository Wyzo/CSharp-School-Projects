using System;

namespace Desafio02_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string Texto;
            Texto = Console.ReadLine();

            int[] Total = new int[Texto.Length];
            char[] alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < 26; i++)
            {
                Total[i] = Texto.Length - Texto.Replace(alfa[i], ' ').Length;
            }
            foreach (char item in alfa)
            {
                for (int i = 0; i < 26; i++)
                    Console.Write("{0} = {1}", alfa[i], item);
            }
        }
    }
}
