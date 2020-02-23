using System;
using System.Diagnostics;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nome, Cidade;
            int Dia, Mes, Ano;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite o seu nome: ");
            Nome = Console.ReadLine();
            
            Console.Write("Digite a sua cidade: ");
            Cidade = Console.ReadLine();
            
            Console.Write("Digite o dia de seu nascimento: ");
            Dia = int.Parse(Console.ReadLine());
            while (Dia > 31)
            {
                Console.Write("O dia de nascimento não pode ser superior que 31!");
                Console.Write("\nDigite o dia de seu nascimento: ");
                Dia = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite o mês de seu nascimento: ");
            Mes = int.Parse(Console.ReadLine());
            while (Mes > 12)
            {
                Console.Write("O Mês de nascimento não pode ser superior que 12!");
                Console.Write("\nDigite o Mês de seu nascimento: ");
                Mes = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite o ano de seu nascimento: ");
            Ano = int.Parse(Console.ReadLine());
            while (Ano > 2019)
            {
                Console.Write("O Ano de nascimento não pode ser superior que 2019!");
                Console.Write("\nDigite o Ano de seu nascimento: ");
                Ano = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("Localidade: {0} ", Cidade);
            Console.WriteLine("\nData de Nascimento: {0}/{1}/{2}", Dia, Mes, Ano);
            
        }
    }
}