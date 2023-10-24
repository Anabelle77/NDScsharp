namespace projetologin;

class Program
{
    class User
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }

    static List<User> usuarios = new List<User>();

    private static void Main(string[] args)
    {
        bool login = true;
        while (login)
        {
            Console.WriteLine("*===============* Página de Anabelle *===============*\n");
            Console.WriteLine("Essa é a Página de Anabelle, caso já tenha uma conta:");
            Console.WriteLine("Digite (1) - Login\n-----------------------------------------------------");
            Console.WriteLine("Se não possui uma conta, junte-se a nós agora mesmo:");
            Console.WriteLine("Digite (2) - Signup\n-----------------------------------------------------");
            Console.WriteLine("Se deseja sair da aplicação:");
            Console.WriteLine("Digite (0) - Sair\n-----------------------------------------------------");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Logar();
                    break;
                case "2":
                    Criarconta();
                    break;
                case "0":
                    login = false;
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Favor tente novamente...\n");
                    break;
            }
        }
    }
    
    private static void Criarconta()
    {
        Console.WriteLine("\nDigite o seu Nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a sua Senha:");
        string senha = Console.ReadLine();
        
        User novouser = new User { Nome = nome, Senha = senha };
        usuarios.Add(novouser);
     
        Console.WriteLine("\nSeu usuário foi cadastrado com sucesso!\n");
    }
    
    private static void Logar()
    {
        Console.WriteLine("\nDigite o seu Nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a sua Senha:");
        string senha = Console.ReadLine();

        User usuario = usuarios.Find(u => u.Nome == nome && u.Senha == senha);

        if (usuario != null)
        {
            Console.WriteLine($"\nSeja bem-vindo(a) novamente, {usuario.Nome}!\n");
        }
        else
        {
            Console.WriteLine("Login e/ou senha incorretos! Favor tente novamente...\n-----------------------------------------------------");
        }
    }
}
