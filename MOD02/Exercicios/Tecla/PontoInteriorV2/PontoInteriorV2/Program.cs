using System;

namespace PontoInteriorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            double P0_X, P0_Y, P1_X, P1_Y, P2_X, P2_Y;
            double xMax, xMin, yMax, yMin;
            string Resp;

            Console.Write("Coordenadas do ponto (x)?: ");
            P0_X = double.Parse(Console.ReadLine());
            Console.Write("Coordenadas do ponto (y)?: ");
            P0_Y = double.Parse(Console.ReadLine());

            Console.Write("Coordenadas do extremo (x1): ");
            P1_X = double.Parse(Console.ReadLine());
            Console.Write("Coordenadas do extremo (y1): ");
            P1_Y = double.Parse(Console.ReadLine());

            Console.Write("Coordenadas do extremo (x2): ");
            P2_X = double.Parse(Console.ReadLine());
            Console.Write("Coordenadas do extremo (y2): ");
            P2_Y = double.Parse(Console.ReadLine());

            if(P1_X > P2_X)
            {
                xMax = P1_X;
                xMin = P2_X;
            }
            else
            {
                xMax = P2_X;
                xMin = P1_X;
            }
            if (P1_Y > P2_Y)
            {
                yMax = P1_Y;
                yMin = P2_Y;
            }
            else
            {
                yMax = P2_Y;
                yMin = P1_Y;
            }
            if ((P0_X > xMin && P0_X < xMax) && (P0_Y > yMin && P0_Y < yMax))
                Console.WriteLine("Está dentro!");
            else
                Console.WriteLine("Está fora!");

            Resp = "Está dentro";

            Console.ReadKey();
        }
    }
}
