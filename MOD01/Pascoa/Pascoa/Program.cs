using System;

namespace Pascoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int Ano, Resto;

            Console.Write("Ano: ");
            Ano = int.Parse(Console.ReadLine());

            Resto = (Ano % 19) + 1;
            DateTime Dia = new DateTime();

            switch (Resto)
            {
                case 1: 
                    Dia = new DateTime(Ano, 4, 14, 0, 0, 0, 0); 
                    break;
                case 2: 
                    Dia = new DateTime(Ano, 4, 3, 0, 0, 0, 0); 
                    break;
                case 3: 
                    Dia = new DateTime(Ano, 3, 23, 0, 0, 0, 0); 
                    break;
                case 4: 
                    Dia = new DateTime(Ano, 4, 11, 0, 0, 0, 0); 
                    break;
                case 5: 
                    Dia = new DateTime(Ano, 3, 31, 0, 0, 0, 0); 
                    break;
                case 6: 
                    Dia = new DateTime(Ano, 4, 18, 0, 0, 0, 0); 
                    break;
                case 7: 
                    Dia = new DateTime(Ano, 4, 8, 0, 0, 0, 0); 
                    break;
                case 8: 
                    Dia = new DateTime(Ano, 3, 28, 0, 0, 0, 0); 
                    break;
                case 9: 
                    Dia = new DateTime(Ano, 4, 16, 0, 0, 0, 0); 
                    break;
                case 10: 
                    Dia = new DateTime(Ano, 4, 5, 0, 0, 0, 0); 
                    break;
                case 11: 
                    Dia = new DateTime(Ano, 3, 25, 0, 0, 0, 0); 
                    break;
                case 12: 
                    Dia = new DateTime(Ano, 4, 13, 0, 0, 0, 0); 
                    break;
                case 13: 
                    Dia = new DateTime(Ano, 4, 2, 0, 0, 0, 0); 
                    break;
                case 14: 
                    Dia = new DateTime(Ano, 3, 22, 0, 0, 0, 0); 
                    break;
                case 15: 
                    Dia = new DateTime(Ano, 4, 10, 0, 0, 0, 0); 
                    break;
                case 16: 
                    Dia = new DateTime(Ano, 3, 30, 0, 0, 0, 0); 
                    break;
                case 17: 
                    Dia = new DateTime(Ano, 4, 17, 0, 0, 0, 0); 
                    break;
                case 18: 
                    Dia = new DateTime(Ano, 4, 7, 0, 0, 0, 0); 
                    break;
                case 19: 
                    Dia = new DateTime(Ano, 3, 27, 0, 0, 0, 0); 
                    break;
            }
            string cRet = "";
            for (int n = 1; n <= 7; n++)
            {
                Dia = Dia.AddDays(1);
                if (Dia.DayOfWeek == DayOfWeek.Sunday)
                {
                    cRet = Dia.Day.ToString();
                    cRet += Dia.Month == 3 ? " de Março" : " de Abril";
                }
            }
            Console.WriteLine("A páscoa será a {0}.", cRet);
            Console.ReadKey();
        }
    }
}
