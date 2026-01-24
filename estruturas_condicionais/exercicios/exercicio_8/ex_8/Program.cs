namespace ex_8;

class Program
{
    static void Main(string[] args)
    {
        
        System.Console.Write("Digite um numero:\n->");
        int numero = int.Parse(System.Console.ReadLine().Trim());
        int resultado = numero % 2;
        System.String frase = "";
        frase = (resultado == 0) ? "ele e par" : "ele e impar";
        System.Console.WriteLine($"o numero: {numero} {frase}");
    }
}
