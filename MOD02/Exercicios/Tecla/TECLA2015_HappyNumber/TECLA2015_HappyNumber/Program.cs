using System;

namespace TECLA2015_HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int     Numero;
            double  Resultado, Teste;

            Console.Write("Digite o número: ");
            Numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < Numero ; i--)
            {
                Resultado = Math.Floor(Math.Sqrt(Numero));
                Teste = Resultado;
                Console.WriteLine(Teste);
            }
            Console.ReadKey();
        }
    }
}
