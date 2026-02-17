namespace arquivos_introducao;
using System.IO;
class Program
{
    /*
    Em c# é possivel trabalhar com arquivos para diversos fins, desde manipular o interior, criar arquivos, mover e etc.

    Nesta aula veremos como selecionar um diretório, lista arqivos e pastas.
    
    para fazer esta aula devemos importar a classe System.IO
    using System.IO;
    */
    static void Main(string[] args)
    {
        //obs no windows as barras são ao contrario \ entao e recomendado usar o @"";
        //ex string pastas = @"C"\Users\joaozinho\Desktop\C#\";
        string pastas = "/home/samuel/codigos/C#";
        string[] dirs = Directory.GetDirectories(pastas);
        //Directory.GetDirectories(path, searchPattern, enumerationOptions);
        string[] dirs_2 = Directory.GetDirectories(pastas, "*", SearchOption.AllDirectories);
        

        foreach(string dir in dirs)
        {
            System.Console.WriteLine(dir);
        }
        System.Console.Write("limpar a tela:\n-> ");
        System.String ap = System.Console.ReadLine().Trim().ToLower();
        if(ap == "sim" || ap == "s")
        {
            System.Console.Clear();
        }
        foreach(string dir_2 in dirs_2)
        {
            System.Console.WriteLine(dir_2);
        }

        System.Console.Write("limpar a tela:\n-> ");
        ap = System.Console.ReadLine().Trim().ToLower();
        if(ap == "sim" || ap == "s")
        {
            System.Console.Clear();
        }
        
        //Directory.GetFiles(path, searchPattern, enumerationOptions);
        pastas = "/home/samuel/codigos/C#/dados_e_operacoes/Aula00/";
        var files = Directory.GetFiles(pastas, "*.*", SearchOption.TopDirectoryOnly);
        //caso eu queira ver o modulo dados_e_operacoes inteiro e so usar este codigo
        //pastas = "/home/samuel/codigos/C#/dados_e_operacoes/";
        //var files = Directory.GetFiles(pastas, "*.*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            System.Console.WriteLine(file);
        }

        System.Console.Write("limpar a tela:\n-> ");
        ap = System.Console.ReadLine().Trim().ToLower();
        if(ap == "sim" || ap == "s")
        {
            System.Console.Clear();
        }

        pastas = "/home/samuel/codigos/C#/dados_e_operacoes/";
        var files_2 = Directory.GetFiles(pastas, "*.*", SearchOption.AllDirectories);
        foreach (string file_2 in files_2)
        {
            System.Console.WriteLine(file_2);
        }
    }
}
