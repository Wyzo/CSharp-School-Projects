using System;

namespace DE01_01
{
    class Program
    {

        struct IdiomasPalavra
        {
            string[] Palavras;
            static string[] Idiomas = { "PT", "ENG", "FR", "ESP" };
            public IdiomasPalavra(string[] _Palavras)
            {
                Palavras = _Palavras;
                if (_Palavras.Length == Idiomas.Length)
                {
                    for (int i = 0; i < _Palavras.Length; i++)
                        Palavras[i] = _Palavras[i].Trim().ToLower();

                }
            }
            public string Palavra(string Idioma)
            {
                return Palavras[Array.IndexOf(Idiomas, Idioma.ToUpper().Trim())];
            }
            public int Encontrou(string Palavra)
            {
                return Array.IndexOf(Palavras, Palavra.ToLower().Trim());
            }
            public string Idioma(string Palavra)
            {
                int i = Array.IndexOf(Palavras, Palavra.Trim().ToLower());

                if (i < 0)
                    return "Unknow";
                else
                    return Idiomas[i];
            }

        }
        static void Main(string[] args)
        {

            string[] Resp;

            int i;

            IdiomasPalavra[] Tradutor =
                {new IdiomasPalavra(new string[]{"Olá", "Hello", "Bonjour", "Hola" }),
                 new IdiomasPalavra(new string[]{"Amor", "Love", "Amour","Amor" }),
                 new IdiomasPalavra(new string[]{"Programador", "Developer", "Développeur", "Desarrollador" })};

            Console.Write("Palavra e idioma: ");
            Resp = Console.ReadLine().Split();

            if (Resp.Length != 2)
                Console.WriteLine("ERRO!");

            else
            {

                i = 0;
                while (i < Tradutor.Length && Tradutor[i].Encontrou(Resp[0]) <= 0)
                    i++;

                if (i == Tradutor.Length)
                    Console.WriteLine("Não foi encontrada tradução para essa palavra.");
                else
                    Console.WriteLine("Tradução de {0} em {1} para {2} -> {3}", Resp[0], Tradutor[i].Idioma(Resp[0]), Resp[1], Tradutor[i].Palavra(Resp[1]));
            }
            Console.ReadKey();
        }
    }
}
