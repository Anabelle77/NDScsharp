using System;

namespace ManipularString
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome completo?:\n ");
            string nome = "Anabelle Rodrigues";


            Console.WriteLine(nome.Trim());
            Console.WriteLine(nome.Replace(" ", ""));
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.Insert(7, "Ana"));
            Console.WriteLine(nome.Remove(9, 9));
            Console.WriteLine(nome.Contains("Rodrigues"));
            Console.WriteLine(nome.Replace(" ", "").Length);
           
        }
    }
}    
