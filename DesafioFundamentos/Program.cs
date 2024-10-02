using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("\nSeja bem vindo ao sistema de estacionamento!\n\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Clear(); // Adicionei um clear para limpar a tela.


Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());
Console.Clear();// Adicionei um clear para limpar a tela.


// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{

    Console.WriteLine("Digite a sua opção:\n");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear(); // Adicionei um clear para limpar a tela.      
            es.AdicionarVeiculo();
            break;
        case "2":
            Console.Clear();// Adicionei um clear para limpar a tela.
            es.RemoverVeiculo();
            break;

        case "3":
            Console.Clear();// Adicionei um clear para limpar a tela.
            es.ListarVeiculos();
            break;

        case "4":
            Console.Clear();// Adicionei um clear para limpar a tela.
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
    Console.Clear();// Adicionei um clear para limpar a tela.

}

Console.WriteLine("O programa se encerrou!!");
