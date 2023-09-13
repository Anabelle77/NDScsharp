using System;

namespace Fibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a;
            int b = 1;
            int c = 0;
            int cont = 0;
            Console.WriteLine("Quantos números do fibonacci você quer imprimir?: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nFibonacci:");
            do
            {
                a = b + c;
                b = c;
                c = a;
                
                Console.WriteLine(a);
                cont++;
            } while (cont < num);
        }
    }    
}