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
                if (int.TryParse(input, out var tamanho))
                {
                    Console.Write("#");
                    for(var l = 0; l < tamanho; l++)
                    {
                        Console.Write("#");
                    }
                    
                    Console.WriteLine("#");
                    for(var l = 0; l < tamanho; l++)
                    {
                        Console.Write("#");
                        for(var c = 0; c < tamanho; c++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("#");
                    }
                    
                    Console.Write("#");
                    for (var l = 0; l < tamanho; l++)
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
