using System;

namespace DE01_06
{
    class Program
    {
        struct Cliente
        {
            public string BI_, Nome_, Localidade_, Observacoes_;
            public int Idade_;
            public double ValorPago_;

            public Cliente(string BI, string Nome, string Localidade, string Observacoes, int Idade, double ValorPago)
            {
                BI_ = BI;
                Nome_ = Nome;
                Localidade_ = Localidade;
                Observacoes_ = Observacoes;
                Idade_ = Idade;
                ValorPago_ = ValorPago;
            }

            //Calcula o dinheiro que falta por pagar
            public double getDinheiroPorDever()
            {
                return 1000 - ValorPago_;
            }

            public override string ToString()
            {
                return "BI: " + BI_ + " Nome: " + Nome_ + " Localidade: " + Localidade_ + " Observações: " + Observacoes_ +
                    " Idade: " + Idade_ + " Valor pago: " + ValorPago_ + "/1000 euros" + " -- Por dever: " + getDinheiroPorDever();
            }

            public double getDinheiro()
            {
                return ValorPago_;
            }

            public string getNome()
            {
                return Nome_;
            }
        }
        static void Main(string[] args)
        {
            string[] Resp;
            int Pessoas;
            Console.Write("Quantos excursistas vão participar na visita: ");
            Pessoas = int.Parse(Console.ReadLine());

            Cliente[] Pessoa = new Cliente[Pessoas];

            for (int i = 0; i < Pessoa.Length; i++)
            {
                Console.WriteLine("BI | Nome | Localidade | Observações | Idade | Valor pago");
                Resp = Console.ReadLine().Split(' ');
                Pessoa[i].BI_ = Resp[0];
                Pessoa[i].Nome_ = Resp[1];
                Pessoa[i].Localidade_ = Resp[2];
                Pessoa[i].Observacoes_ = Resp[3];
                Pessoa[i].Idade_ = int.Parse(Resp[4]);
                Pessoa[i].ValorPago_ = double.Parse(Resp[5]);
            }

            Console.Clear();

            foreach (var item in Pessoa)
            {
                if(item.getDinheiro() < 1000)
                    Console.WriteLine("{0} -- AVISO! Ainda não pagou a totalidade: {1}/1000 euros - {2} euros por pagar.", item.getNome(), item.getDinheiro(), item.getDinheiroPorDever());
                else
                    Console.WriteLine("Você já pagou a totalidade.");
            }

            Console.WriteLine("\nDívida total dos clientes {0} euros.", getTotalValor(Pessoa));
        }

        //Genera um número aleatório de 0 - Pessoa.Lenght (Comprimento do vetor);
        static void getRandomPerson(Cliente[] Pessoa)
        {
            Random rand = new Random(Pessoa.Length);
            Console.WriteLine(Pessoa[rand.Next(0, Pessoa.Length)]);
        }

        static int getDinheiro()
        {
            int Resp;

            if (getDinheiro() < 1000)
                Resp = 1;
            else
                Resp = 2;

            return Resp;
        }

        static double getTotalValor(Cliente[] Pessoa)
        {
            double ValorTotal = 0;

            for (int i = 0; i < Pessoa.Length; i++)
                ValorTotal += 1000 - Pessoa[i].getDinheiro();

            return ValorTotal;
        }
    }
}
