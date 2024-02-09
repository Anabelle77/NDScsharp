namespace maioroumenor;

class Program
{
    private static void Main()
    {
        Console.WriteLine("Informe o primeiro numero: ");
        var num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Informe o segundo numero: ");
        var num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Informe o terceiro numero: ");
        var num3 = Convert.ToDouble(Console.ReadLine());

        double maior = Math.Max(Math.Max(num1, num2), num3);
        
        double menor = Math.Min(Math.Min(num1, num2), num3);
        
        Console.WriteLine(
            $"O maior valor entre {num1}, {num2} e {num3} é {maior}\nO menor valor entre {num1}, {num2} e {num3} é {menor} ");
        Console.ReadKey();
    }
}
