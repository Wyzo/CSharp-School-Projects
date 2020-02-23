using System;

namespace MOD3_PROJETOFINAL_NIVEL3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int Ano, Mes;

            Ano = int.Parse(Console.ReadLine());
            Mes = int.Parse(Console.ReadLine());

            Calendario(Ano, Mes);
            Feriados(Mes);
            DiasUteis(Ano, Mes);

            Console.WriteLine();
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //Código https://stackoverflow.com/questions/43024083/full-year-calendar-in-c-sharp
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <param name="Ano"></param>
        ///<param name="Mes"></param>
        static void Calendario(int Ano, int Mes)
        {
            int Dia = DateTime.Now.Day;

            for (int i = 1; i <= 1; i++)
            {
                //Determia o primeiro dia do mes atual
                var MesAt = new DateTime(Ano, Mes, 1);
         
                var AlinharAno = new string(' ', 16 - MesAt.ToString("MMMM").Length);
                Console.WriteLine($"{MesAt.ToString("MMMM")}{AlinharAno}{MesAt.Year}");
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Do Se Te Qa Qi Se Sa");
                /*
                 * Determina o número de dias que precisamos para deixar espaços brancos no começo da Semana.
                 */
                var Espacos = (int)MesAt.DayOfWeek;
                var DiaAt = MesAt;
                /*
                 * Nº de vezes que é executado o loop.
                 */
                var NLoops = DateTime.DaysInMonth(MesAt.Year, MesAt.Month) + Espacos;
                for (int j = 0; j < NLoops; j++)
                {
                    if (j < Espacos)
                        Console.Write("   ");
                    else
                    {
                        Console.Write($"{DiaAt.Day.ToString().PadLeft(2, ' ')} ");

                        if ((j + 1) % 7 == 0)
                            Console.WriteLine();
                        DiaAt = DiaAt.AddDays(1);
                    }
                }
                Console.WriteLine("\n");
            }
        }
        /**
         * <param name="Mes"></param>
         */
        static void Feriados(int Mes)
        {
            if (Mes == 1)
                Console.WriteLine("01/01/{0} Ano Novo", DateTime.Now.Year);
            else if (Mes == 4)
            {
                Console.WriteLine("10/04/{0} Sexta-Feira Santa", DateTime.Now.Year);
                Console.WriteLine("12/04/{0} Páscoa", DateTime.Now.Year);
                Console.WriteLine("25/04/{0} 25 de Abril", DateTime.Now.Year);
            }
            else if (Mes == 5)
                Console.WriteLine("01/05/{0} Dia do Trabalhador", DateTime.Now.Year);
            else if (Mes == 6)
            {
                Console.WriteLine("10/06/{0} Dia de Portugal", DateTime.Now.Year);
                Console.WriteLine("11/06/{0} Corpo de Deus", DateTime.Now.Year);
            }
            else if (Mes == 8)
                Console.WriteLine("05/08/{0} Implantação da República", DateTime.Now.Year);
            else if (Mes == 10)
                Console.WriteLine("01/10/{0} Dia de Todos os Santos", DateTime.Now.Year);
            else if (Mes == 12)
            {
                Console.WriteLine("01/12/{0} Restauração da Independência", DateTime.Now.Year);
                Console.WriteLine("08/12/{0} Dia da Imaculada Conceição", DateTime.Now.Year);
                Console.WriteLine("25/12/{0} Natal", DateTime.Now.Year);
            }
        }
        static int DiasUteis(int Ano, int Mes)
        {
            int DiasTotais = DateTime.DaysInMonth(Ano, Mes);
            int DiasUteisTotais = 0;

            if (Mes == 1)
                DiasUteisTotais = DiasTotais - 9;
            else if (Mes == 2)
                DiasUteisTotais = DiasTotais - 8;
            else if (Mes == 3)
                DiasUteisTotais = DiasTotais - 10;
            else if (Mes == 4)
                DiasUteisTotais = DiasTotais - 11;
            else if (Mes == 5)
                DiasUteisTotais = DiasTotais - 9;
            else if (Mes == 6)
                DiasUteisTotais = DiasTotais - 12;
            else if (Mes == 7)
                DiasUteisTotais = DiasTotais - 8;
            else if (Mes == 8)
                DiasUteisTotais = DiasTotais - 10;
            else if (Mes == 9)
                DiasUteisTotais = DiasTotais - 9;
            else if (Mes == 10)
                DiasUteisTotais = DiasTotais - 8;
            else if (Mes == 11)
                DiasUteisTotais = DiasTotais - 9;
            else if (Mes == 12)
                DiasUteisTotais = DiasTotais - 10;

            Console.WriteLine("\nDias úteis totais {0}.",DiasUteisTotais);
            return DiasUteisTotais;
        }
    }
}
