namespace Struct;
public class Struct
{
    public static void Main(string[] args)
    {
        var usuario = new User("Anabelle", "Rodrigues", 19, 1.63);
    }
    struct User
    {
        public User(string name, string lastname, int idade, double altura)
        {
            Name = name;
            LastName = lastname;
            Idade = idade;
            Altura = altura;
        }
        
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        
    }
}