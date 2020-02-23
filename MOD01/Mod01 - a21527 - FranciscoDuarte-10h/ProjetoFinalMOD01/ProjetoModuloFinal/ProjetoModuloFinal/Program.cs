using System;

namespace ProjetoModuloFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dados de entrada
            double Corrente; 

            //Dados intermédios
            double AtrasoDaCorrente, MetrosRestantes, MetrosPorSegundo;
            
            //Constantes
            const double VELO_REMO = 1.5;
            const double ATRASO = 0.05;
            const int DISTANCIA = 150;

            //Dados de saída
            double SegundosNecessarios;
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Digite a corrente (M/s)");
            Corrente = double.Parse(Console.ReadLine());

            AtrasoDaCorrente = ATRASO * Corrente / 0.1;
            MetrosPorSegundo = VELO_REMO - AtrasoDaCorrente;
            MetrosRestantes = DISTANCIA - (MetrosPorSegundo * 100);
            SegundosNecessarios = Math.Floor(MetrosRestantes / MetrosPorSegundo) + 100;

            Console.WriteLine(SegundosNecessarios);

        }
    }
}
