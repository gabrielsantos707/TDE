using TDE;

Inventario inventario = new Inventario();
int opcao;

do
{
    DisplayMenu();
    opcao = GetUserInput("Escolha uma opção: ");

    switch (opcao)
    {
        case 1:
            AdicionarItem(inventario);
            break;
        case 2:
            inventario.ListarItens();
            break;
        case 3:
            EditarItem(inventario);
            break;
        case 4:
            RemoverItem(inventario);
            break;
        case 5:
            Console.WriteLine("Saindo do sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 5);

static void DisplayMenu()
{
    Console.WriteLine("Sistema de Gerenciamento de Inventário");
    Console.WriteLine("1. Adicionar Item");
    Console.WriteLine("2. Listar Itens");
    Console.WriteLine("3. Editar Item");
    Console.WriteLine("4. Remover Item");
    Console.WriteLine("5. Sair");
}

static int GetUserInput(string prompt)
{
    Console.Write(prompt);
    int result;
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write("Entrada inválida. " + prompt);
    }
    return result;
}

static void AdicionarItem(Inventario inventario)
{
    Console.Write("Nome do item: ");
    string nome = Console.ReadLine();
    int quantidade = GetUserInput("Quantidade: ");
    decimal preco = GetDecimalInput("Preço: ");

    Item item = new Item(nome, quantidade, preco);
    inventario.AdicionarItem(item);
}

static void EditarItem(Inventario inventario)
{
    inventario.ListarItens();

    int index = GetUserInput("Digite o número do item que deseja editar: ") - 1;

    if (index < 0 || index >= inventario.Count)
    {
        Console.WriteLine("Índice inválido.");
        return;
    }

    Console.Write("Novo nome do item: ");
    string nome = Console.ReadLine();
    int quantidade = GetUserInput("Nova quantidade: ");
    decimal preco = GetDecimalInput("Novo preço: ");

    Item novoItem = new Item(nome, quantidade, preco);
    inventario.EditarItem(index, novoItem);
}

static void RemoverItem(Inventario inventario)
{
    inventario.ListarItens();

    int index = GetUserInput("Digite o número do item que deseja remover: ") - 1;

    if (index < 0 || index >= inventario.Count)
    {
        Console.WriteLine("Índice inválido.");
        return;
    }

    inventario.RemoverItem(index);
}

static decimal GetDecimalInput(string prompt)
{
    Console.Write(prompt);
    decimal result;
    while (!decimal.TryParse(Console.ReadLine(), out result))
    {
        Console.Write("Entrada inválida. " + prompt);
    }
    return result;
}
