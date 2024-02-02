namespace maiormenorparan
{
    class Program
    {
        private static void Main(string[] args)
        {
            int numero = 0;
            var maior = 0;
            var menor = 10000;

            do
            {
                Console.WriteLine("Informe um numero (ou 0 para sair): ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine($"O maior valor é {maior}");
                    Console.WriteLine($"O menor valor é {menor}");
                }
                else if (numero > maior)
                {
                    maior = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }
            } while (numero != 0);
        }
    }
}     
