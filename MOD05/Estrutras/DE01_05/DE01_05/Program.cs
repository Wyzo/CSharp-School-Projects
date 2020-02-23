using System;

namespace DE01_05
{
    class Program
    {
        struct Revista
        {
            string Titulo;
            string Autor;
            string Texto;

            public Revista(string Titulo_, string Autor_, string Texto_)
            {
                this.Titulo = Titulo_;
                this.Autor = Autor_;
                this.Texto = Texto_;
            }

            public int getCaracteres(string Texto)
            {
                return Texto.Length;
            }

            public override string ToString()
            {
                return Titulo.ToUpper() + "\n[ " + Autor + " ]\n" + getCaracteres(Texto) + " caracteres.\n" + " \n" + Texto;
            }

            public void verificarCaracteres(string Texto)
            {
                char[] TextoEncurtado = Texto.ToCharArray();
                if(Texto.Length > 100)
                {
                    for (int i = 0; i < 101; i++)
                        Console.Write(TextoEncurtado[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Revista[] Publi = { new Revista("Um título", "Francisco Duarte", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean m") };
            Console.WriteLine(Publi[0].ToString());
        }
    }
}
