namespace Listas;
// Listas em C#
public class Program()
{
    public static void Main()
    {
        //1. Inicializando uma lista (ex: Frutas)

        List<string> fruits =  new List<string>() 
        {
            "Manga",
            "Morango",
            "Maça"
        };

        //2. Acessando a lista completa

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("------------------");

        //3. Acessando a lista por indice.

        Console.WriteLine(fruits[2]);

        Console.WriteLine("------------------");

        //4. Adicionar elementos a lista. Adiciona no ultimo indice (.add("");)

        fruits.Add("Limão");
        fruits.Add("Banana");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("------------------");

        //5. Remover elementos da lista. Remove no ultimo indice (.Remove("");)

        fruits.Remove("Morango");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //6. Contagem de indices da lista. (.Count)
        Console.WriteLine("------------------");

        Console.WriteLine($"O tamanho da lista de frutas é de {fruits.Count}.");

        Console.WriteLine("------------------");

        //7. Modificar um elemento da lista.

        fruits[2] = "Tangerina";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //8. Limpando a lista (.Clear())

        Console.WriteLine("------------------");

        fruits.Clear();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("------------------");

        //9. Inicializando lista sem declarar

        List<int> numbers = new List<int>();

        //numbers.Add(1);
        //numbers.Add(2);
        //numbers.Add(3);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("------------------");
    }
}