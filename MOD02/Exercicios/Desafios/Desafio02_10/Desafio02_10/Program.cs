using System;

namespace Desafio02_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string Aluno;
            string MelhorAluno = "";

            int Alunos;
            double Nota;
            double Maior = 0;

            Console.Write("Número de alunos na turma: ");
            Alunos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Alunos; i++)
            {
                Console.Write("Nome do aluno: ");
                Aluno = Console.ReadLine();

                Console.Write("Média do {0}: ", Aluno);
                Nota = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    Maior = Nota;
                    MelhorAluno = Aluno;
                }
                else
                {
                    if (Nota > Maior)
                    {
                        Maior = Nota;
                        MelhorAluno = Aluno;
                    }
                }
            }
            Console.WriteLine("Dos {0} alunos a melhor média foi a do(a) {1} com uma média de {2} valores.", Alunos, MelhorAluno, Maior);
            Console.ReadKey();
        }
    }
}
