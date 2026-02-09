namespace CalculadoraSimples;

public class Prodram() 
{
    public static void Main() {

        Console.WriteLine("=====Calculadora Simples=====");
        
        
        Console.WriteLine("Digite o valor  primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor  segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        int soma = num1 + num2;
        int sub = num1 - num2;
        int mult = num1 * num2;
        int divi = num1 / num2;

        Console.WriteLine("=====Resultado!=====");

        Console.WriteLine($"A soma dos valores: {soma}");
        Console.WriteLine($"A subtração dos valores: {sub}");
        Console.WriteLine($"A multiplicação dos valores: {mult}");
        Console.WriteLine($"A divisão dos valores: {divi}");


    }
}