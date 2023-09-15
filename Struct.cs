namespace Struct;
public class Struct
{
    public static void Main(string[] args)
    {
        var usuario = new User("Anabelle", "Rodrigues", 19, 1.63);
    }

    public struct User
    {
        public User(string name, string lastname, int idade, double altura)
        {
            Name = name;
            LastName = lastname;
            Idade = idade;
            Altura = altura;
            
            Console.WriteLine("Name: "+Name+", Last Name: "+LastName+", Idade: "+Idade+", Altura: "+Altura);
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

    }
}
