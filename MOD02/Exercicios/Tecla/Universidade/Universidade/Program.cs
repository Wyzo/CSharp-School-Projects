using System;

namespace Universidade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  @Dados de entrada.
             *  Notas finais das disciplinas.
             */
            int Port, In, Ai, EDF, TIC, Mat, FQ, PSI, RC, AC, SO, PAP, FCT;
            /*  
             *  @Dados de entrada.
             *  Notas finais dos exames.
             */
            int ExamePT, ExameMatA, ExameMatB, ExameFQ;
            /*  
             *  @Dados intermédios.
             */
            double CFC, FSC, FC, FT, CFCEPE, ME;

            const double ESTGV = 113.3;
            const double UA = 162.5;
            const double UBI = 125.5;

            Console.Write("PT: ");
            Port = int.Parse(Console.ReadLine());
            Console.Write("IN: ");
            In = int.Parse(Console.ReadLine());
            Console.Write("AI: ");
            Ai = int.Parse(Console.ReadLine());
            Console.Write("EDF: ");
            EDF = int.Parse(Console.ReadLine());
            Console.Write("TIC: ");
            TIC = int.Parse(Console.ReadLine());
            Console.Write("MAT: ");
            Mat = int.Parse(Console.ReadLine());
            Console.Write("FQ: ");
            FQ = int.Parse(Console.ReadLine());
            Console.Write("PSI: ");
            PSI = int.Parse(Console.ReadLine());
            Console.Write("RC: ");
            RC = int.Parse(Console.ReadLine());
            Console.Write("AC: ");
            AC = int.Parse(Console.ReadLine());
            Console.Write("SO: ");
            SO = int.Parse(Console.ReadLine());
            Console.Write("PAP: ");
            PAP = int.Parse(Console.ReadLine());
            Console.Write("FCT: ");
            FCT = int.Parse(Console.ReadLine());
            Console.Write("Exame de Português: ");
            ExamePT = int.Parse(Console.ReadLine());
            Console.Write("Exame de FQ: ");
            ExameFQ = int.Parse(Console.ReadLine());

            FSC = (Port + Ai + EDF + TIC + In) / 5;
            FC = (Mat + FQ) / 2;
            FT = (PSI + RC + AC + SO) / 4;
            ME = (ExamePT * 10) * 0.2 + (ExameFQ * 10) * 0.2;
            CFC = ((0.22 * FSC + 0.22 * FC + 0.22 * FT + 0.11 * FCT + 0.23 * PAP) * 10) * 0.6;
            CFCEPE = (7 * CFC + 3 * ME) / 10;

            //Console.WriteLine(CFC);
            Console.WriteLine(CFCEPE);
            Console.ReadKey();
        }
    }
}
