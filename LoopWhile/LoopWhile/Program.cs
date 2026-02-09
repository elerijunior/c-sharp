namespace LoopWhile;
// estrutura While
//Sistema de carteira
public class Program()
{
    public static void Main() 
    {
        Console.WriteLine("====Carteira Digital====\n");
        Console.WriteLine("Seu saldo é de R$ 100,00");

        double budget = 100;

        while (budget > 0) {
            Console.WriteLine("Digite o valor da compra.\n");
            double buy = Convert.ToDouble(Console.ReadLine());
         
            if (buy <= budget)
            {
                budget = budget - buy;
                Console.WriteLine("Compra Aprovada!");
                Console.WriteLine($"Seu novo saldo é de {budget}");
            }
            else
            {
                Console.WriteLine("Saldo Insifuciente!");
            }
        }

    }
}