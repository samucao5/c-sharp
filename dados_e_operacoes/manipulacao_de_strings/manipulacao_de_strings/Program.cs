namespace manipulacao_de_strings;

class Program
{
    /*
    Dados de texto:
    char -> armazena caracteres únicos
    string -> armazena uma sequência de caracteres

    char letra = 'a';

    string texto = "ola, mundo";

    */

    static void Main(string[] args)
    {
        //manipulação de Strings
        string nome = " meu nome e samuel ";
        //Maiuscula e Minusculas
        String maiuscula = nome.ToUpper();
        System.Console.WriteLine(maiuscula);
        //ou
        System.Console.WriteLine(nome.ToUpper());

        string minuscula = nome.ToLower();
        System.Console.WriteLine(minuscula);
        //ou
        System.Console.WriteLine(nome.ToLower());

        //remover espaços nas laterais
        System.Console.WriteLine(nome);
        System.Console.WriteLine(nome.Trim());

        //obter e substituir partes
        //obter
        System.Console.WriteLine(nome.Substring(1,14));
        //substituir
        System.String nome2 = "Isa"; 
        System.Console.Write(nome.Replace("samuel",nome2));

        //Verificações (bool)
        //verifica se tem a palavra descrita no texto
        System.Console.WriteLine(nome.Contains("samuel"));
        //verifica se começa com alguma letra
        System.Console.WriteLine((nome.Trim()).StartsWith("meu"));
        //verifica se termina com alguma letra
        System.Console.WriteLine((nome.Trim()).EndsWith('l'));

    }
}
