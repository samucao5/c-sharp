namespace Strategy;

interface Strategy
{
    void Execute();
}

class ImpA : Strategy
{
    public void Execute()
    {
        System.Console.WriteLine("Execução A");
    }
}

class ImpB : Strategy
{
    public void Execute()
    {
        System.Console.WriteLine("Execução B");
    }
}

class Contexto
{
    private Strategy _strategy;
    public Contexto(Strategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(Strategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Contexto context = new Contexto(new ImpA());
        context.ExecuteStrategy();
        context.SetStrategy(new ImpB());
        context.ExecuteStrategy();

    }
}
