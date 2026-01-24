namespace ex_5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite seu saldo:\n->");
        double saldo = double.Parse(System.Console.ReadLine().Trim());
        System.Console.Write("digite o valor do saque:\n->");
        double saque = double.Parse(System.Console.ReadLine());

        if (saldo >= saque)
        {
            System.Console.WriteLine($"o saque de {saque} foi feito com sucesso");
        }
        else
        {
            System.Console.WriteLine($"saldo insuficiente");
        }

    }
}
