using System;
namespace Tabuleiro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quantas linhas no tabuleiro?: ");
            int linhas = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Quantas colunas no tabuleiro?: ");
            int colunas = int.Parse(Console.ReadLine());
            
            Console.Write("#");
            for(int l = 0; l < linhas; l++)
            {
                Console.Write("#");
            }
            Console.WriteLine("#");

            for(int l = 0; l < linhas; l++)
            {
                Console.Write("#");
                for(int c = 0; c < colunas; c++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }
            Console.Write("#");
            for (int l = 0; l < linhas; l++)
            {
                Console.Write("#");
            }
            Console.Write("#");
        }
    }
}  
