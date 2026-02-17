namespace arquivos_criar_clonar_mover_deletar;
using System.IO;
class Program
{
    /*
    É possivel mover, copiar, deletar e criar arquivos através da classe File.

    Tambem é possivel criar pastas atraves do CreateDirectory();
    
    */
    static void Main(string[] args)
    {
        System.String pasta = "/home/samuel/codigos/teste";
        System.String file = "/home/samuel/codigos/teste/Texto.txt";
        //verifico se a pasta existe caso não
        if(!Directory.Exists(pasta)){
        //a pasta e criada, e retorno um mensagem 
        Directory.CreateDirectory(pasta); 
        System.Console.WriteLine("pasta criada");
        }

        //verifico se o arquivo de texto foi criado se não 
        if(!File.Exists(file)){
        //crio o arquivo de texto e retorno uma mensagem
        File.Create(file).Close();
        System.Console.WriteLine("arquivo criado");
        }
        System.Console.WriteLine("digite o nome do arquivo:\n-> ");
        System.String nome_arquivo = System.Console.ReadLine().Trim();
        System.String file_1 = $"/home/samuel/codigos/teste/{nome_arquivo}.txt";
        //copia a pasta porem muda o nome
        File.Copy(file, file_1, true);
        System.String file_2 = "/home/samuel/codigos/Movido.txt";
        //File.Move(string sourceFileName, string destFileName, bool overwrite);
        // bool overwrite = se vai substituir caso tenha um arquivo com nome igual
        File.Move(file, file_2, true);
        //deleta o arquivo
        File.Delete(file_2);
        
        //caso queira deletar diretorios e so usar o comando
        //Directory.Delete(pasta_a_ser_deletada);
        //Directory.Delete não deleta pastas ao qual não esta vazia
    }
}
