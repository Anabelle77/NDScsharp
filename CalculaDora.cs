using System;

namespace CalculaDora
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BEM-VINDO À CalculaDora\\nQual operação deseja utilizar?:");
            Console.WriteLine("1 - SOMA\n2 - SUBTRAÇÃO\n3 - MULTIPLICAÇÃO\n4 - DIVISÃO\n0 - sair");
            
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 0)
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Insira um número: ");
            double num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro número: ");
            double num2 = int.Parse(Console.ReadLine());

            
            if (escolha == 1)
            {
                double op = (num1 + num2);
                Console.WriteLine($"O resultado é: {op}");
            }
            
            else if (escolha == 2)
            {
                double op = (num1 - num2);
                Console.WriteLine($"O resultado é: {op}");
            }
            
            else if (escolha == 3)
            {
                double op = (num1 * num2);
                Console.WriteLine($"O resultado é: {op}");
            }
            
            else if (escolha == 4)
            {
                double op = (num1 / num2);
                Console.WriteLine($"O resultado é: {op}");
            }

        }
    }
}