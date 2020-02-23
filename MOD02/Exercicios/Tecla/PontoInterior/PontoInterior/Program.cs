using System;

namespace PontoInterior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double P0_X, P0_Y, P1_X, P1_Y, P2_X, P2_Y;
            int Resp;
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

            if(P0_X < 0 )
            {
                if (P0_X < P1_X && P0_X < P2_X)
                {
                    Resp = 1;
                }
                else
                {
                    Resp = 2;
                }
            }
            else
            {
                if (P0_X > P1_X && P0_X > P2_X)
                {
                    Resp = 1;
                }
                else
                {
                    Resp = 2;
                }
            }

            if(Resp == 2)
            {
                if (P0_Y < 0)
                {
                    if (P0_Y < P1_Y && P0_Y < P2_Y)
                    {
                        Resp = 1;
                    }
                    else
                    {
                        Resp = 2;
                    }
                }
                else
                {
                    if (P0_Y > P1_Y && P0_Y > P2_Y)
                    {
                        Resp = 1;
                    }
                    else
                    {
                        Resp = 2;
                    }
                }
                if(Resp == 2)
                {
                    Console.WriteLine("O ponto está dentro!");
                }
            }
            else
            {
                Console.WriteLine("O ponto está fora!");
            }
            Console.ReadKey();
        }
    }
}