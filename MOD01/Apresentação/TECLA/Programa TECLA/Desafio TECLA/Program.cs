using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_TECLA
{
    class Program
    {
        static void Main(string[] args)
        {

            //Desafio TECLA --> Programa para calcular o IMC do utilizador

            //Dados de entrada
            int Peso; //Nesta variável vai ser guardado o peso do utilizador (em nº inteiro)
            double Altura; //Nesta variável vai ser guardado a altura do utilizador (com 2 casas decimais)

            //Dados intermédios
            double Altura2; //Nesta variável vai ser guardado a altura ao quadrado

            //Dados de saída
            double IMC; //Nesta variável vai ser guardado o IMC do utilizador (arredondado ás unidade)

            //Input
            Console.Write("Qual o peso do utilizador?"); //Estamos a perguntar ao utilizador qual o seu peso
            Peso = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual a altura do utilizador?"); //Estamos a perguntar ao utilizador qual a sua altura
            Altura = Convert.ToDouble(Console.ReadLine());

            //Processamento
            Altura2 = Math.Pow(Altura , 2); //Estamos a transformar a altura em altura ao quadrado
            IMC = Peso / Altura2; //Este é o calculo final ( Peso a dividr por altura ao quadrado)
            

            //Output
            Console.Clear();

            Console.Write("O seu IMC é {0:F0}.", Math.Round(IMC)); //Estamos a mostrar ao utilizador o IMC (Resultado final arrendondado)
            Console.Write("\nSe o seu IMC for <18,5 --> Magro ou abaixo do peso ideal.\n");//Neste passo tamos a dar ao utilizador informações sobre os diferentes tipo de IMC
            Console.Write("\nSe o seu IMC for 18,5 - 24,9 --> Normal.\n"); //Neste passo tamos a dar ao utilizador informações sobre os diferentes tipo de IMC
            Console.Write("\nSe o seu IMC for 25 - 29,9 --> Sobrepeso.\n"); //Neste passo tamos a dar ao utilizador informações sobre os diferentes tipo de IMC
            Console.Write("\nSe o seu IMC for 30 - 34,99 --> Obesidade.\n"); //Neste passo tamos a dar ao utilizador informações sobre os diferentes tipo de IMC
            Console.Write("\nSe o seu IMC for >= 40 -> Obesidade Elevada.\n"); //Neste passo tamos a dar ao utilizador informações sobre os diferentes tipo de IMC

            Console.ReadKey();
           
        }

    }

}