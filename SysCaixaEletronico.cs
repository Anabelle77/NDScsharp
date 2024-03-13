namespace SysCaixaEletronico;

class SysCaixaEletronico
{
    class User
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int Saldo { get; set; }
    }

    static List<User> _usuarioslista = new List<User>();

    private static void Main()
    {
        var inicio = true;
        while (inicio)
        {
            Console.Clear();
            Console.WriteLine("*================* Caixa Eletrônico *================*\n");
            Console.WriteLine("Você deseja criar uma conta ou acessar uma existente?:");
            Console.WriteLine("Digite (1) - Login\n-----------------------------------------------------");
            Console.WriteLine("Digite (2) - Signup\n-----------------------------------------------------");
            Console.WriteLine("Se deseja sair da aplicação:");
            Console.WriteLine("Digite (0) - Sair\n");
        
            var choice = Console.ReadLine(); 
    
            switch (choice)
            {
                case "0":
                    Console.WriteLine("Tchau, tchau :D");
                    inicio = false;
                    break;
                case "1":
                {
                    if (_usuarioslista.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("O sistema deve conter ao menos um usuário para funcionar!");
                    }
                }
                    AcessarCaixa();
                    break;
                case "2":
                    Criaruser();
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Favor tente novamente...\n");
                    Console.Clear();
                    break;
            }
        }
    }
    static void Criaruser()
    {
        Console.Clear();
        string? nome;
        string? senha;
        var saldoRandom = new Random();
        var saldo = saldoRandom.Next(0, 5001);

        do
        {
            Console.Clear();
            Console.WriteLine("Digite o seu Nome:");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite a sua Senha:");
            senha = Console.ReadLine();
        } while (string.IsNullOrEmpty(senha) | string.IsNullOrEmpty(nome));
        
        var novouser = new User
        {
            Nome = nome;
            Senha = senha;
            Saldo = saldo;
        };
        
        _usuarioslista.Add(novouser);
        
        Console.WriteLine("\nSeu usuário foi cadastrado com sucesso!\n");
        Thread.Sleep(3000);
    }
    static void AcessarCaixa()
    {
        Console.Clear();
        Console.WriteLine("Digite o seu Nome:");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite a sua Senha:");
        var senha = Console.ReadLine();
        var usuario = _usuarioslista.Find(user => user.Nome == nome & user.Senha == senha);

        if (usuario != null)
        {
            Console.WriteLine($"\nSeja bem-vindo(a) novamente, {usuario.Nome}!\n");
            Thread.Sleep(3000);
            Escolha(usuario);
        }
        else
        {
            Console.WriteLine("\nNome de usuário e/ou senha incorretos, por favor, tente novamente...\n");
            Thread.Sleep(3000);
        }
    }

    static void Escolha(User usuario)
    {
        Console.Clear();
        Console.WriteLine("Escolha a sua ação desejada: ");
        Console.WriteLine("(0) - Voltar\n(1) - Depositar\n(2) - Sacar\n(3) - Verificar Saldo");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "0":
            {
                Main();
                break;
            }
            case "1":
            {
                Console.Clear();
                Depositar(usuario);
                break;
            }
            case "2":
            {
                Console.Clear();
                Sacar(usuario);
                break;
            }
            case "3":
            {
                VerifiSaldo(usuario);
                break;
            }
            default:
                Console.WriteLine("\nOpção inválida! Favor tente novamente...\n");
                Escolha(usuario);
                break;
        }
    }

    static void Depositar(User usuario)
    {
        Console.Clear();
        Console.WriteLine($"Quanto deseja depositar, {usuario.Nome}?");
        var botarDinheiro = Console.ReadLine();
        if (int.TryParse(botarDinheiro, out var valorDeposito) & valorDeposito > 0 & valorDeposito <= usuario.Saldo)
        {
            usuario.Saldo += valorDeposito;
            Console.WriteLine($"Depósito de {valorDeposito}R$ realizado com sucesso. Novo saldo: {usuario.Saldo}R$");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Valor inválido/nulo. Por favor, insira um valor válido para o depósito.");
            Thread.Sleep(2000);
            Depositar(usuario);
        }
        Thread.Sleep(2000);
        string? sair;
        do
        {
            Console.WriteLine("\nPressione '0' para voltar.");
            sair = Console.ReadLine();

            if (sair != "0")
            {
                Console.Clear();
                Console.WriteLine("Você digitou algo diferente de '0'.");
                Thread.Sleep(2000);
            }

        } while (sair != "0");
        Escolha(usuario);
    }
    static void Sacar(User usuario)
    {
        Console.WriteLine($"Quanto deseja sacar, {usuario.Nome}?");
        var tirarDinheiro = Console.ReadLine();
        if (int.TryParse(tirarDinheiro, out var valorSacado) & valorSacado > 0 & valorSacado <= usuario.Saldo)
        {
            usuario.Saldo -= valorSacado;
            if (usuario.Saldo < 0)
            {
                usuario.Saldo = 0;
            }
            Console.WriteLine($"Saque de {valorSacado}R$ realizado com sucesso. O seu novo saldo é de: {usuario.Saldo}R$");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Valor inválido/nulo ou maior que saldo de {usuario.Saldo}R$. Por favor, insira um valor válido para o saque.");
            Thread.Sleep(2000);
            Sacar(usuario);
        }
        Thread.Sleep(2000);
        string? sair;
        do
        {
            Console.WriteLine("\nPressione '0' para voltar.");
            sair = Console.ReadLine();

            if (sair != "0")
            {
                Console.Clear();
                Console.WriteLine("Você digitou algo diferente de '0'.");
            }

        } while (sair != "0");
        Escolha(usuario);
    }
    static void VerifiSaldo(User usuario)
    {
        Console.Clear();
        Console.WriteLine($"Seu saldo é de: {usuario.Saldo}R$");
        Thread.Sleep(2000);
        string? sair;
        do
        {
            Console.WriteLine("\nPressione '0' para voltar.");
            sair = Console.ReadLine();

            if (sair != "0")
            {
                Console.Clear();
                Console.WriteLine("Você digitou algo diferente de '0'.");
            }

        } while (sair != "0");
        Escolha(usuario);
    }
}
