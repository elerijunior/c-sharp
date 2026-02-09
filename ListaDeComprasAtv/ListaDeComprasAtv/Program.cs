namespace ListaDeComprasAtv;
using System.IO;

// Atividade de revisão geral (antes de POO).
public class Program
{
    public static void Main() 
    {
        //1. Estrutura da Lista
        
        string path = @"D:\c-sharp\ListaDeComprasAtv\ListaDeComprasAtv\";
        string fileName = "Lista_de_Compras.txt";
        string filePath = path + fileName;

        List<string> shoppingList = new List<string>();

        //2. Lógica

        if (File.Exists(filePath))
        {
            shoppingList.AddRange(File.ReadAllText(filePath));
        }

        while (true)
        {
            Console.WriteLine("--- Lista de Compras ---");
            Console.WriteLine("1. Adicionar item a lista");
            Console.WriteLine("2. Remover item da lista");
            Console.WriteLine("3. Ver lista");
            Console.WriteLine("4. Exportar lista .txt");

            string userEnter = Console.ReadLine();

            switch (userEnter)
            {

                case "1":
                    Console.WriteLine("Digite o nome do item que deseja adicionar: ");
                    string itemUser = Console.ReadLine();

                    if (!string.IsNullOrEmpty(itemUser))
                    {
                        shoppingList.Add(itemUser);
                        Console.WriteLine($"Seu item '{itemUser}' foi adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Seu item não pode ser vazio.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Digite o nome do item que deseja remover: ");
                    string removeItem = Console.ReadLine();

                    if (shoppingList.Remove(removeItem))
                    {
                        Console.WriteLine($"Seu item '{removeItem}' foi removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Seu item '{removeItem}' não foi encontrado!");
                    }

                    break;

                case "3":
                    Console.WriteLine("Sua lista de compras: ");

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                    }
                    break;

                case "4":
                    File.WriteAllLines(filePath, shoppingList);
                    Console.WriteLine("Lista criada com sucesso! Saindo");
                    return;

                default:
                    Console.WriteLine("Entrada Inválida! Tente novamente.");
                break;
            }
        }
    }
}
