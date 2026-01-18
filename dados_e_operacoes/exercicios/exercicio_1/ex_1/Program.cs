namespace ex_1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite uma temperatura:\n->");
        string temperatura = System.Console.ReadLine();
        System.Decimal celsius = decimal.Parse(temperatura);
        decimal fahrenheit = (celsius * 9 / 5) + 32;
        System.Console.WriteLine($"temperatura em celsius: {celsius}\ntemperatura em fahrenheit:{System.Math.Round(fahrenheit,2)}");
        
    }
}
