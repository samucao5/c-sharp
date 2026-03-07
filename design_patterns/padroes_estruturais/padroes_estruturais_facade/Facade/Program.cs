namespace Facade;

class Luzes
{
    public void Ligar()
    {
        System.Console.WriteLine("Ligando luzes");
    }    

    public void Desligar()
    {
        System.Console.WriteLine("Desligando Luzes");
    }
}


class ArCondicionado
{
    public void Ligar()
    {
        System.Console.WriteLine("Ligando Ar Condicionado");
    }    

    public void Desligar()
    {
        System.Console.WriteLine("Desligando Ar condicionado");
    }
}

class SistemaDeSom
{
    public void Ligar()
    {
        System.Console.WriteLine("Ligando Sistema de Som");
    }    

    public void Desligar()
    {
        System.Console.WriteLine("Desligando Sistema de Som");
    }
}

class Facade
{

    private readonly Luzes _luzes;
    private readonly ArCondicionado _ArCondicionado;
    private readonly SistemaDeSom _SistemaDeSom;



    public Facade()
    {
    _luzes = new Luzes();
    _ArCondicionado = new ArCondicionado();
    _SistemaDeSom = new SistemaDeSom();
    }
    public void LigarTudo()
    {
        _luzes.Ligar();
        _ArCondicionado.Ligar();
        _SistemaDeSom.Ligar();
    }

    public void DesligarTudo()
    {
        _luzes.Desligar();
        _ArCondicionado.Desligar();
        _SistemaDeSom.Desligar();
    }

}

class Program
{
    static void Main(string[] args)
    {
        Facade Automacao = new Facade();
        Automacao.LigarTudo();
        Automacao.DesligarTudo();
        
        Luzes luzes = new Luzes();
        luzes.Ligar();

        SistemaDeSom som = new SistemaDeSom();
        som.Ligar();

        ArCondicionado ar = new ArCondicionado();
        ar.Ligar();
    }
}
