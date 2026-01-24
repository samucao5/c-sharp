
namespace switch_case;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite o nome do administrador:\n->");
        System.String nome = ((System.Console.ReadLine()).Trim()).ToLower();

        switch(nome)
        {
            case "samuel":
                System.Console.WriteLine($"bem-vindo de volta {nome}");
                break;

            case "allan":
                System.Console.WriteLine($"bem-vindo de volta {nome}");
                break;
            
            case "isa":
                System.Console.WriteLine($"bem-vindo de volta {nome}");
                break;
            
            default:
                System.Console.WriteLine($"este nome {nome} não existe como administrador");
                break;
        }
    }
}
