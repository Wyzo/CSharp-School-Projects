using System;
using System.Linq;

namespace IntroducaoVetores3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Valores = { 150, 175, 168, 293, 188, 200, 176, 154 };
            int Media = calcularMedia(Valores);

            mostrarValores(Valores);
            atualizarValores(Valores, Media);
            mostrarValores(Valores);
        }
        static void mostrarValores(int[] Valores)
        {
            foreach (int item in Valores)
                Console.WriteLine(item);
        }
        static int calcularMedia(int[] Valores)
        {
            return (int) Valores.Average();
        }
        static void atualizarValores(int[] Valores, int Media)
        {
            for (int i = 0; i < Valores.Length; i++)
            {
                if (Valores[i] > Media)
                    Valores[i] = Media;
            }
        }
    }
}
