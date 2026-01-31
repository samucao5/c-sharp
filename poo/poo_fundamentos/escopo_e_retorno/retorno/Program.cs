namespace retorno;

class Program
{
    /*
    cada valor num codigo possui um escopo definido

    O escopo de um valor define se por quem e onde valor pode ser acessado.

    */
    static void Main(string[] args)
    {
        System.Console.WriteLine("digite seu nome:\n-> ");
        System.String nome = digite_seu_nome();
        System.Console.WriteLine($"seu nome e: {nome}");
    }

    static System.String digite_seu_nome()
    {
        System.String nome = System.Console.ReadLine().Trim().ToLower(); 
        return nome;
    }
}
