namespace ex_4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite o raio do circulo \n->");
        double raio = double.Parse(System.Console.ReadLine());
        double area = (System.Math.PI * (System.Math.Pow(raio,2)));
        System.Console.WriteLine($"{System.Math.Round((System.Math.PI),3)} * ({raio} ^ 2) = {System.Math.Round(area,2)}");

    }
}
