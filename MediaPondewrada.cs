using System;

namespace MediaAritmetica
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira a primeira nota para a média ponderada: ");
            double nota1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual peso para essa primeira nota?: ");
            double peso1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota para a média ponderada: ");
            double nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual peso para essa segunda nota?: ");
            double peso2 = int.Parse(Console.ReadLine());

            double mp = ((nota1 * peso1) + (nota2 * peso2))/(peso1 + peso2);
            
            Console.WriteLine($"A média ponderada é: {mp}");
        }
    }
}    