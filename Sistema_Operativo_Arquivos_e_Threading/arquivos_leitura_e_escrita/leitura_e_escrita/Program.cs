namespace leitura_e_escrita;
using System.IO;
class Program
{
    /*
    Arquivos podem sofrer processos de leitura e escrita.

    Escrita -> alterar o conteúdo
    Leitura -> verificar o conteúdo
    */
    static void Main(string[] args)
    {
        System.String file_1 = "/home/samuel/codigos/teste/4.txt";
        System.String file_2 = "/home/samuel/codigos/teste/epa.txt";
        //exibe o que tem dentro do texto
        System.Console.WriteLine(File.ReadAllText(file_1));
        //colocando cada linha do texto em um vetor
        System.String[] linhas = File.ReadAllLines(file_2);
        //
        System.Console.WriteLine(linhas[1]);

        foreach(System.String linha in linhas)
        {
            System.Console.WriteLine(linha);   
        };
        //para mudar a escrita do texto e preciso usar o StreamWriter
        StreamWriter escritor = new StreamWriter(file_1);
        //escritor.WriteLine(variavel_b);
        escritor.WriteLine("meu numero favorito e: 5");
        //e fecha apos o uso
        escritor.Close();

        //exibi o texto modificado 
        System.Console.WriteLine(File.ReadAllText(file_1));
    }   
}
