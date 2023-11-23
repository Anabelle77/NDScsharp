namespace aplicativ
{ 
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Qual tamanho das linhas e colunas do tabuleiro?: ");
            var input = Console.ReadLine();

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
