namespace maiormenorparan
    
static void Main()
    {
        Console.WriteLine("Digite números (digite 0 para encerrar):");
        int numero;
        int menor = int.MaxValue;
        int maior = int.MinValue;

        do
        {
            numero = int.Parse(Console.ReadLine());
            if (numero != 0)
            {
                if (numero < menor)
                {
                    menor = numero;
                }
                
                if (numero > maior)
                {
                    maior = numero;
                }
            }
        } 
        while (numero != 0);
        
        Console.WriteLine($"Menor valor: {menor}");
        Console.WriteLine($"Maior valor: {maior}");
    }
}     
