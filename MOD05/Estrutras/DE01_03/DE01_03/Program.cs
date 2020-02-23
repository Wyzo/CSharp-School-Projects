using System;
using System.Linq;

namespace DE01_03
{
    class Program
    {
        struct Moeda
        {
            string nomeMoeda;
            string paisDeOrigem;
            string Abreviatura;
            double Cota;

            public Moeda (string nomeMoeda_, string paisDeOrigem_, string Abreviatura_, double Cota_)
            {
                nomeMoeda = nomeMoeda_;
                paisDeOrigem = paisDeOrigem_;
                Abreviatura = Abreviatura_;
                Cota = Cota_;
            }

            public string Listar(double Quantia)
            {
                return nomeMoeda + " = " + Math.Round((Quantia * Cota), 2);
            }

        }
        static void Main(string[] args)
        {
            Moeda[] Divisas = { new Moeda("R$", "brasil", "brl", 4.72),
            new Moeda("Kz$", "angola", "ang", 541.87),
            new Moeda("Ars$", "argentina", "ars", 45.65),
            new Moeda("Dollars$", "estados unidos da américa", "usd", 0.92),
            new Moeda("Cop$", "colombia", "cop", 2566.03)};

            double Quantia;

            Console.WriteLine("Digite a quantia que deseja verificar!");
            Console.Write("> ");
            Quantia = double.Parse(Console.ReadLine());

            foreach (var verify in Divisas)
                Console.WriteLine(verify.Listar(Quantia));

            /*Divisas[0] = new Moeda("real", "brasil", "brl", 3.250382);
            Divisas[1] = new Moeda("ang", "angola", "ang", 1.1928);
            Divisas[2] = new Moeda("ars", "argentina", "ars", 45.67566);
            Divisas[3] = new Moeda("usd", "estados unidos da américa", "usd", 0.75245);
            Divisas[4] = new Moeda("cop", "colombia", "cop", 2566.03135);*/

            double[] Valores = new double[5];
            double[] Resultados = new double[5];

        }
    }
}
