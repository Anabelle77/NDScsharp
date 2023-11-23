namespace tabuleiro
{ 
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Quantas linhas e colunas no tabuleiro?: ");
            string input = Console.ReadLine();

            if (input != null)
            {
                if (int.TryParse(input, out int tamanho))
                {
                    Console.Write("#");
                    for(int l = 0; l < tamanho; l++)
                    {
                        Console.Write("#");
                    }
                    
                    Console.WriteLine("#");
                    for(int l = 0; l < tamanho; l++)
                    {
                        Console.Write("#");
                        for(int c = 0; c < tamanho; c++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("#");
                    }
                    
                    Console.Write("#");
                    for (int l = 0; l < tamanho; l++)
                    {
                        Console.Write("#");
                    }
                    Console.Write("#");
                }
                else
                {
                    Main();
                }
            }
            else
            {
                Main();
            }
        }
    }
}
