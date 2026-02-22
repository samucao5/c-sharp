namespace factory_method;

interface ModeloProduto
{
    void operation();
}

class Produto : ModeloProduto
{
    public void operation()
    {
        System.Console.WriteLine("Produto");
    }
}

interface IFabrica
{
    ModeloProduto FactoryMethod();
}

class Fabrica : IFabrica
{
    public ModeloProduto FactoryMethod()
    {
        return new Produto();   
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFabrica fab = new Fabrica();
        ModeloProduto prod = fab.FactoryMethod();
        prod.operation();

    }
}
