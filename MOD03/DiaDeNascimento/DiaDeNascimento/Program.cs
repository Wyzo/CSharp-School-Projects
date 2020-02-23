using System;

namespace DiaDeNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dia, Mes, Ano;

            DateTime DataNas;

            /*Console.Write("Dia: ");
            Dia = int.Parse(Console.ReadLine());

            Console.Write("Mês: ");
            Mes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            Ano = int.Parse(Console.ReadLine());*/

            Console.WriteLine();
            DataNas = DateTime.Parse(Console.ReadLine());
            Console.Write(Idade(DataNas));

            Console.ReadKey();
        }
        /*
         * @param Dia   =   Dia de nascimento;
         * @param Mes   =   Mês de nascimento;
         * @param Ano   =   Ano de nascimento;
         */
        static int Ani(int Dia, int Mes, int Ano)
        {
            int Idade = 0;

            int AnoAtu = DateTime.Now.Year;
            int MesAtu = DateTime.Now.Month;
            int DiaAtu = DateTime.Now.Day;

            Idade = AnoAtu - Ano;

            if ((Mes > MesAtu) || (Mes == MesAtu && Dia > DiaAtu))
                Idade--;

            return Idade;
        }
        static int Idade(DateTime DataAni)
        {
            return Ani(DataAni.Day, DataAni.Month, DataAni.Year);
        }
    }
}
