namespace entrada_do_usuario;

class Program
{
    /*
    leitura de um unico caractere:
    string nome = console.read();

    leitura de uma linha completa:
    string nome = Console.ReadLine();

    //formatação de saida:
    concatenação:
    Console.WriteLine("Nome: "+ nome + ", Idade: " + idade);

    Interpolação:
    Console.WriteLine($"Nome: {nome}, Idade: {idade}");

    Indices:
    Console.WriteLine("Nome: {0}, Idade: {1}", nome, idade);
    
    */
    static void Main(string[] args)
    {
       Console.WriteLine("digite seu nome: ");
       string nome = Console.ReadLine(); //retorna para uma variavel
       Console.WriteLine($"Nome: {nome}");
    }
}
