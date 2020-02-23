using System;
using System.Linq;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string Senha;
            bool Resultado;

            Console.Write("Digite a sua senha: ");
            Senha = Console.ReadLine();

            if (Senha.Contais())
            {
                Console.Write(true);
            }
            else
                Console.Write(false);
            Console.ReadKey();
        }
    }
}
