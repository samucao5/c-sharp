namespace ex_7;

class Program
{
        
    static void Main(string[] args)
    {
        System.Console.Write("digite o seu primeiro nome: \n->");
        System.String nome = System.Console.ReadLine().Trim();
        int contagem_nome = nome.Length;
        System.Console.Write("digite o seu sobrenome completo: \n->");
        System.String sobrenome = System.Console.ReadLine().Trim();
        int contagem_sobrenome = sobrenome.Length;
        int soma = contagem_nome + contagem_sobrenome;
        
        System.Console.WriteLine($"seu nome e: {nome} {sobrenome}\n e o numero de caracteres do seu nome e: {soma}" );
    }
}

