using System;

namespace Desafio1_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op;
            int Lote;

            bool[] Lotes = new bool[20];
            do
            {
                Op = mostrarMenu();
                Console.Clear();
                switch (Op)
                {
                    case 1:
                        Console.WriteLine("Efetuar inscrição");
                        Lote = lerLote(Lotes.Length);
                        if(Lote != -1)
                        {
                            if (Lotes[Lote])
                                Console.WriteLine("ERRO. Lote ocupado");
                            else
                            {
                                Console.WriteLine("Reserva efetuada com sucesso!");
                                Lotes[Lote] = true;
                            }
                        }
                        else
                            Console.WriteLine("ERRO. Número de lote inválido");
                        Console.WriteLine("Lotação disponível: {0}", lotacaoDisponivel(Lotes));
                        break;
                    case 2:
                        Console.WriteLine("Desocupar Lote");
                        break;
                    case 3:
                        Console.WriteLine("Lotação do Parque");
                        Console.WriteLine("\nLotação disponível: {0}", lotacaoDisponivel(Lotes));
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Prima qualquer tecla para voltar..");
                Console.ReadKey();
            } while (Op != 1);
        }
        static int mostrarMenu()
        {
            int Opcao;

            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("=                Menu              =");
            Console.WriteLine("====================================");
            Console.WriteLine("\n0. Sair");
            Console.WriteLine("1. Efetuar inscriçao");
            Console.WriteLine("2. Desocupar Lote");
            Console.WriteLine("3. Lotação do Parque");
            Console.Write("> ");
            int.TryParse(Console.ReadLine(), out Opcao);

            return Opcao;
        }
        static int lotacaoDisponivel(bool[] Lote)
        {
            int Total = 0;

            foreach (bool item in Lote)
                if (!item)
                    Total++;

            return Total;
        }
        static int lerLote(int lotesTotais)
        {
            int Lote;

            Console.Write("Lote: ");
            if (int.TryParse(Console.ReadLine(), out Lote))
            {
                if (Lote <= 0 || Lote > lotesTotais)
                    Lote = -1;
                else
                    Lote = -1;
            }
            return Lote;
        }
    }
}
