namespace POO_001;

public class Program() 
{
    public static void Main()
    {
        //1. Criando obejeto (intancia) do tipo Cake
        Cake cakeStrawberry = new Cake();
        Cake cakeChocolate = new Cake();

        //2. Informaçoes da instancia
        cakeStrawberry.NameCake = "Bolo de Morango.";
        cakeStrawberry.Description = "Bolo de morango recheado com calda de morango e chantili.";
        cakeStrawberry.ValueCake = 50;

        //3. Mostrar para o usuário
        Console.WriteLine(cakeStrawberry.NameCake);
        Console.WriteLine(cakeStrawberry.Description);
        Console.WriteLine(cakeStrawberry.ValueCake);
        //4. Bolo de chocolate
        cakeChocolate.NameCake = "Bolo de Chocolate.";
        cakeChocolate.Description = "Bolo de chocolate 70% meio amargo.";
        cakeChocolate.ValueCake = 70;

        Console.WriteLine(cakeChocolate.NameCake);
        Console.WriteLine(cakeChocolate.Description);
        Console.WriteLine(cakeChocolate.ValueCake);

        Console.WriteLine("==================================");
        
        List<Cake> cakelist = new List<Cake>();

        cakelist.Add(cakeStrawberry);
        cakelist.Add(cakeChocolate);   

        foreach (Cake cake in cakelist)
        {
            Console.WriteLine(cake.NameCake);
            Console.WriteLine(cake.Description);
            Console.WriteLine(cake.ValueCake);
            Console.WriteLine("--------------------------");
        }

    }
}