namespace ex_9;

class Program
{
    static void Main(string[] args)
    {
        System.String usuario_n = "samuel";
        System.String senha_n = "senha523";


        System.Console.Write("digite seu nome de usuario:\n->");
        System.String usuario = (System.Console.ReadLine().Trim()).ToLower();
        System.Console.Write("digite sua senha:\n->");
        System.String senha = System.Console.ReadLine().Trim();

        if((usuario == usuario_n) && (senha == senha_n))
        {
            System.Console.WriteLine("usuario entrou");
        }
        else
        {
            System.Console.WriteLine("usuario ou senha incorreto");
        }


    }
}
