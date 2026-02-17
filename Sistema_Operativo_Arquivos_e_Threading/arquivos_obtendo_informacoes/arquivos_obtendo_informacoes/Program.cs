namespace arquivos_obtendo_informacoes;
using System.IO;
class Program
{
    /*
    Em C# é possivel trabalhar com arquivos para diversos fins, desde manipular o interiro, criar arquivos, mover etc.

    Nesta aula veremos como obter o tamanho de um arquivo e verificar se ele existe.
    */
    static void Main(string[] args)
    {
        System.String pastas = "/home/samuel/codigos/C#/dados_e_operacoes/Aula00";
        //verifica se a pasta existe
        bool existe_pasta = Directory.Exists(pastas);
        System.Console.WriteLine(existe_pasta);
        
        var files = Directory.GetFiles(pastas, "*.*", SearchOption.AllDirectories);

        foreach (string file in files)
        {
            var info = new FileInfo(file);
            //mostra o nome e o tamanho do arquivo
            System.Console.WriteLine($"{info.Name} - {info.Length} bytes");
        }
    }
}
