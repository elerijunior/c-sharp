namespace OperadoresRelacionais;

public class Program()
{
    public static void Main()
    {
        Console.WriteLine("====Operadores Relacionais====\n");
        Console.WriteLine("Digite o primeiro número (x): \n");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número (y): \n");
        int y = Convert.ToInt32(Console.ReadLine());

        string result;

        // Operador de igualdade (==)
        if (x == y)
        {
            result = "O primeiro e o segundo número são iguais.\n";
        }
        else
        {
            result = "O primeiro e o segundo número sáo diferentes.\n";
        }
        Console.WriteLine(result);

        // Operador de diferença (!=)

        if (x != y)
        {
            result = "O primeiro e o segundo número sáo diferentes.\n";
        }
        else
        {
            result = "O primeiro e o segundo número são iguais.\n";
        }
        Console.WriteLine(result);

        // Operador Maior (>)
        if (x > y)
        {
            result = "O valor de X é maior que o de Y.";
        }
        else
        {
            result = "O valor de x é menor que de Y.";
        }
        Console.WriteLine(result);

        // Operador Menor (<)

        if (x < y)
        {
            result = "O valor de X é menor que o de Y.";
        }
        else
        {
            result = "O valor de X é maior que o de Y.";
        }
        Console.WriteLine(result);

        // Operador Maior Igual (>=)
        if (x >= y)
        {
            result = "X é maior ou igual a Y.";
        }
        else
        {
            result = "O valor de X não é maior ou igual Y.";
        }

        // Operador Menor Igual (<=)
        if (x <= y)
        {
            result = "X é menor ou igual a Y.";
        }
        else
        {
            result = "O valor de X não é maior ou igual Y.";
        }



    }
}