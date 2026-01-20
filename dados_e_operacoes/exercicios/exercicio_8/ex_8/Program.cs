namespace ex_8;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite um valor decimal: \n->");
        double num = double.Parse(System.Console.ReadLine());

        System.Console.WriteLine($"raiz quadrada: {System.Math.Sqrt(num)}");
        System.Console.WriteLine($"valor arredondado: {System.Math.Round(num)}");
        System.Console.WriteLine($"valor elevado: {System.Math.Pow(num,3)}");
    }
}
