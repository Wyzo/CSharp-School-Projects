using System;
using System.Linq;

namespace SOFTPAK
{
    class Program
    {
        struct Ingredientes
        {
            string Ingrediente;
            int Stock;

            public Ingredientes(string ingrediente, int stock)
            {
                Ingrediente = ingrediente;
                Stock = stock;
            }

            //Retorna o nome do ingrediente
            public string getIngrediente()
            {
                return Ingrediente;
            }

            public bool getEstado()
            {
                //True = stock disponível
                //False = stock indisponível
                bool estadoStock = true;
                
                if (Stock == 0)
                    estadoStock = false;
                else
                    estadoStock = true;
                return estadoStock;
            }

            //Retorna o stock disponível
            public int getStock()
            {
                return Stock;
            }

            //Retorna o estado do stock
            public string getStockEstado()
            {
                if (getEstado() == false)
                    return "Stock indisponível";
                else
                    return "Stock disponível!";
            }

            public override string ToString()
            {
                return getIngrediente() + " - Estado do stock: " + getStockEstado() + " - " + getStock() + " ingredientes em stock.";
            }
        }
        static void Main(string[] args)
        {
            //Declaração dos ingredientes
            Ingredientes[] Produtos =
            {
                new Ingredientes("farinha", 0),
                new Ingredientes("leite", 10),
                new Ingredientes("ovos", 50),
                new Ingredientes("açucar", 0), 
            };

            string[] IngredientesProduto = new string[5];
            int[] IngredientesQuantia = new int[5];
            string[] Resp = new string[2];

            int i = 0;
            int Quantia;

            Console.WriteLine("Quantos ingredientes terá a receita? ");
            Console.Write("> ");
            Quantia = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do ingrediente e quantia");
            for (int j = 0; j < Quantia; j++)
            {
                Resp = Console.ReadLine().Split();
                IngredientesProduto[i] = Resp[0];
                IngredientesQuantia[i] = int.Parse(Resp[1]);
            }

            foreach (string item in IngredientesProduto)
            {
                Console.WriteLine(item);
            }
            foreach (int item in IngredientesQuantia)
            {
                Console.WriteLine(item);
            }
        }
    }
}
