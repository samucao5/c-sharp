namespace ex_9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite seu peso: \n->");
        double peso = double.Parse(System.Console.ReadLine());
        System.Console.Write("digite sua altura: \n->");
        double altura = double.Parse(System.Console.ReadLine());

        double IMC =  System.Math.Round((peso / (System.Math.Pow(altura, 2))),2);

        System.Console.WriteLine($"IMC: {IMC}");
    }
}
