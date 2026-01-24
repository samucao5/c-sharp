namespace ex_1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite a temperatura atual:\n->");
        int temperatura = int.Parse(System.Console.ReadLine().Trim());

        if (temperatura < 10)
        {
            System.Console.WriteLine($"Temperatura atual: {temperatura}°C\n");
            System.Console.WriteLine("Dia frio");
        }
        else if ((temperatura > 10) && (temperatura <= 25))
        {
            System.Console.WriteLine($"Temperatura atual: {temperatura}°C\n");
            System.Console.WriteLine("Dia agradavel");
        }
        else
        {
            System.Console.Write($"temperatura atual: {temperatura}°C");
            System.Console.WriteLine("Dia quente");
        }
    }
}
