using System;

namespace maioroumenor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro numero: ");
            double num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            double num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro numero: ");
            double num3 = int.Parse(Console.ReadLine());

            double maior;

            if (num1 > num2 && num1 > num3)
            {
                maior = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                maior = num2;
            }
            else
            {
                maior = num3;
            }

            double menor;

            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }

            Console.WriteLine(
                $"O maior valor entre {num1}, {num2} e {num3} é {maior}\nO menor valor entre {num1}, {num2} e {num3} é {menor} ");
            Console.ReadKey();
        }
    }
}    