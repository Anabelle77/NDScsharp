namespace ProjLogin;

class Program
{
    class User
    {
        public string Nome { get; set; } = null!;
        public string Senha { get; set; } = null!;
    }

    private static List<User> _usuarios = new List<User>();

    private static void Main()
    {
        var inicio = true;
        while (inicio)
        {
            Console.WriteLine("*===============* Página de Anabelle *===============*\n");
            Console.WriteLine("Essa é a Página de Anabelle, caso já tenha uma conta:");
            Console.WriteLine("Digite (1) - Login\n-----------------------------------------------------");
            Console.WriteLine("Se não possui uma conta, junte-se a nós agora mesmo:");
            Console.WriteLine("Digite (2) - Signup\n-----------------------------------------------------");
            Console.WriteLine("Se deseja sair da aplicação:");
            Console.WriteLine("Digite (0) - Sair\n");
        
            var choice = Console.ReadLine(); 
    
            switch (choice)
            {
                case "1":
                    Logar();
                    break;
                case "2":
                    Criarconta();
                    break;
                case "0":
                    Console.WriteLine("Tchau, tchau :D");
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
        Console.Clear();
        string? nome;
        string? senha;

        do
        {
            Console.Clear();
            Console.WriteLine("Digite o seu Nome:");
            nome = Console.ReadLine();
            
            if (UserExistente(nome))
            {
                Console.WriteLine("\nUsuário com esse nome já existe. Escolha outro nome.\n");
                Thread.Sleep(2000);
            }
        } while (string.IsNullOrEmpty(nome) | UserExistente(nome));

        do
        {
            Console.WriteLine("Digite a sua Senha:");
            senha = Console.ReadLine();
        } while (string.IsNullOrEmpty(senha));
        
        var novouser = new User { Nome = nome, Senha = senha };
        _usuarios.Add(novouser);
        
        Console.WriteLine("\nSeu usuário foi cadastrado com sucesso!\n");
        Thread.Sleep(4000);
    }
    private static bool UserExistente(string nome)
    {
        return _usuarios.Any(u => u.Nome == nome);
    }
    private static void Logar()
    {
        Console.Clear();
        Console.WriteLine("Digite o seu Nome:");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite a sua Senha:");
        var senha = Console.ReadLine();

        var usuario = _usuarios.Find(user => user.Nome == nome & user.Senha == senha);

        if (usuario != null)
        {
            Console.WriteLine($"\nSeja bem-vindo(a) novamente, {usuario.Nome}!\n");
            Thread.Sleep(4000);
        }
        else
        {
            Console.WriteLine("\nLogin e/ou senha incorretos! Favor tente novamente...\n-----------------------------------------------------");
            Thread.Sleep(4000);
        }
    }
}
