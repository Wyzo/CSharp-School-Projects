using System;

namespace ProvaAutomobilismo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dados de entrada
            int ComprimentoPista, VoltasDaProva, ConsumoMedio, Capacidade;

            //Dados de saída
            int Depósitos;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Comprimento da pista: [Km's]");
            ComprimentoPista = int.Parse(Console.ReadLine());

            Console.Write("Número de voltas: ");
            VoltasDaProva = int.Parse(Console.ReadLine());

            Console.Write("Consumo médio: (0-100 Km's/h [Litros]) ");
            ConsumoMedio = int.Parse(Console.ReadLine());

            Console.Write("Capacidade do tanque: [Litros] ");
            Capacidade = int.Parse(Console.ReadLine());

        }
    }
}
