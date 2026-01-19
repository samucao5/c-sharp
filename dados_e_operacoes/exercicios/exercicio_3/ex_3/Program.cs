namespace ex_3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite uma palavra:\n->");
        System.String palavra = (System.Console.ReadLine());
        System.Console.WriteLine($"A palavra escrita e: {palavra.Trim()} \nO numero de caracteres: {(palavra.Trim()).Length}");

    }
}
