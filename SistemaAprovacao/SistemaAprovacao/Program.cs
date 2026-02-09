namespace SistemaAprovacao;
// Sistema de aprovaçao com switch case
public class Program()
{
    public static void Main()
    {
        Console.WriteLine("====Sistema de Aprovação====");
        Console.WriteLine("Digite sua nota");
        int score = Convert.ToInt32(Console.ReadLine());

        switch (score) {
            case 10:
            case 9:
                Console.WriteLine("Aprovado com nota máxima!");
                break;

            case 8:
            case 7:
                Console.WriteLine("Aprovado com uma boa nota!");
                break;

            case 6:
                Console.WriteLine("Aprovado na média!");
                break;

            case 5:
            case 4:
            case 3:
            case 2:
            case 1:
            case 0:
                Console.WriteLine("Reprovado!");
                break;

            default:
                Console.WriteLine("Sua nota tem que ser entre 0 e 10");
                break;
        }
    }
}