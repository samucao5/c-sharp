namespace Decorator;

interface ICafe
{
    System.String GetDescription();
    double GetCusto();
}

class CafeSimples : ICafe
{
    public System.String GetDescription()
    {
        return "café simples";
    }

    public double GetCusto()
    {
        return 5.34;
    }

}

abstract class CafeDecorator : ICafe
{
    protected ICafe _cafe;

    public CafeDecorator(ICafe cafe)
    {
        _cafe = cafe;
    }

    public virtual System.String GetDescription()
    {
        return _cafe.GetDescription();   
    }

    public virtual double GetCusto()
    {
        return _cafe.GetCusto();
    }
}

class LeiteDecorator : CafeDecorator
{
    public LeiteDecorator(ICafe cafe):base(cafe){}

    public override System.String GetDescription()
    {
        return _cafe.GetDescription()+", leite";
    }

    public override double GetCusto()
    {
        return _cafe.GetCusto()+2;
    }
}

class AcucarDecorator : CafeDecorator
{
    public AcucarDecorator(ICafe cafe) : base(cafe){}

    public override System.String GetDescription()
    {
        return _cafe.GetDescription()+", com açucar";
    }
    public override double GetCusto()
    {
        return _cafe.GetCusto()+0.23;
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        ICafe meuCafe = new CafeSimples();
        System.Console.WriteLine($"pedido: {meuCafe.GetDescription()}, preço: R${meuCafe.GetCusto()}");

        meuCafe = new LeiteDecorator(meuCafe);
        System.Console.WriteLine($"pedido: {meuCafe.GetDescription()}, preço: R${meuCafe.GetCusto()}");

        meuCafe = new AcucarDecorator(meuCafe);
        System.Console.WriteLine($"pedido: {meuCafe.GetDescription()}, preço: R${meuCafe.GetCusto()}");

        ICafe meuCafe_2 = new CafeSimples();
        meuCafe_2 = new AcucarDecorator(meuCafe_2);
        System.Console.WriteLine($"pedido: {meuCafe_2.GetDescription()}, preço: R${meuCafe_2.GetCusto()}");

    }
}
