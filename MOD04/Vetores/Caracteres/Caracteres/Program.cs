using System;

namespace Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            string Texto;
            int Vogais = 0;
            int Caracteres;
            int Outros;

            Console.Write("Texto: ");
            Texto = Console.ReadLine().ToLower();

            Caracteres = Texto.Length - Vogais;

            for (int i = 0; i < Caracteres; i++)
            {
                if (Texto[i] == 'a' || Texto[i] == 'e' || Texto[i] == 'i' || Texto[i] == 'o' || Texto[i] == 'u')
                    Vogais++;
            }
            Outros = Caracteres - Vogais;
            Console.WriteLine("Tem {0} vogais e {1} caracteres.", Vogais, Outros);
        }
    }
}
