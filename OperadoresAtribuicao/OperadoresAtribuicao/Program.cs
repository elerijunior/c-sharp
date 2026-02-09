namespace OperadoresAtribuicao;

public class Program() 
{
    public static void Main()
    {
        Console.WriteLine("=====Opedadores de Atribuiçao=====");

        //iniciando uma variavel zerada
        int x = 0;
        Console.WriteLine($"\nO valor inicial de x é: {x}.");

        // atribuiçao simples (=)
        x = 10;
        Console.WriteLine($"\nO valor agora de x é (=): {x}.");

        //atribuiçao por incremento
        x++; // mesma coisa de x = x + 1;
        Console.WriteLine($"\nO valor de x por incremento (x++): {x}.");

        //atruibçao por decremento
        x--; // mesma coisa de x = x - 1;
        Console.WriteLine($"\nO valor de x por decremento (x--): {x}.");

        // atribuiçao composta -  Serve para todos os operadores aritmeticos ( + - * /)
        x += 10; // mesma coisa de x = x + 10
        Console.WriteLine($"\nO valor de x por atribuiçao composta (x+=10): {x}.");

    }
}