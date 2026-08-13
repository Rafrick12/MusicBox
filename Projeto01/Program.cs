// Proje do Music Box - Sistema de cadastro e avaliação de bandas


// funções posteriores a serem implementadas

//List<string> bandasRegistradas = new List<string> { "Imagine Dragons", "Raça Negra", "Rappa"};

Dictionary<string, List<int>>bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Imagine Dragons", new List<int> { 8, 9, 10 });
bandasRegistradas.Add("Raça Negra", new List<int> { });
bandasRegistradas.Add("Rappa", new List<int> { 9, 9, 10 });


void ExibirLogo()
{
    Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░  ██████╗░░█████╗░██╗░░██╗
████╗░████║██║░░░██║██╔════╝██║██╔══██╗  ██╔══██╗██╔══██╗╚██╗██╔╝
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝  ██████╦╝██║░░██║░╚███╔╝░
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗  ██╔══██╗██║░░██║░██╔██╗░
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝  ██████╦╝╚█████╔╝██╔╝╚██╗
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░  ╚═════╝░░╚════╝░╚═╝░░╚═╝");
    Console.WriteLine("\nBem-vindo ao Music Box");
}
void RegistrarBanda()
{

    Console.Clear();
    ExibirTitulo("Registrar Banda");
    Console.Write("\nDigite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso");
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();

}
void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Bandas Registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();

}
void ExibirTitulo(string titulo)
{
    int quantidadeLetrasTitulo = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeLetrasTitulo, '*');
    Console.WriteLine($"\n{asteristicos}\n{titulo}\n{asteristicos}\n");
}
void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar Banda");
    Console.Write("\nDigite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"\nDigite a nota para a banda {nomeBanda}: ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(notaBanda);
        Console.WriteLine($"\nA nota {notaBanda} foi registrada para a banda {nomeBanda} com sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada. \nPressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}
void MediaBanda()
{

    Console.Clear();
    ExibirTitulo("Média de Avaliação da Banda");
    Console.Write("\nDigite o nome da banda que deseja ver a média de avaliação: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notaBanda = bandasRegistradas[nomeBanda];
        Console.WriteLine($"A média da banda {nomeBanda} é {notaBanda.Average()}");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu");
        Console.ReadLine();
        Console.Clear();
        ExibirMenu();
    }
    else 
    {

        Console.WriteLine($"\nA banda {nomeBanda} não existe");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();

    }


}


// Parte principal do projeto o Menu
void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar as bandas registradas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a média de avaliação de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

   switch(opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaBanda();
            break;
        case 0:
            Console.WriteLine("\nSaindo do programa...");
            break;
        default:
            Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção válida.");
            break;
    }
}

    
ExibirMenu();
