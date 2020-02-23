using System;

namespace Desafio1_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int RegistroCarros;

            int[] Carros = new int[6];
            string[] DiasDaSemana = { "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexa-Feira", "Sábado" };

            int CarrosPares = 0;
            int CarrosImpares = 0;

            for (int i = 0; i < Carros.Length; i++)
            {
                Console.Write("Carros na {0}: ", DiasDaSemana[i]);
                RegistroCarros = int.Parse(Console.ReadLine());
                Carros[i] = RegistroCarros;
                if (i % 2 == 0)
                    CarrosPares += Carros[i];
                else
                    CarrosImpares += Carros[i];
            }
            string Resp = determinarFechagem(CarrosPares, CarrosImpares);
            Console.WriteLine(Resp);
        }
        static string determinarFechagem(int CarrosPares, int CarrosImpares)
        {
            string Resp = "";
            if (CarrosPares > CarrosImpares)
                Resp = "É necessário fechar em dias Pares";
            else
                Resp = "É necessário fechar em dias Impares";
            return Resp;
        }
    }
}
