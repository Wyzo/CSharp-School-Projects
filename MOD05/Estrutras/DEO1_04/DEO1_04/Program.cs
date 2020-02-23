using System;

namespace DEO1_04
{
    class Program
    {
        struct Idade
        {
            DateTime DataNas;

            public Idade(DateTime DataNasc_)
            {
                this.DataNas = DataNasc_;
            }

            public int getIdate(DateTime DataAtual)
            {
                int Idade = DataAtual.Year - DataNas.Year;

                if (DataAtual.Month > DataNas.Month)
                    Idade++;
                else if (DataAtual.Month == DataNas.Month)
                {
                    if (DataAtual.Day >= DataNas.Day)
                        Idade++;
                    else
                        Idade--;
                }
                else
                    Idade--;

                return Idade;
            }
        }
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;
            Idade[] Aniversario = { new Idade( new DateTime(2004, 05, 13)) };
            Console.WriteLine(Aniversario[0].getIdate(dataAtual));
        }
    }
}
