namespace tempos;
using System.Threading;
class Program
{
    /*
    É possível especificar um tempo em milissegundos entra cada instrução.

    Para isso existe o método Thread.Sleep();
    
    tem que colocar o:
    using System.Threading;
    */
    static void Main(string[] args)
    {
        System.Console.WriteLine("ola mundo");
        Thread.Sleep(1000);//Milisegundos
        System.Console.WriteLine("meu nome e:");
        System.Console.Clear();
        System.String senha = "senha123";
        while (true)
        {
            System.Console.Write("digite sua senha:\n->");
            System.String user = System.Console.ReadLine().Trim().ToLower();

            if(user == senha)
            {
                System.Console.WriteLine("senha correta saindo do loop");
                Thread.Sleep(3000);
                System.Console.Clear();
                break;
            }
            else
            {
                System.Console.WriteLine("tente novamente");
                Thread.Sleep(3000);
                System.Console.Clear();
            }
        }
    }
}
