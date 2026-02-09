namespace SwitchCase;
//verificando dias da seman com Switch case
public class Program()
{
    public static void Main()
    {
        Console.WriteLine("====Dia da Semana====");
        Console.WriteLine("Digite um número de 1 a 7");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("O dia da semana é: Domingo");
                break;

            case 2:
                Console.WriteLine("O dia da semana é: Segunda-Feira");
                break;

            case 3:
                Console.WriteLine("O dia da semana é: Terça-Feira");
                break;

            case 4:
                Console.WriteLine("O dia da semana é: Quarta-Feira");
                break;

            case 5:
                Console.WriteLine("O dia da semana é: Quinta-Feira");
                break;

            case 6:
                Console.WriteLine("O dia da semana é: Sexta-Feira");
                break;

            case 7:
                Console.WriteLine("O dia da semana é Sábado");
                break;

            default: // funciona como um else em switch case C#
                Console.WriteLine("O dia escolhido é inválido");
                break;
        }
    }
}