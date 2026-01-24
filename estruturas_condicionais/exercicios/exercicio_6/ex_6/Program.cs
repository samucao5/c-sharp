
namespace ex_6;

class Program
{
    static void Main(string[] args)
    {
        System.String bebida_1,bebida_2,bebida_3,bebida_4,bebida_5;
        bebida_1 = "suco de laranja";
        bebida_2 = "cafe";
        bebida_3 = "energetico de manga";
        bebida_4 = "cha mate";
        bebida_5 = "achocolatado";

        System.Console.Write($"opções de bebida\n-{bebida_1}\n-{bebida_2}\n-{bebida_3}\n-{bebida_4}\n-{bebida_5}\n->");
        System.String opcao = (System.Console.ReadLine().Trim()).ToLower();

        double preco = 0;
        System.String detalhes = "";;

        switch (opcao)
        {
            case "suco de laranja":
            System.Console.Clear();
            preco = 2.50;
            detalhes = "um suco de laranja natural";
            System.Console.WriteLine($"nome: {bebida_1}\npreço: R${System.Math.Round((preco),2)}\ndetalhes: {detalhes}");
            break;

            case "cafe":
            System.Console.Clear();
            preco = 3.50;
            detalhes = "um bom café";
            System.Console.WriteLine($"nome: {bebida_2}\npreço: R${System.Math.Round((preco),2)}\ndetalhes: {detalhes}");
            break;

            case "energetico de manga":
            System.Console.Clear();
            preco = 10;
            detalhes = "energetico de manga de uma marca famosa";
            System.Console.WriteLine($"nome: {bebida_3}\npreço: R${System.Math.Round((preco),2)}\ndetalhes: {detalhes}");
            break;

            case "cha mate":
            System.Console.Clear();
            preco = 4.50;
            detalhes = "cha mate do leão";
            System.Console.WriteLine($"nome: {bebida_4}\npreço: R${System.Math.Round((preco),2)}\ndetalhes: {detalhes}");
            break;

            case "achocolatado":
            System.Console.Clear();
            preco = 10.20;
            detalhes = "achocolatado quente";
            System.Console.WriteLine($"nome: {bebida_5}\npreço: R${System.Math.Round((preco),2)}\ndetalhes: {detalhes}");
            break;

            default:
            System.Console.Clear();
            System.Console.WriteLine($"esta bebida {opcao} não foi encontrada");
            break;
        }
    }
}
