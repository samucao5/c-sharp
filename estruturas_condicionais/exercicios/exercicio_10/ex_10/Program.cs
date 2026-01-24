namespace ex_10;

class Program
{
    static void Main(string[] args)
    {
                System.Console.Write("Digite um numero:\n-");
        int numero1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Digite um segundo numero:\n-");
        int numero2 = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("+ para soma");
        System.Console.WriteLine("- para subtrair");
        System.Console.WriteLine("* para multiplicar");
        System.Console.WriteLine("/ para dividir");
        System.Console.Write("digite qual operação voce deseja fazer:\n-");
        char opcao = char.Parse(System.Console.ReadLine());



        if (opcao == '+')
        {
            int resultado = numero1 + numero2;
            System.Console.WriteLine($"{numero1} + {numero2} = {resultado}");
        }
        else if (opcao == '-')
        {
            int resultado = numero1 - numero2;
            System.Console.WriteLine($"{numero1} - {numero2} = {resultado}");
        }
        else if (opcao == '*')
        {
            int resultado = numero1 * numero2;
            System.Console.WriteLine($"{numero1} * {numero2} = {resultado}");
        }
        else if (opcao == '/')
        {
            int resultado = numero1 / numero2;
            System.Console.WriteLine($"{numero1} / {numero2} = {resultado}");
        }
        else
        {
            System.Console.WriteLine($"o {opcao} não foi encontrado");
        }
    }
}
