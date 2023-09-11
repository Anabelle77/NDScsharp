using System;

namespace MediaAritmetica
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            double valor2 = int.Parse(Console.ReadLine());
            
            double media = (valor1 + valor2) / 2;
            
            Console.WriteLine($"A média dos valores é: {media}");
        }
    }
}        
