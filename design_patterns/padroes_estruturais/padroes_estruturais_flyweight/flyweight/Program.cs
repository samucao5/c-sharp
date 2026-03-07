namespace flyweight;
using System.Collections.Generic;

interface IFlyWeight
{
    void Operation(int ex_state);//externo

}

class Implementacao:IFlyWeight
{
    private System.String in_state;//interno
    public Implementacao(System.String in_state)
    {
        this.in_state = in_state;
    }

    public void Operation(int ex_state)
    {
        System.Console.WriteLine($"Interno: {in_state} Externo: {ex_state}");
    }
}

class FlyWeightFactory
{
    private Dictionary<System.String,IFlyWeight> flyweights = new Dictionary<System.String,IFlyWeight>();

    public IFlyWeight GetFlyWeight(System.String key)
    {
        if(!flyweights.ContainsKey(key))
        {
            flyweights[key] = new Implementacao(key);
        }
        return flyweights[key];
    }

    public void ListFlyWeights()
    {
        System.Console.WriteLine(flyweights.Count);
        foreach (var key in flyweights.Keys)
        {
            System.Console.WriteLine(key);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var factory = new FlyWeightFactory();

        var flyweight1 = factory.GetFlyWeight("A");
        flyweight1.Operation(1);
        var flyweight2 = factory.GetFlyWeight("B");
        flyweight2.Operation(2);
        var flyweight3 = factory.GetFlyWeight("C");
        flyweight3.Operation(3);
        var flyweight4 = factory.GetFlyWeight("A");
        flyweight4.Operation(4);

        factory.ListFlyWeights();
    }
}
