using System;

namespace MO5_REVISOES
{
    class Program
    {
        struct Funcionario 
        {
            string Nome_;
            string Departamento_;
            double VencimentoBruto_;
            DateTime DataDeEntrada_;

            public Funcionario(string Nome, string Departamento, double VencimentoBruto, DateTime DataEntrada)
            {
                Nome_ = Nome;
                Departamento_ = Departamento;
                VencimentoBruto_ = VencimentoBruto;
                DataDeEntrada_ = DataEntrada;
            }

            public double getValorSS()
            {
                return VencimentoBruto_ * 0.18;
            }

            public double IRS()
            {
                return VencimentoBruto_ * 0.23;
            }

            public double getAdicoes(int Dias)
            {
                return 4.77 * Dias;
            }

            public double getVencimentoLiquido()
            {
                return VencimentoBruto_ - IRS() - getValorSS();
            }

            public string getNome()
            {
                return Nome_;
            }

            public override string ToString()
            {
                return "\nNome: " + Nome_ + " - \nDepartamento: " + Departamento_ + " - \nVencimento Líquido: " + getVencimentoLiquido() + " euros.";
            }
        }
        static void Main(string[] args)
        {
            Funcionario[] Trabalhador = 
            { 
                new Funcionario("Francisco", "Informática", 1000, new DateTime(2002, 02, 04)),
                new Funcionario("Alberto", "Informática", 900, new DateTime(2005, 03, 12)),
                new Funcionario("Mariana", "Informática", 1200, new DateTime(2003, 11, 09)),
                new Funcionario("Carla", "Embalalagens", 700, new DateTime(2001, 05, 15)),
                new Funcionario("Ricardo", "Manutenção", 1400, new DateTime(1998, 11, 17))
            };

            char Resp = ' ';
            string Nome = " ";

            do
            {
                Console.Clear();
                Menu();
                Console.WriteLine("Opção");
                Console.Write("> ");
                Resp = Char.Parse(Console.ReadLine());

                switch (Resp)
                {
                    case '1':
                        Console.Clear();
                        listarFuncionarios(Trabalhador);
                        Console.WriteLine("Pressione qualquer tecla para terminar..");
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        procurarFuncionario(Trabalhador);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Você saiu do programa");
                        break;
                }
                Console.ReadKey();
            } while (Resp != '0');
        }
        static void Menu()
        {
            Console.WriteLine("-        Menu       -");
            Console.WriteLine("1 [Listagem funcionários]     -");
            Console.WriteLine("2 [Pesquisar funcionário]     -");
            Console.WriteLine("3 [Processamento salário]     -");
            Console.WriteLine("4 [Aumento de salários]       -");
            Console.WriteLine("5 [Graduação de funcionários] -");
            Console.WriteLine("6 [Consulta de departamento]  -");
            Console.WriteLine("0 [Sair]");
            Console.Write("\n> ");
        }

        static void listarFuncionarios(Funcionario[] Trabalhador)
        {
            for (int i = 0; i < Trabalhador.Length; i++)
                Console.WriteLine(Trabalhador[i].ToString());
        }
        
        static void procurarFuncionario(Funcionario[] Trabalhador)
        {
            Console.WriteLine("Nome do funcionário");
            string Nome = Console.ReadLine();

            foreach(var item in Trabalhador)
            {
                if(item.getNome().ToLower().Contains(Nome.ToLower()))
                    Console.WriteLine(item.ToString());
            }
        }
    }
}
