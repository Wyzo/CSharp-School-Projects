using System;

namespace RubenRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Código criado por Francisco Duarte

            Console.ForegroundColor = ConsoleColor.Green;
            double Peso, Altura, AlturaAoQuadrado, IMC;

            Console.Write("Digite o seu peso: ");
            Peso = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            Altura = double.Parse(Console.ReadLine());

            AlturaAoQuadrado = Math.Pow(Altura, 2);
            IMC = Peso / AlturaAoQuadrado;

            Console.WriteLine("O valor do seu IMC é de {0:F0}", IMC);
        }
    }
}
