namespace metodos_simples;

class Program
{
    /*
    Métodos são pequenos espaços num código que armazenam um bloco de codigo.
    O bloco de código que o método armazena pode ser chamado a qualquer momento e executado
    */

    static void Main(string[] args)
    {
        nome();
    }

    //void -> sem retorno
    static void nome()
    {
        System.Console.WriteLine("meu nome e samuel");
    }
}
