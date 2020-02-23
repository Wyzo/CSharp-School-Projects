using System;

namespace Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            int Min, Soma;

            MinMax(10, 20, out Min, out Soma);
            Console.WriteLine("Min = {0} | Soma = {1}", Min, Soma);
        }
        static int Soma(int Num1, int Num2)
        {
            int Resultado = Num1 + Num2;

            Console.WriteLine("Dentro da função");
            Console.WriteLine(Resultado);

            return Resultado;
        }
        static void Troca(ref int a, ref int b)
        {
            int Temp;

            Temp = a;
            a = b;
            b = Temp;
        }
        static void MinMax(int a, int b, out int Min, out int Soma)
        {
            if (a < b)
                Min = a;
            else
                Min = b;
            Soma = a + b;
        }
    }
}
