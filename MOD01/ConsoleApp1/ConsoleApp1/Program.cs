using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string Nome, Continente, Pais = "", Cidade = "";

            int Idade;

            Console.Write("Digite o seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Olá {0}! Digite a sua idade: ", Nome);
            Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu continente: ", Nome);
            Continente = Console.ReadLine();

            if(Continente == "Europa")
            {
                Console.WriteLine("\nAlguns dos países disponíveis: ");
                Console.WriteLine(
                                "\nPortugal"      + 
                                "\nEspanha"     +
                                "\nFrança"      +
                                "\nAlemanha"    +
                                "\nInglaterra"  +
                                "\nItália");
                Console.WriteLine("Digite algum: ");
                Pais = Console.ReadLine();
                if(Pais == "Portugal")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nViseu" +
                                    "\nLisboa" +
                                    "\nPorto" +
                                    "\nAlgarve" +
                                    "\nCoimbra" +
                                    "\nAveiro");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Espanha")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nMadrid" +
                                    "\nBarcelona" +
                                    "\nSevilha" +
                                    "\nValência" +
                                    "\nGranada" +
                                    "\nBilbau");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "França")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nBerlim" +
                                    "\nMunique" +
                                    "\nHamburgo" +
                                    "\nFrankfurt" +
                                    "\nColônia" +
                                    "\nDresden");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Alemanha")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nParis" +
                                    "\nLyon" +
                                    "\nMarselha" +
                                    "\nNice" +
                                    "\nBordéus" +
                                    "\nToulouse");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Inglaterra")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nLondres" +
                                    "\nManchester" +
                                    "\nLiverpool" +
                                    "\nCambridge" +
                                    "\nBristol" +
                                    "\nBirmingham");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Itália")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nRoma" +
                                    "\nMilão" +
                                    "\nFlorença" +
                                    "\nVeneza" +
                                    "\nTurim" +
                                    "\nNápoles");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
            }
            else if(Continente == "América")
            {
                Console.WriteLine("\nAlguns dos países disponíveis: ");
                Console.WriteLine(
                                "\nEstados Unidos"    +
                                "\nBrasil"          +
                                "\nMéxico"          +
                                "\nCanadá"          +
                                "\nColômbia");
                Console.WriteLine("Digite algum: ");
                Pais = Console.ReadLine();
                if (Pais == "Estados Unidos")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nNova Iorque" +
                                    "\nLos Angeles" +
                                    "\nSão Francisco" +
                                    "\nMiami" +
                                    "\nWashington, D.C." +
                                    "\nChicago");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Brasil")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nRio de Janeiro" +
                                    "\nSão Paulo" +
                                    "\nBrasília" +
                                    "\nBelo Horizonte" +
                                    "\nVitória" +
                                    "\nSalvador");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "México")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nCidade do México" +
                                    "\nCancún" +
                                    "\nCiudad Juarez" +
                                    "\nGuadalajara" +
                                    "\nPuebla" +
                                    "\nTijuana");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Canadá")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nToronto" +
                                    "\nVancouver" +
                                    "\nMontreal" +
                                    "\nOttawa" +
                                    "\nCalgary" +
                                    "\nQuebec");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Canadá")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nToronto" +
                                    "\nVancouver" +
                                    "\nMontreal" +
                                    "\nOttawa" +
                                    "\nCalgary" +
                                    "\nQuebec");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Colômbia")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nBogotá" +
                                    "\nMedelín" +
                                    "\nCartagena das índias" +
                                    "\nCali" +
                                    "\nBarranquilla" +
                                    "\nSanta Marta");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
            }
            else if (Continente == "Oceania")
            {
                Console.WriteLine("\nAlguns dos países disponíveis: ");
                Console.WriteLine(
                                "\nAustrália"             +
                                "\nNova Zelândia"       +
                                "\nFiji"                +
                                "\nPolinésia Francesa"  +
                                "\nPapua-Nova Guiné"    +
                                "\nIlhas Salomão");
                Console.WriteLine("Digite algum: ");
                Pais = Console.ReadLine();
                if (Pais == "Austrália")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nSydney" +
                                    "\nMelbourne" +
                                    "\nPerth" +
                                    "\nBrisbane" +
                                    "\nGold Coast" +
                                    "\nAdelaide");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Nova Zelândia")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nAuckland" +
                                    "\nWellington" +
                                    "\nQueenstown" +
                                    "\nChristchurch" +
                                    "\nTauranga" +
                                    "\nDunedin");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Fiji")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nSuva" +
                                    "\nNadi" +
                                    "\nLautoka" +
                                    "\nLabasa" +
                                    "\nSavuasu" +
                                    "\nSigatoka");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Nova Zelândia")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nAuckland" +
                                    "\nWellington" +
                                    "\nQueenstown" +
                                    "\nChristchurch" +
                                    "\nTauranga" +
                                    "\nDunedin");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Polinésia Francesa")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nPapete" +
                                    "\nFaaa" +
                                    "\nPunaauia" +
                                    "\nBora Bora" +
                                    "\nNuku Hiva" +
                                    "\nArue");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Papua-Nova Guiné")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nPort Moresby" +
                                    "\nLae" +
                                    "\nMadang" +
                                    "\nMount Hagen" +
                                    "\nGoroka" +
                                    "\nRabaul");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
                else if (Pais == "Ilhas Salomão")
                {
                    Console.WriteLine("\nAlguns das cidades disponíveis: ");
                    Console.WriteLine(
                                    "\nHoniara" +
                                    "\nMunda" +
                                    "\nYandina" +
                                    "\nGizo" +
                                    "\nBuala" +
                                    "\nLata");
                    Console.Write("Digite algum: ");
                    Cidade = Console.ReadLine();
                }
            }
            else if (Continente == "Ásia")
            {
                Console.WriteLine("\nAlguns dos países disponíveis: ");
                Console.WriteLine(
                                "\nChina"         +
                                "\nJapão"       +
                                "\nFilipinas"   +
                                "\nIndonésia"   +
                                "\nMalásia"     +
                                "\nTailândia");
                Console.WriteLine("Digite algum: ");
                Pais = Console.ReadLine();
            }
            else if (Continente == "África")
            {
                Console.WriteLine("\nAlguns dos países disponíveis: ");
                Console.WriteLine(
                                "\nChina"         +
                                "\nJapão"       +
                                "\nFilipinas"   +
                                "\nIndonésia"   +
                                "\nMalásia"     +
                                "\nTailândia");
                Console.WriteLine("Digite algum: ");
                Pais = Console.ReadLine();
            }
            Console.WriteLine("\nInformações finais");
            Console.WriteLine("\nNome: {0}", Nome);
            Console.WriteLine("Idade: {0}", Idade);
            Console.WriteLine("Continente: {0}", Continente);
            Console.WriteLine("País: {0}", Pais);
            Console.WriteLine("Cidade: {0}", Cidade);
            
            Console.ReadKey();
        }
    }
}