namespace OperadoresLogicos;
// verificar se o usuario está logado e permissoes no sistema
public class Program()
{
    public static void Main()
    {
        Console.WriteLine("=====Operadores Logicos=====\n");
        Console.WriteLine("Status do usuário\n");

        bool isLogged = false;
        bool admAcess = false;

        // Operador de "Não..." (!)
        if (!isLogged)
        {
            Console.WriteLine("Usuário está logado");
        }
        else
        {
            Console.WriteLine("Usuário não está logado.");
        }

        // Operador Ou (||)
        if (isLogged || admAcess)
        {
            Console.WriteLine("Acesso concedido ao sistema.");
        }
        else
        {
            Console.WriteLine("Acesso negado ao sistema.");
        }

        //Operador E (&&)
        if (isLogged && admAcess)
        {
            Console.WriteLine("Usuário com acesso de Administrador.");
        }
        else 
        {
            Console.WriteLine("Usuário com acessos restrito.");
        }

        
    }
}