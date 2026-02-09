namespace LoopFor;
// Estutura do FOR - (Iniciar Variavel ;  Distancia ; Sentido)
public class Program()
{
    public static void Main()
    {
        Console.WriteLine("===Tabela de Multiplicação===");

        for (int i = 1; i <=10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j, 4}"); // 6 numero de espaçamento
            }
            Console.WriteLine();
        }
    } 
}