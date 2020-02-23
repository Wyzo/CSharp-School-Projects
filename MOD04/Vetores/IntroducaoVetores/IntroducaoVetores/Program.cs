using System;

namespace IntroducaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Idades = new int[5];
            //Ou
            int[] Alturas = { 120, 180, 175, 168 };
            
            Idades[0] = 20; Idades[1] = 18;
            //Para aceder a um valor do Vetor
            /*Console.WriteLine(Alturas[1]);*/
            /*for (int i = 0; i < Alturas.Length; i++)
            {
                Console.WriteLine(Alturas[i]);
            }*/
            foreach (int item in Alturas)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < Idades.Length; i++)
            {
                Console.WriteLine(Idades[i]);
            }
        }
    }
}