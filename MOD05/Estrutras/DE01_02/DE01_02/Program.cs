using System;

namespace DE01_02
{
    class Program
    {
        struct Atleta
        {
            string Nome;
            int NumProcesso;
            string Modalidade;
            double Peso;
            double Altura;
            DateTime DataNasc;

            public Atleta(string Nome_, int NumProcesso_, string Modalidade_, double Peso_, double Altura_, DateTime DataNas_)
            {
                Nome = Nome_;
                NumProcesso = NumProcesso_;
                Modalidade = Modalidade_;
                Peso = Peso_;
                Altura = Altura_;
                DataNasc = DataNas_;
            }

            public double IMC(double Altura, double Peso)
            {
                return Math.Round(Peso / Math.Pow(Altura, 2), 1);
            }

            public int Idade(DateTime DataNas)
            {
                DateTime Agora = DateTime.Now;
                int Idade = Agora.Year - DataNasc.Year;
                if (DataNasc.Date > Agora.AddYears(-Idade)) Idade--;
                return Idade;
            }

            public int getProcesso()
            {
                return NumProcesso;
            }

            public double getPeso()
            {
                return Peso;
            }

            public double getAltura()
            {
                return Altura;
            }

            public int getIdade()
            {
                return Idade(DataNasc);
            }

            public string getNome()
            {
                return Nome;
            }

            public string getModalidade()
            {
                return Modalidade;
            }
        }
        static void Main(string[] args)
        {
            Atleta[] Equipa = { new Atleta("Francisco", 21527, "futebol", 85.0, 1.87, new DateTime(2004, 5, 13)) , 
                new Atleta("Alberto", 22427, "escalada", 92.0, 1.77, new DateTime(2003, 7, 2))};

            for (int i = 0; i < Equipa.Length; i++)
                Console.WriteLine("Nome {0} | Modalidade {1} | Processo {2} | IMC {3} | Idade {4}", Equipa[i].getNome(), Equipa[i].getModalidade(), Equipa[i].getProcesso(), Equipa[i].IMC(Equipa[i].getAltura(), Equipa[i].getPeso()), Equipa[i].getIdade());

            int Fute = 0, Volei = 0, Ande = 0, Esca = 0;

            string[] Modalidade = new string[Equipa.Length];

            for (int i = 0; i < Equipa.Length; i++)
                Modalidade[i] = Equipa[i].getModalidade().ToLower().Trim();

            for (int i = 0; i < Modalidade.Length; i++)
            {
                if (Modalidade[i] == "futebol")
                    Fute++;
                else if (Modalidade[i] == "voleibol")
                    Volei++;
                else if (Modalidade[i] == "andebol")
                    Ande++;
                else
                    Esca++;
            }

            if (Fute > 0)
            {
                Console.WriteLine("\nFutebol");
                Console.WriteLine("Participantes de futebol {0}: ", Fute);
            }
            if (Volei > 0)
            {
                Console.WriteLine("\nVoleibol");
                Console.WriteLine("Participantes de voleibol {0}: ", Volei);
            }
            if (Ande > 0)
            {
                Console.WriteLine("\nAndebol");
                Console.WriteLine("Participantes de andebol {0}: ", Ande);
            }
            if (Esca > 0)
            {
                Console.WriteLine("\nEscalada");
                Console.WriteLine("Participantes de escalada {0}: ", Esca);
            }
        }
    }
}
