
namespace do_while;

class Program
{
    /*
    O Loop Do_While funciona como um loop while invertido, ou seja primeiro é executado o codigo e depois que é testado o teste lógico.
    
    */

    
    static void Main(string[] args)
    {
        System.String senha = "senha123";
        System.String senha_d = "";
        do
        {
            System.Console.Write("1- para criar senha\n2 - testar a senha\n->");
            int opcao = int.Parse(System.Console.ReadLine().Trim());

            if(opcao == 1){
                System.Console.Clear();
                System.Console.Write("digite a nova senha:\n-> ");
                senha = ((System.Console.ReadLine().Trim()).ToLower());
            }
            else if (opcao == 2){
                System.Console.Clear();
                System.Console.Write("digite a senha:\n->");
                senha_d = ((System.Console.ReadLine().Trim()).ToLower());
            }
            else
            {
                System.Console.Clear();
                System.Console.WriteLine("opcao não encontrada");
            }
            System.Console.Clear();
        }while(senha_d != senha);

        System.Console.WriteLine("a senha digitada esta correta");
    }
}
