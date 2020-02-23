using System;

namespace DE01_07
{
    class Program
    {
        struct Automovel
        {
            string Matricula, Marca, Modelo;
            DateTime DataAquisicao;
            double PrecoCompra, PrecoVenda;
            bool Vendido;
            public Automovel(string Matricula_, string Marca_, string Modelo_, DateTime DataAquisicao_, double PrecoCompra_, double PrecoVenda_, bool Vendido_)
            {
                Matricula = Matricula_;
                Marca = Marca_;
                Modelo = Modelo_;
                DataAquisicao = DataAquisicao_;
                PrecoCompra = PrecoCompra_;
                PrecoVenda = PrecoVenda_;
                Vendido = Vendido_;
            }

            public double getPercentagem()
            {
                return Math.Round(100 * PrecoVenda / PrecoCompra, 2);
            }

            public int getDias()
            {
                int DiasTotais = 1;

                DateTime DataAtual = DateTime.Now;

                if(DataAquisicao.Year < DataAtual.Year)
                {
                    DiasTotais += 365 * (DataAtual.Year - DataAquisicao.Year);
                    if (DataAquisicao.Month == DataAtual.Month)
                    {
                        if (DataAquisicao.Day < DataAtual.Day)
                            DiasTotais += 1 * (DataAtual.Day - DataAquisicao.Day);
                    }
                    else if (DataAquisicao.Month < DataAtual.Month)
                    {
                        DiasTotais += 31 * (DataAquisicao.Month - DataAtual.Month);
                    }
                }
                else if(DataAquisicao.Year == DataAtual.Year)
                {
                    if(DataAquisicao.Month == DataAtual.Month)
                    {
                        if (DataAquisicao.Day < DataAtual.Day)
                            DiasTotais += 1 * (DataAtual.Day - DataAquisicao.Day);
                    }
                    else if (DataAquisicao.Month < DataAtual.Month)
                    {
                        DiasTotais += 31 * DataAquisicao.Month - DataAtual.Month;
                        if (DataAquisicao.Day < DataAtual.Day)
                            DiasTotais += 1 * (DataAtual.Day - DataAquisicao.Day);
                    }
                }
                return DiasTotais;
            }
        }
        static void Main(string[] args)
        {
            Automovel[] Carros = { 
                new Automovel("a5-25-14", "Mercedes", "amg", new DateTime(2020, 2, 12), 15000, 13500, true),
                new Automovel("v7-16-jj", "Opel", "Corsa", new DateTime(2020, 2, 18), 10000, 8600, true),
                new Automovel("a5-25-14", "Mercedes", "amg", new DateTime(2020, 2, 12), 11000, 0, true)};


            for (int i = 0; i < Carros.Length; i++)
                Console.WriteLine("{0} Dia(s).", Carros[i].getDias());
        }
    }
}
