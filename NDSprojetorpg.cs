namespace NDSprojetorpg;
public class Struct
{
    public static void Main()
    {
        Jogo();
    }
    public static void Jogo()
    {
        int opcao; 
        bool sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao RPG, informe a classe que deseja jogar ou sair da aplicação:");
            Console.WriteLine("(0) - Sair do RPG");
            Console.WriteLine("(1) - Guerreiro");
            Console.WriteLine("(2) - Arqueiro");
            Console.WriteLine("(3) - Assassino");
            Console.WriteLine("(4) - Mago");
            
            var input = Console.ReadLine();

            if (int.TryParse(input, out opcao))
            {
                switch (opcao)
                {
                    case 0: 
                        Console.WriteLine("\nTchau Tchau :D"); 
                        sair = true; 
                        Environment.Exit(0); 
                        break;
                    case 1: GuerreiroRpg(); 
                        break;
                    case 2: ArqueiroRpg(); 
                        break;
                    case 3: AssassinoRpg(); 
                        break;
                    case 4: MagoRpg(); 
                        break;
                    default: Jogo(); 
                        break;
                }
            }
            else
            {
                Jogo();
            }
        }
    }
    public struct Heroi
    {
        public Heroi(string classe, double vida, double poderatk, int speed)
        {
            Classe = classe;
            Vida = vida;
            PoderAtk = poderatk;
            Speed = speed;
        }
        public string Classe { get; set; }
        public double Vida { get; set; }
        public double PoderAtk { get; set; }
        public int Speed { get; set; }
    }
    public struct Vilao
    {
        public Vilao(string nome, double vida, double poderatk, int speed)
        {
            Nome = nome;
            Vida = vida;
            PoderAtk = poderatk;
            Speed = speed;
        }
        public string Nome { get; set; }
        public double Vida { get; set; }
        public double PoderAtk { get; set; }
        public int Speed { get; set; } 
    }
    public static void GuerreiroRpg()
    {
        var guerreiro = new Heroi("Guerreiro", 1200, 140,1);
        var vilao = VilaoAparece();
        Console.Clear();
        Console.WriteLine("Você escolheu a classe: Guerreiro");
        Console.WriteLine($"Seus atributos são:\nVida = {guerreiro.Vida}\nPoder de Ataque = {guerreiro.PoderAtk}\nVelocidade = {guerreiro.Speed}");
        Console.WriteLine("\nVocê sai em busca de inimigos...");
        Thread.Sleep(6000);
        Console.Clear();
        Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
        Combate(guerreiro, vilao);
    }
    public static void ArqueiroRpg()
    {
        Console.Clear();
        var arqueiro = new Heroi("Arqueiro", 900, 170,2);
        var vilao = VilaoAparece();
        Console.Clear();
        Console.WriteLine("Você escolheu a classe: Arqueiro");
        Console.WriteLine($"Seus atributos são:\nVida = {arqueiro.Vida}\nPoder de Ataque = {arqueiro.PoderAtk}\nVelocidade = {arqueiro.Speed}");
        Console.WriteLine("\nVocê sai em busca de inimigos...");
        Thread.Sleep(6000);
        Console.Clear();
        Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
        Combate(arqueiro, vilao);
    }
    public static void AssassinoRpg()
    {
        Console.Clear();
        var assassino = new Heroi("Assassino", 800, 220,3);
        var vilao = VilaoAparece();
        Console.Clear();
        Console.WriteLine("Você escolheu a classe: Assassino");
        Console.WriteLine($"Seus atributos são:\nVida = {assassino.Vida}\nPoder de Ataque = {assassino.PoderAtk}\nVelocidade = {assassino.Speed}");
        Console.WriteLine("\nVocê sai em busca de inimigos...");
        Thread.Sleep(6000);
        Console.Clear();
        Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
        Combate(assassino, vilao);
    }
    public static void MagoRpg() 
    {
        var mago = new Heroi("Mago", 700, 250,1);
        var vilao = VilaoAparece();
        Console.Clear();
        Console.WriteLine("Você escolheu a classe: Mago");
        Console.WriteLine($"Seus atributos são:\nVida = {mago.Vida}\nPoder de Ataque = {mago.PoderAtk}\nVelocidade = {mago.Speed}");
        Console.WriteLine("\nVocê sai em busca de inimigos...");
        Thread.Sleep(6000);
        Console.Clear();
        Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
        Combate(mago, vilao); 
    }
    public static Vilao VilaoAparece()
    {
        var slime = new Vilao("Slime", 10, 5,0);
        var ladrao = new Vilao("Ladrão", 1500, 90,3);
        var reigoblin = new Vilao("Rei Goblin", 1600, 100,1);
        var aranhagigante = new Vilao("Aranha Gigante", 1400, 110,2);
        var dragao = new Vilao("Dragão Bebê", 900, 160,3);

        var num = new Random();
        int vilaoapareceu = num.Next(1, 6);

        switch (vilaoapareceu) 
        {
            case 1: return slime;
            case 2: return ladrao;
            case 3: return reigoblin;
            case 4: return aranhagigante;
            case 5: return dragao;
            default: VilaoAparece(); 
                break; 
        }
        return VilaoAparece();
    }
    public static void Combate(Heroi heroi, Vilao vilao)
    {
        Console.WriteLine($"\nSeus atributos: Vida = {heroi.Vida}, Poder de Ataque = {heroi.PoderAtk}, Velocidade = {heroi.Speed}");
        Console.WriteLine($"Atributos do vilão {vilao.Nome}: Vida = {vilao.Vida}, Poder de Ataque = {vilao.PoderAtk}, Velocidade = {vilao.Speed}");
        Movimento(heroi.Vida, heroi.PoderAtk, heroi.Speed, vilao.Nome,vilao.Vida, vilao.PoderAtk, vilao.Speed);
    }
    public static void Movimento(double heroivida, double heroipoderatk, int heroispeed, string vilaonome, double vilaovida, double vilaopoderatk, int vilaospeed)
    {
        Console.WriteLine($"\nO inimigo {vilaonome} vai atacar!\nFaça um movimento:");
        Console.WriteLine("(1) - Atacar");
        Console.WriteLine("(2) - Esquivar");

        int opcao;
        if (int.TryParse(Console.ReadLine(), out opcao))
        {
            if (heroispeed > vilaospeed)
            {
                switch (opcao)
                {
                    case 1:
                        Atacar(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
                        break;
                    case 2:
                        Esquivar(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk,vilaospeed);
                        break;
                    default:
                        Console.Clear();
                        Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk,vilaospeed);
                        break;
                }
            }
            else if (vilaospeed > heroispeed)
            {
                switch (opcao)
                {
                    case 1:
                        VilaoAtacar(vilaonome, vilaovida, vilaopoderatk, vilaospeed, heroivida, heroipoderatk, heroispeed);
                        break;
                    case 2:
                        Esquivar(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
                        break;
                    default:
                        Console.Clear();
                        Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
                        break; 
                }
            }
            else
            {
                switch (opcao)
                {
                    case 1:
                        var numero = new Random();
                        var sorteatk = numero.Next(1, 3);

                        if (sorteatk == 1)
                        {
                            Atacar(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
                        }

                        if (sorteatk == 2)
                        {
                            VilaoAtacar(vilaonome, vilaovida, vilaopoderatk, vilaospeed, heroivida, heroipoderatk, heroispeed);
                        }
                        break;
                    case 2:
                        Esquivar(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
                        break;
                    default:
                        Console.Clear();
                        Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
                        break;
                }
                
            }
        }
        else
        {
            Console.Clear(); Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
        }
    }
    public static void Atacar(double heroivida, double heroipoderatk, int heroispeed, string vilaonome, double vilaovida, double vilaopoderatk, int vilaospeed)
    {
        var a = new string('-', 88);
        Console.Clear();
        Console.WriteLine("Você atacou!");
        vilaovida -= heroipoderatk;
        if (vilaovida <= 0)
        {
            vilaovida = 0;
        }
        Console.WriteLine($"Atributos do inimigo {vilaonome}: Vida = {vilaovida}, Poder de Ataque = {vilaopoderatk}, Velocidade = {vilaospeed}");
        Console.WriteLine(a);
        if (vilaovida <= 0)
        {
            Console.WriteLine("\nVocê conseguiu derrotar o inimigo!!!");
            Thread.Sleep(6000);
            Jogo();
        }
        Console.WriteLine("O vilão atacou!");
        heroivida -= vilaopoderatk;
        if (heroivida <= 0)
        {
            heroivida = 0;
        }
        Console.WriteLine($"Seus atributos: Vida = {heroivida}, Poder de Ataque = {heroipoderatk}, Velocidade = {heroispeed}");
        Console.WriteLine(a);
        if (heroivida <= 0)
        {
            Console.WriteLine("Você morreu!");
            Thread.Sleep(6000);
            Jogo();
        }
        Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
    }

    public static void VilaoAtacar(string vilaonome, double vilaovida, double vilaopoderatk, int vilaospeed, double heroivida, double heroipoderatk, int heroispeed)
    {
        var a = new string('-', 88);
        Console.Clear();
        Console.WriteLine("O vilão atacou!");
        heroivida -= vilaopoderatk;
        if (heroivida <= 0)
        {
            heroivida = 0;
        }
        Console.WriteLine($"Seus atributos: Vida = {heroivida}, Poder de Ataque = {heroipoderatk}, Velocidade = {heroispeed}");
        Console.WriteLine(a);
        if (heroivida <= 0)
        {
            Console.WriteLine("Você morreu!");
            Thread.Sleep(6000);
            Jogo();
        }
        Console.WriteLine("Você atacou!");
        vilaovida -= heroipoderatk;
        if (vilaovida <= 0)
        {
            vilaovida = 0;
        }
        Console.WriteLine($"Atributos do inimigo {vilaonome}: Vida = {vilaovida}, Poder de Ataque = {vilaopoderatk}, Velocidade = {vilaospeed}");
        Console.WriteLine(a);
        if (vilaovida <= 0)
        {
            Console.WriteLine("\nVocê conseguiu derrotar o inimigo!!!");
            Thread.Sleep(6000);
            Jogo();
        }
        Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
    }
    
    public static void Esquivar(double heroivida, double heroipoderatk, int heroispeed, string vilaonome, double vilaovida, double vilaopoderatk, int vilaospeed)
    {
        var a = new string('-', 88);
        var num = new Random();
        var sorte = num.Next(1, 7);

        if (sorte == 1 | sorte == 2)
        {
            Console.Clear();
            Console.WriteLine("O vilão atacou!");
            Console.WriteLine("Você não conseguiu se esquivar totalmente do ataque, mas deu um pouco de dano no vilão");
            heroivida -= (vilaopoderatk / 5);
            if (heroivida <= 0)
            {
                heroivida = 0;
            }
            vilaovida -= (heroipoderatk / 2);
            if (vilaovida <= 0)
            {
                vilaovida = 0;
            }
            Console.WriteLine(a);
            Console.WriteLine($"Seus atributos: Vida = {heroivida}, Poder de Ataque = {heroipoderatk}, Velocidade = {heroispeed}");
            Console.WriteLine($"Atributos do inimigo {vilaonome}: Vida = {vilaovida}, Poder de Ataque = {vilaopoderatk}, Velocidade = {vilaospeed}");
            Console.WriteLine(a);
            if (vilaovida <= 0)
            {
                Console.WriteLine("\nVocê conseguiu derrotar o inimigo!!!");
                Thread.Sleep(6000);
                Jogo();
            }
            if (heroivida <= 0)
            {
                Console.WriteLine("\nVocê morreu!!!");
                Thread.Sleep(6000);
                Jogo();
            }
            Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
        }
        if (sorte == 3)
        {
            Console.Clear();
            Console.WriteLine("O vilão atacou!\nVocê não conseguiu se esquivar!!");
            Console.WriteLine(a);
            heroivida -= vilaopoderatk;
            if (heroivida <= 0)
            {
                heroivida = 0;
            }
            Console.WriteLine($"Seus atributos: Vida = {heroivida}, Poder de Ataque = {heroipoderatk}, Velocidade = {heroispeed}");
            Console.WriteLine($"Atributos do inimigo {vilaonome}: Vida = {vilaovida}, Poder de Ataque = {vilaopoderatk}, Velocidade = {vilaospeed}");
            Console.WriteLine(a);
            if (heroivida <= 0)
            {
                Console.WriteLine("Você morreu!");
                Thread.Sleep(6000);
                Jogo();
            }
            Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
        }
        if (sorte == 4 | sorte == 5 | sorte == 6)
        {
            Console.Clear();
            Console.WriteLine("O vilão atacou!\nVocê conseguiu se esquivar!!");
            Console.WriteLine(a);
            Console.WriteLine($"Seus atributos: Vida = {heroivida}, Poder de Ataque = {heroipoderatk}, Velocidade = {heroispeed}");
            Console.WriteLine($"Atributos do inimigo: Vida = {vilaovida}, Poder de Ataque = {vilaopoderatk}, Velocidade = {vilaospeed}");
            Console.WriteLine(a);
        }
        Movimento(heroivida, heroipoderatk, heroispeed, vilaonome, vilaovida, vilaopoderatk, vilaospeed);
    }
}