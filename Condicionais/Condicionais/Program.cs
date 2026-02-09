namespace Condicionais;
//IF e ELSE em C#
//Verificador de numero par ou impar -> Nv. Básico.
public class Program()
{
    public static void Main()
    {
        Console.WriteLine("=====Verificador de Números Pares ou Impares=====");
        Console.WriteLine("Digite um número inteiro para verificar:");
        int numUser = Convert.ToInt32(Console.ReadLine());

        // condiçao para ser par -> resto da divisão ser igual a 0.

        if (numUser % 2 == 0)
        {
            Console.WriteLine("O número digitado é par!");
        }
        else 
        {
            Console.WriteLine("O número digitado é impar!");
        }

    }
}