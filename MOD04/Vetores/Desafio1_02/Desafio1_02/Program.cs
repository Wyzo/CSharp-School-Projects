using System;

namespace Desafio1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] RegistroKm = new double[7];
            double Km;
            double KmTotais = 0;

            for (int i = 0; i < RegistroKm.Length ; i++)
            {
                Console.Write("Registro de Km's: ");
                Km = double.Parse(Console.ReadLine());
                RegistroKm[i] = Km;
                KmTotais += Km;
            }
            Console.WriteLine(KmTotais);
        }
    }
}
