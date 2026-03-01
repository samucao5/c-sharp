namespace Bridge;

interface I_Implementor
{
    System.String Operation();
}

class ImplementorA : I_Implementor
{
    public System.String Operation()
    {
        return "ImplementorA";
    }   
} 

class ImplementorB : I_Implementor
{
    public System.String Operation()
    {
        return "ImplementorB";
    }
}

class Abstraction
{
    protected I_Implementor _Implementor;
    public Abstraction(I_Implementor implementor)
    {
        _Implementor = implementor;
    }

    public virtual System.String Op()
    {
        return _Implementor.Operation();
    }
}

class Adicional: Abstraction
{
    //Chamada ao construtor base | Proposito: Inicializar a instancia
    public Adicional(I_Implementor implementor):base(implementor){}
    public override System.String Op()//conteudo adicional
    {
        return $"Adiciona: {base.Op()}";
    }
}


class Program
{
    static void Main(string[] args)
    {
        I_Implementor implementorA = new ImplementorA();
        Abstraction AbsA = new Adicional(implementorA);
        System.Console.WriteLine(AbsA.Op());

        I_Implementor implementorB = new ImplementorB();
        Abstraction AbsB = new Adicional(implementorB);
        System.Console.WriteLine(AbsB.Op());
    }
}
