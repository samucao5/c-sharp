namespace abstract_factory;

//Interfaces

interface IAbstractFactory
{
    IProdutoA CriarProdutoA();
    IProdutoB CriarProdutoB();
}

interface IProdutoA
{
    void Algo();
}

interface IProdutoB
{
    void Algo();
}

//classes que implementam a interfaces 

class ProdutoA1: IProdutoA
{
    public void Algo()
    {
        System.Console.WriteLine("A1");
    }
}

class ProdutoA2: IProdutoA
{
    public void Algo()
    {
        System.Console.WriteLine("A2");
    }
}

class ProdutoB1: IProdutoB
{
    public void Algo()
    {
        System.Console.WriteLine("B1");
    }
}

class ProdutoB2: IProdutoB
{
    public void Algo()
    {
        System.Console.WriteLine("B2");
    }
}

// Classe Fábrica

class Fabrica1 : IAbstractFactory
{
    public IProdutoA CriarProdutoA()
    {
        return new ProdutoA1();
    }

    public IProdutoB CriarProdutoB()
    {
        return new ProdutoB1();
    }
}

class Fabrica2 : IAbstractFactory
{
    public IProdutoA CriarProdutoA()
    {
        return new ProdutoA2();
        
    }

    public IProdutoB CriarProdutoB()
    {
        return new ProdutoB2();
        
    }
}


class Program
{
    static void Main(string[] args)
    {
        IAbstractFactory fabrica1 = new Fabrica1();
        IProdutoA produtoA1 = fabrica1.CriarProdutoA();
        IProdutoB produtoB1 = fabrica1.CriarProdutoB();

        produtoA1.Algo();
        produtoB1.Algo();

        IAbstractFactory fabrica2 = new Fabrica2();
        IProdutoA produtoA2 = fabrica2.CriarProdutoA();
        IProdutoB produtoB2 = fabrica2.CriarProdutoB();

        produtoA2.Algo();
        produtoB2.Algo();
    }
}
