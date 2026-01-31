namespace parametros;

class Program
{
    /*
    todos os metodos possuem parênteses no final, ex: WriteLine()

    Isso serve para passar os argumentos / parâmetros do método.

    Argumentos são valores que o método pede para trabalhar internamente no código que armazena.

    */
    static void Main(string[] args)
    {
        System.Console.WriteLine("digite seu nome: ");
        System.String nome = System.Console.ReadLine().Trim().ToLower();
        retorna_nome(nome);
        soma(2,3);
    }

    static void retorna_nome(System.String nome)
    {
        System.Console.WriteLine($"bem vindo {nome}");
    }

    static void soma(int n1,int n2)
    {
        int res = n1 + n2;
        System.Console.WriteLine($"{n1} + {n2} = {res}");
    }

}
