using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeazoia
{
    class Program
    {
        static void Main(string[] args)
        {
            double Peso, Altura, IMC;
            Console.WriteLine("Digite o peso:");
            Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            Altura = double.Parse(Console.ReadLine());
            IMC = Peso / Math.Pow(Altura, 2);
            Console.WriteLine("IMC: {0:F2}", IMC);
            Console.ReadKey();
        }
    }
}
