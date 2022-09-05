using System;

namespace QuantidadesDeLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string palavras = " ";
            int[] contador ;
            string[] palavra;



            Console.WriteLine("Entre com sua frase: ");
            
                while (palavras != "0")
                {

                    palavras = Console.ReadLine();


                    for (int i = 0; i < palavras.Length; i++)
                    {
                        
                        if (Char.IsLetter(palavras[i]))
                        {

                        contador[i]++;
                         
                        }

                    }
                    
                }
                Console.WriteLine(contador);
            }
        }
    }

}

