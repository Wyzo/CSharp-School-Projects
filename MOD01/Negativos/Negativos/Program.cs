using System;

namespace Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            double Graus, Minutos, Segundos;
            double GrausDecimais;

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write("Graus? (-90 até 90) ");
            Graus = double.Parse(Console.ReadLine());
            Console.Write("Minutos? (de 0 a 59. Caso sejam 60 digite 0) ");
            Minutos = double.Parse(Console.ReadLine());
            Console.Write("Segundos? (de 0 a 59. Caso sejam 60 digite 0) ");
            Segundos = double.Parse(Console.ReadLine());

            GrausDecimais = Math.Round(Graus + Minutos / 60 + Segundos / 3600);


            Console.WriteLine("\nGraus decimais: {0} ", GrausDecimais);
        }
    }
}
