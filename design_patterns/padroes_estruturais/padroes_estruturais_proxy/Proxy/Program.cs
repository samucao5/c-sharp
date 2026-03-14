namespace Proxy;

interface IObjetivo {
    void Request();
}

class ObjetivoReal : IObjetivo
{
    public ObjetivoReal()
    {
        //Operação Cara
        System.Console.WriteLine("operação: (Conexão ao Banco)");
    }

    public void Request()
    {
        System.Console.WriteLine("ObjetivoReal: Handle Request");
    }
}

class Proxy : IObjetivo
{
    private ObjetivoReal _objetivoReal;
    public void Request()
    {
        if(_objetivoReal == null)
        {
            _objetivoReal = new ObjetivoReal();
        }
        _objetivoReal.Request();
    }
}



class Program
{
    static void Main(string[] args)
    {
        IObjetivo proxy = new Proxy();
        proxy.Request();
    }
}
