using System;
namespace parouimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
            Console.ReadKey();
        }
    }
}