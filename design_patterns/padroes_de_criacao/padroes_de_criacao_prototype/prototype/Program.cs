using System.Collections.Generic;

namespace prototype;

abstract class Prototype
{
    public abstract Prototype Clone();
}

class ConcretePrototype : Prototype
{
    private System.String _atributo;
    public ConcretePrototype(System.String att)
    {
        this._atributo = att;
    }

    public override Prototype Clone()
    {
        return new ConcretePrototype(this._atributo);
    }

    public void SetAtributte(System.String att)
    {
        this._atributo = att;
    }

    public void ShowAtributte()
    {
        System.Console.WriteLine("Atributo: "+_atributo);
    }
}


class Program
{
    static void Main(string[] args)
    {
        ConcretePrototype prototype = new ConcretePrototype("pular");
        ConcretePrototype clone = (ConcretePrototype)prototype.Clone();
        
        clone.SetAtributte("modificado");
        prototype.ShowAtributte();
        clone.ShowAtributte();
    }
}
