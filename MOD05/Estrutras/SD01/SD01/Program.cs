using System;

namespace SD01
{
    class Program
    {
        struct Equipa
        {
            int Pontos, golosMarcados, golosSofridos;

            public Equipa(int Pontos, int golosMarcados, int golosSofridos)
            {
                this.Pontos = Pontos;
                this.golosMarcados = golosMarcados;
                this.golosSofridos = golosSofridos;
            }
        }
        static void Main(string[] args)
        {
            string[] Equipas = { };

            Equipas = Console.ReadLine().Split(' ');

            Console.WriteLine(Equipas.Length);

            string[] Resposta = { };
            string[] Casa = new string[Equipas.Length];
            string[] Fora = new string[Equipas.Length];

            Console.WriteLine("Digite os resultados: \"Equipa\" \"Golos\" \"Equipa\" \"Golos\"");
            for (int i = 0; i < Equipas.Length; i++)
            {
                Resposta = Console.ReadLine().Split();
                Casa[i] = Resposta[0];
                Fora[i] = Resposta[2];
            }
            dadosSaida(Casa, Fora);
        }
        static void dadosSaida(string[] Casa, string[] Fora)
        {
            Console.WriteLine("Resultados");
            for (int i = 0; i < Casa.Length; i++)
            {
                Console.Write("\t{0}", Casa[i]);
            }
            Console.WriteLine();
            for (int j = 0; j < Fora.Length; j++)
            {
                Console.WriteLine("\n{0}", Fora[j]);
            }
        }
    }
}
