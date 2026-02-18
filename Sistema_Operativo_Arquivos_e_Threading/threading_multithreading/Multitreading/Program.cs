namespace Multitreading;
using System.Threading;
class Program
{
    /*
    Multitreading é a capacidade de um processador executar vários threads ao mesmo tempo.
    
    Ou seja várias ações ao mesmo tempo.
    */
    static void Main(string[] args)
    {
        Thread t1 = new Thread(Metodo1);
        Thread t2 = new Thread(Metodo2);

        t1.Start();
        t2.Start();
    }

    public static void Metodo1()
    {
        for (int i = 0; i <= 10; i++)
        {
            System.Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }   

    public static void Metodo2()
    {
        for (int i = 0; i <= 10; i++)
        {
            System.Console.WriteLine("numero ");
            Thread.Sleep(1000);
        }
    }   
    
}

