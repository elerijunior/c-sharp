using Classes.teste; // chamando classe de outra pasta com using

namespace Classes;

public class Program 
{
    public static void Main() 
    {
        Carro meuCarro = new Carro(); // Criando objeto carro, do tipo carro(classe)

        meuCarro.Ligar(); //Chamando carro.
        meuCarro.Desligar();

        Biscoito meuBiscoito = new Biscoito(); // Criando objeto biscoito, do tipo biscoito (classe)

        meuBiscoito.Temperatura(); // chamando biscoito.
    }
}
