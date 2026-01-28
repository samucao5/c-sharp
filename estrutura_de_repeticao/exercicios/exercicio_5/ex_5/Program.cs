namespace ex_5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite o numero da tabuada:\n->");
        int valor = System.Math.Abs(int.Parse(System.Console.ReadLine().Trim()));
        for(int i = 1;i <= 10;i++)
        {
            System.Console.WriteLine($"{valor} * {i} = {valor * i}");
        }
    }
}
