namespace ArquivosFile;

using System.IO;

public class Program() 
{
    public static void Main() 
    {
        //1. Criando um arquivo -> Cria um arquivo do tipo .txt na pasta bin

        //string content = "Hello World";

        //File.WriteAllText("file.txt", content);
        //Console.WriteLine("Arquivo criado com sucesso!");

        //2. Criando um arquivo em local especifico

        //string path = @"D:\c-sharp\ArquivosFile\ArquivosFile\fileName.txt";
        //string content = "Hello World";

        //File.WriteAllText(path, content);
        //Console.WriteLine("Arquivo criado com sucesso!");

        //3. Criando um arquivo Word .Doc

        string path = @"D:\c-sharp\ArquivosFile\ArquivosFile";
        string fileName = "MyDocument.Doc";
        string filePath = path + fileName;
        string content = "Hello World";


        File.WriteAllText(filePath, content);
        Console.WriteLine("Arquivo Word criado com sucesso!");

        //4. Inserir um paragráfo em um arquivo





    }
}