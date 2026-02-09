
// Atividade Projeto - Menu -> Criar um programa de console em C# que simula um menu.

//Requisitos

//O programa deve:

//Mostrar um menu com opções:

//1 - Cadastrar usuário
//2 - Mostrar idade em meses
//3 - Verificar se é maior de idade
//0 - Sair


//O programa deve:

//Usar do while para manter o menu ativo

//Usar if / else ou switch para tratar a opção escolhida
namespace Menu;

public class Program
{
    public static void Main()
    {
        bool start = true;

        string userName = "";
        int age = 0;
        bool userRegistered = false;

        do
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Mostrar idade em meses");
            Console.WriteLine("3 - Verificar se é maior de idade");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            int res = Convert.ToInt32(Console.ReadLine());

            if (res == 1)
            {
                Console.WriteLine("Informe o nome do usuário:");
                userName = Console.ReadLine();

                Console.WriteLine("Informe a idade do usuário:");
                age = Convert.ToInt32(Console.ReadLine());

                userRegistered = true;
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }
            else if (res == 2)
            {
                if (!userRegistered)
                {
                    Console.WriteLine("Usuário não cadastrado.");
                }
                else
                {
                    int ageInMonths = age * 12;
                    Console.WriteLine($"Idade em meses: {ageInMonths}");
                }
            }
            else if (res == 3)
            {
                if (!userRegistered)
                {
                    Console.WriteLine("Usuário não cadastrado.");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Usuário é maior de idade.");
                }
                else
                {
                    Console.WriteLine("Usuário é menor de idade.");
                }
            }
            else if (res == 0)
            {
                Console.WriteLine("Encerrando o programa...");
                start = false;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine();

        } while (start);
    }
}
