
namespace Goto;

class Program
{
    /*
    instrução goto:
    Instrução que permite redirecionar o fluxo do codigo para uma label (etiqueta).
    
    Importante:
    O seu uso é extremamente desencorajado.(salto incondiconal)

    ex:
    label:

    goto label;
    */
    static void Main(string[] args)
    {
        menu:
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
                comando:
                System.Console.Write("deseja voltar para o menu:\n->");
                System.String opcao = ((System.Console.ReadLine()).Trim()).ToLower();
                if((opcao == "nao") || (opcao == "não"))
                {
                    System.Console.WriteLine("ok....");
                    System.Console.Clear();
                }
                else if(opcao == "sim"){
                    System.Console.Clear();
                    System.Console.WriteLine("retornando ao menu....");
                    goto menu;
                }
                else
                {
                    System.Console.Clear();
                    System.Console.WriteLine("comando não identificado, digite novamente");
                    goto comando;
                }
                break;
        }
    }
}
