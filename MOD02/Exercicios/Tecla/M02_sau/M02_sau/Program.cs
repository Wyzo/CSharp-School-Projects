using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace M02_sau
{
    class Program
    {
        static void Main(string[] args)
        {
            string Saudacao = "", DiaDaSemana = "";
            Console.ForegroundColor = ConsoleColor.Green;

            SpeechSynthesizer audio = new SpeechSynthesizer();

            //Velocidade do áudio
            audio.Rate = 0;
            //Volume do áudio
            audio.Volume = 50;

            //Testar o dia da semana
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    DiaDaSemana = "Domingo";
                    break;
                case DayOfWeek.Monday:
                    DiaDaSemana = "Segunda";
                    break;
                case DayOfWeek.Tuesday:
                    DiaDaSemana = "Terça";
                    break;
                case DayOfWeek.Wednesday:
                    DiaDaSemana = "Quarta";
                    break;
                case DayOfWeek.Thursday:
                    DiaDaSemana = "Quinta";
                    break;
                case DayOfWeek.Friday:
                    DiaDaSemana = "Sexta";
                    break;
                case DayOfWeek.Saturday:
                    DiaDaSemana = "Sábado";
                    break;
                default:
                    DiaDaSemana = "";
                    break;
            }

            Console.WriteLine("Hoje é {0}, {1}.", DiaDaSemana, DateTime.Now.Date.ToLongDateString());
            Console.WriteLine("São {0} horas e {1} minutos", DateTime.Now.Hour, DateTime.Now.Minute);
            audio.Speak("Hello world!");
            if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour <= 12)
            {
                Saudacao = "Good Morning! Have a nice Day";
            }
            else if (DateTime.Now.Hour >= 13 && DateTime.Now.Hour <= 18)
            {
                Saudacao = "Good Afternoon! Have a nice Day";
            }
            else if (DateTime.Now.Hour >= 19 && DateTime.Now.Hour <= 23)
            {
                Saudacao = "Good Evening! Have arestful night";
            }
            else if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 7)
            {
                Saudacao = "Good Night! Have a restful night";
            } else
            audio.Speak(Saudacao);
            audio.Speak(DiaDaSemana);
        }
    }
}