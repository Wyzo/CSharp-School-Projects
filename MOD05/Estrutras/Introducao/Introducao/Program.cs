using System;

namespace Introducao
{
    class Program
    {
        struct Traducao
        {
            public string Palavra;
            public string Idioma;

            public Traducao(string Palavra_, string Idioma_)
            {
                Palavra = Palavra_;
                Idioma = Idioma_;
            }

            public override string ToString()
            {
                switch (Idioma)
                {
                    default:
                        break;
                }
                return -1;
            }

        }
        struct nomePessoa
        {
            public string primeiroNome;
            public string ultimoNome;

            //Construtor da estrutura da podermos inicializar as propriedades (TODAS)
            //Nota: o método (função) não tem a palavra reservada "void"
            //Deve ter o mesmo nome que o da estrutura
            public nomePessoa(string _primeiroNome, string _ultimoNome)
            {
                primeiroNome = _primeiroNome;
                ultimoNome = _ultimoNome;
            }

            public override string ToString()
            {
                string Nome, Texto;

                Texto = primeiroNome.ToLower();
                Nome = Texto[0].ToString().ToUpper().Trim() + Texto.Substring(1);

                Texto = ultimoNome.ToLower();
                Nome += " " + Texto[0].ToString().ToUpper().Trim() + Texto.Substring(1);

                return Nome;
            }
        }
        class Pessoa
        {
            nomePessoa Nome;
            DateTime dataDeNascimento;

            int Altura; //cm's
            char Sexo;

            public Pessoa(nomePessoa _Nome, DateTime _dataDeNascimento, int _Altura, char _Sexo)
            {
                Nome = _Nome;
                dataDeNascimento = _dataDeNascimento;
                Altura = _Altura;
                Sexo = _Sexo;
            }
            //A estrutura pode ter mais do que um construtor, desde que tenha parametros diferentes (assinaturas diferentes)
            public Pessoa()
            {
                Nome = new nomePessoa("", "");
                dataDeNascimento = DateTime.Now;
                Altura = 187;
                Sexo = 'O';
            }

            public override string ToString()
            {
                return Nome + ": Nasceu num(a) " + dataDeNascimento.ToString("dddd, dd' de 'MMMM' de 'yyyy") + ", " + Altura + ", (" + Sexo + ")";
            }
        }
        static void Main(string[] args)
        {
            //A palavra "new" permiter chamar o construtur da estrutura 
            nomePessoa Nome = new nomePessoa("faNcisCo", "duArte");
            Pessoa Aluno = new Pessoa(Nome, new DateTime(2004, 05, 13), 187, 'M');

            Pessoa[] Turma = new Pessoa[6];

            Turma[0] = new Pessoa(new nomePessoa("Alberto", "Manuel"), new DateTime(2003, 03, 07), 185, 'M');
            Turma[1] = new Pessoa(new nomePessoa("Sara", "Ribeiro"), new DateTime(2004, 07, 15), 175, 'F');
            Turma[2] = new Pessoa(new nomePessoa("Diogo", "Costa"), new DateTime(2004, 05, 11), 185, 'M');
            Turma[3] = new Pessoa(new nomePessoa("Andreia", "Luísa"), new DateTime(2003, 02, 09), 163, 'F');
            Turma[4] = new Pessoa(new nomePessoa("Joana", "Cardoso"), new DateTime(2003, 06, 06), 178, 'F');
            Turma[5] = new Pessoa(Nome, new DateTime(2004, 05, 13), 187, 'M');

            for (int i = 0; i < Turma.Length; i++)
                Console.WriteLine(Turma[i]);

            //Console.WriteLine(Nome.ToString());
        }
    }
}
