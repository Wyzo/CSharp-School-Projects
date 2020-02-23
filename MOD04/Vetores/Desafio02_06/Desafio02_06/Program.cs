using System;

namespace Desafio02_06
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "aabbcc";

            char[] fraseTrocada = input.ToCharArray();
            for (int i = 0; i < fraseTrocada.Length; i++)
            {
                char let = fraseTrocada[i];
                if (char.IsUpper(let))
                    fraseTrocada[i] = char.ToLower(let);
                else if (let == 'a')
                    fraseTrocada[i] = 'e';
                else if (let == 'b')
                    fraseTrocada[i] = 'x';
            }
            string result = new string(fraseTrocada);
            Console.WriteLine(result);
            /*string frase;
            frase = Console.ReadLine().ToUpper();

            //frase = Console.ReadLine().ToUpper().Split();

            String str = "Geeks For Geeks";

            /*Console.WriteLine("OldString : " + str);

            // replace the character 's' with 'G' 
            Console.WriteLine("NewString: " + str.Replace('s', 'G'));

            // oldString will remain unchanged 
            // its return the modified string 
            Console.WriteLine("\nOldString: " + str);

            // replace the character 'e' with space ' ' 
            Console.WriteLine("NewString: " + str.Replace('e', ' '));

            Console.WriteLine(
            frase.Replace('A', 'E'),
            frase.Replace('B', 'X'),
            frase.Replace('C', 'W'),
            frase.Replace("D", "R"),
            frase.Replace("E", "O"),
            frase.Replace("F", "T"),
            frase.Replace("G", "P"),
            frase.Replace("H", "S"),
            frase.Replace("I", "U"),
            frase.Replace("J", "D"),
            frase.Replace("K", "Q"),
            frase.Replace("L", "G"),
            frase.Replace("M", "H"),
            frase.Replace("N", "J"),
            frase.Replace("O", "I"),
            frase.Replace("P", "K"),
            frase.Replace("Q", "L"),
            frase.Replace("R", "Z"),
            frase.Replace("S", "M"),
            frase.Replace("T", "C"),
            frase.Replace("U", "Y"),
            frase.Replace("V", "B"),
            frase.Replace("W", "N"),
            frase.Replace("X", "F"),
            frase.Replace("Y", "A"),
            frase.Replace("Z", "V"));*/
        }
    }
}
