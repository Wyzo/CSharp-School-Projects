using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            double Peso, Altura;

            Console.Write("Peso: ");
            Peso = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            Altura = double.Parse(Console.ReadLine());

            //DesenhaLinha(0, '=', false);
            //DesenhaRetangulo(1, 1, '*', false);
            calculaIMC(Peso, Altura);

            Console.WriteLine("IMC = {0:F2}", calculaIMC(Peso, Altura));
            Console.WriteLine(calculaIMCestado(calculaIMC(Peso, Altura)));

            Console.ReadKey();
        }
        /*
         * @param nChar     =   Representa o número de caracteres;
         * @param c         =   Representa o caracter;
         */
        static void DesenhaLinha(int nChar, char c, bool Preenchido)
        {
            if (nChar > 0)
            {
                Console.Write(c);
                for (int i = 0; i < nChar - 2; i++)
                    if (Preenchido)
                        Console.Write(c);
                    else
                        Console.Write(" ");
                if (nChar > 1)
                    Console.WriteLine(c);
                else
                    Console.WriteLine();
            }
        }
        /*
         * @param Altura    =   Representa a altura;
         * @param Comp      =   Representa o comprimento;
         * @param c         =   Representa o caracter;
         */
       static void DesenhaRetangulo(int Comp, int Altura, char c, bool Preenchido)
       {
            if (Altura > 0)
            {
                DesenhaLinha(Comp, c, true);
                for (int i = 0; i < Altura - 2; i++)
                    DesenhaLinha(Comp, c, Preenchido);
                if (Altura > 1)
                    DesenhaLinha(Comp, c, true);
            } 
       }
        /*
         * @param Peso      =   Representa o Peso;
         * @param Altura    =   Representa a Altura;
         */
        static double calculaIMC(double Peso, double Altura)
        {
            double Resultado;

            Resultado = Peso / Math.Pow(Altura, 2);
            return Resultado;
        }
        static string calculaIMCestado(double IMC)
        {
            if (IMC < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (IMC >= 18.6 && IMC <= 24.9)
            {
                return "Peso ideal";
            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                return "Levemente acima do peso";
            }
            else if (IMC >= 30.0 && IMC <= 34.9)
            {
                return "Obesidade grau 1";
            }
            else if (IMC >= 35.0 && IMC <= 39.9)
            {
                return "Obesiade grau 2 (severa)";
            }
            else
            {
                return "Obesidade 3 (morbida)";
            }
        }
    }
}
