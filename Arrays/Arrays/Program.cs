namespace Arrays;

public class Program()
{
    public static void Main()
    {
        //1. Declarando um Array em C#

        string[] fruits = {"Maçã", "Banana", "Abacaxi", "Morango"};

        //2. Acessar valores de um Array em C# -> Nome do array + indice
       
        Console.WriteLine(fruits[0]);

        Console.WriteLine("--------------------------------");

        foreach (string fruit in fruits) 
        {
            Console.WriteLine(fruit);

        }

        Console.WriteLine("--------------------------------");
        //3. Contador de indices de um array em C# -> Nome do array + .length

        Console.WriteLine($"Quantidade de indices: {fruits.Length}");

        //4. Altenrando valores do array em C# por indice -> 
        
        Console.WriteLine("--------------------------------");
        
        fruits[1] = "Laaaaaaaa";

        Console.WriteLine($"O novo valor do array foi alterado para: {fruits[1]}");

        //5. Criar um Array sem atribuir incidides -> precisa informar o tamanho com new tipo[tamanho] -> Mesmo tendo tamanho, inicia zerado nos indices.

        Console.WriteLine("--------------------------------");
        int[] numbers = new int[3];

        //numbers[0] = 10;
        //numbers[1] = 20;
        //numbers[2] = 30;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}