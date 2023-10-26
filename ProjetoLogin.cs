namespace projetologin;

class Program
{
    class User
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }

    private static List<User> _usuarios = new List<User>();

    private static void Main(string[] args)
    {
        bool inicio = true;
        while (inicio)
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
                    inicio = false;
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Favor tente novamente...\n");
                    break;
            }
        }
    }
    
    private static void Criarconta()
    {
        string nome;
        string senha;

        do
        {
            Console.WriteLine("\nDigite o seu Nome:");
            nome = Console.ReadLine();
        } while (string.IsNullOrEmpty(nome));

        do
        {
            Console.WriteLine("Digite a sua Senha:");
            senha = Console.ReadLine();
        } while (string.IsNullOrEmpty(senha));
        User novouser = new User { Nome = nome, Senha = senha };
        _usuarios.Add(novouser);
        
        Console.WriteLine("\nSeu usuário foi cadastrado com sucesso!\n");
    }

    private static void Logar()
    {
        Console.WriteLine("Digite o seu Nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a sua Senha:");
        string senha = Console.ReadLine();

        User usuario = _usuarios.Find(User => User.Nome == nome & User.Senha == senha);

        if (usuario != null)
        {
            Console.WriteLine($"\nSeja bem-vindo(a) novamente, {usuario.Nome}!\n");
        }
        else
        {
            Console.WriteLine("\nLogin e/ou senha incorretos! Favor tente novamente...\n-----------------------------------------------------");
        }
    }
}
