using System;

namespace QuantidadesDeLetras
{
    class Program
    {
        static void Main(string[] args)
        {

            string palavra = " ";
            string[] palavras;
            string maiorPalavra = "";



            Console.WriteLine("Entre com sua frase: ");

            while (true)
            {

                palavras = Console.ReadLine().Split(" ");
                if (palavras[0] == "0") { break; }

                for (int i = 0; i < palavras.Length; i++)
                {
                    if (palavras[i].Length >= maiorPalavra.Length)
                    {
                        maiorPalavra = palavras[i];
                    }
                    if (i == palavra.Length - 1)
                    {

                        palavra += $"{palavras[i].Length}-";

                    }
                    else
                    {
                        palavra += $"{palavras[i].Length}-";
                    }

                }
                Console.WriteLine(palavra);
                
            }
            


        }
    }
}



