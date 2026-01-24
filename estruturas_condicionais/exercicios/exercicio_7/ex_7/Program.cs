namespace ex_7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite o preco do produto:\n->");
        double preco = double.Parse(System.Console.ReadLine().Trim());
        double porcentagem = 0;

        if(preco >= 200)
        {
            porcentagem = 15;
        }
        else if(preco >= 100)
        {
            porcentagem = 10;
        }

        double desconto = (porcentagem / 100 ) * preco; 
        double preco_final = preco - desconto;

        System.Console.WriteLine($"Preço sem desconto: {preco}");
        System.Console.WriteLine($"Desconto aplicado: {porcentagem}%");
        System.Console.WriteLine($"Valor do desconto: {desconto}");
        System.Console.WriteLine($"Preço com desconto: {preco_final}");
    }
}
