namespace ex_4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite um valor para o 1°lado:\n->");
        double a = double.Parse(System.Console.ReadLine().Trim());
        System.Console.Write("digite um valor para o 2°lado:\n->");
        double b = double.Parse(System.Console.ReadLine().Trim());
        System.Console.Write("digite um valor para o 3°lado:\n->");
        double c = double.Parse(System.Console.ReadLine().Trim());
        double soma_lado_1 = a + b;
        double soma_lado_2 = b + c;
        double soma_lado_3 = a + c;



        if(((soma_lado_1 > c) && (soma_lado_2 > a) && (soma_lado_3 > b)))
        {
            System.String frase = "e um triangulo";
            System.Console.WriteLine(frase);
        }
        else
        {
            System.String frase = "não e um triangulo";
            System.Console.WriteLine(frase);
        }
        
    }
}
