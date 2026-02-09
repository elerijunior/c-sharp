namespace CalculadoraIntermediaria;

public class Program()
{
    public static void Main() 
    {
        Console.WriteLine("====Calculadora Intemediaria====");

        // recenbendo dados do usuario
        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        //recebendo operador
        Console.WriteLine("Escolha um operador");
        Console.WriteLine("1. Somar (+)");
        Console.WriteLine("2. Subtração (-)");
        Console.WriteLine("3. Multiplicação (*)");
        Console.WriteLine("4. Divisão (/)");
        int op = Convert.ToInt32(Console.ReadLine());
        double resul;

        // Operaçoes
        if (op == 1)
        {
            resul = num1 + num2;
            Console.WriteLine($"O resultado da soma é {resul}");
        }
        else if (op == 2)
        {
            resul = num1 - num2;
            Console.WriteLine($"O resultado da subtração é {resul}");
        }
        else if (op == 3)
        {
            resul = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é {resul}");
        }
        else if (op == 4)
        {
            resul = num1 / num2;
            Console.WriteLine($"O resultado da divisão é {resul}");
        }
        else
        {
            Console.WriteLine("Digite um operador valido");
        }
    }
}