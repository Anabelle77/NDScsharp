using System;

namespace MediaParaNValor;

class Program
{
    public static void Main(string[] args)
    {
        {
            var cont = 0;
            var num = 0;
            var total = 0;
            do
            {
                Console.WriteLine("Insira o valor (0 para sair): ");
                num = int.Parse(Console.ReadLine());
            
                if (num == 0)
                {
                    Console.WriteLine($"A media de todos os valores é {total/cont}");
                }
            
                total += num;
                cont++;
              while (num != 0);
            } 
        }
    }
}
    
