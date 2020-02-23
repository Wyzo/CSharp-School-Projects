using System;
using System.Linq;

namespace Desafio1_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] TemperaturasDiarias = new double[24];
            double Temperatura;
            for (int i = 0; i < TemperaturasDiarias.Length; i++)
            {
                Console.WriteLine("Valor lido às {0}:00: ", i);
                Temperatura = double.Parse(Console.ReadLine());
                TemperaturasDiarias[i] = Temperatura;
            }
            double TempMax = TemperaturasDiarias.Max();
            double TempMin = TemperaturasDiarias.Min();

            Console.WriteLine("Temperatura máxima = {0} || Temperatura mínima = {1}", TempMax, TempMin);
        }
    }
}
