using System;

namespace Tabuleiro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de linhas do tabuleiro: ");
            int linhas = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o número de colunas do tabuleiro: ");
            int colunas = int.Parse(Console.ReadLine());
            
            Console.Write("#");
            for(int i = 0; i < linhas; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine("#");

            for(int i = 0; i < linhas; i++)
            {
                Console.Write("#");
                for(int j = 0; j < colunas; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }
            Console.Write("#");
            for (int i = 0; i < linhas; i++)
            {
                Console.Write("#");
            }
            Console.Write("#");
        }
    }
}    