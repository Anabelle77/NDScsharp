namespace maiormenorparan;
    
class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite números (sendo '0' para encerrar):");
        int numero;
        var menor = int.MaxValue;
        var maior = int.MinValue;

        do
        {
            numero = int.Parse(Console.ReadLine());
            if (numero != 0 && numero < menor)
            {
                menor = numero;
            }

            else if (numero != 0 && numero > maior)
            {
                maior = numero;
            }
        } 
        while (numero != 0);
        
        Console.WriteLine($"Menor valor: {menor}");
        Console.WriteLine($"Maior valor: {maior}");
    }
}
