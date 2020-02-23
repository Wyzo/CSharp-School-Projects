using System;

namespace ProximaSementeira
{
    class Program
    {
        static void Main(string[] args)
        {
            string Estacao, Sementeira, Resposta = "";

            Console.Write("Digite a estação do ano: ");
            Estacao = Console.ReadLine();

            Console.Write("Digite a sementeira utilizada: ");
            Sementeira = Console.ReadLine();

            if (Estacao == "Outono")
            {
                if (Sementeira == "Milho")
                {
                    Resposta = "Centeio";
                }
                else if (Sementeira == "Centeio")
                {
                    Resposta = "Milho";
                }
                else if (Sementeira == "Girassol")
                {
                    Resposta = "Centeio";
                }
            }

            else if (Estacao == "Primavera")
            {
                if (Sementeira == "Milho")
                {
                    Resposta = "Centeio";
                }
                else if (Sementeira == "Centeio")
                {
                    Resposta = "Girassol";
                }
                else if (Sementeira == "Girassol")
                {
                    Resposta = "Centeio";
                }
            }

            else if(Estacao == "Inverno" || Estacao == "Verão")
            {
                if (Sementeira == "Centeio")
                {
                    if (Sementeira == "Girassol")
                    {
                        Resposta = "Milho";
                    }
                    else if (Sementeira == "Milho")
                    {
                        Resposta = "Girassol";
                    }
                    else
                    {
                        Resposta = "Milho";
                    }
                }
                else
                {
                    Resposta = "Centeio";
                }
            }

            Console.WriteLine(Resposta);
         Console.ReadKey();
        }
    }
}
