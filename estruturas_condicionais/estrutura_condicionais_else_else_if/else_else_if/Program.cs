namespace else_else_if;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("produtos:\nbanana\nmanga\ncaderno\nuva\ndigite a sua opção\n->");
        System.String opcao = ((System.Console.ReadLine()).Trim()).ToLower();
        
        if(opcao == "banana")
        {
            double preco = 5.99;
            System.Console.WriteLine("banana");
            System.Console.WriteLine($"R$ {preco}");
        }
        else if(opcao == "manga")
        {
            double preco = 4.93;
            System.Console.WriteLine("manga");
            System.Console.WriteLine($"R$ {preco}");
        }
        else if(opcao == "caderno")
        {
            double preco = 10.53;
            System.Console.WriteLine("caderno");
            System.Console.WriteLine($"R$ {preco}");
        }
        else if(opcao == "uva")
        {
            double preco = 8.99;
            System.Console.WriteLine("uva");
            System.Console.WriteLine($"R$ {preco}");
        }
        else
        {
            System.Console.WriteLine("produto não encontrado");
        }
    }
}
