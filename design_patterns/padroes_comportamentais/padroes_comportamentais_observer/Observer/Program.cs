namespace Observer;
using System.Collections.Generic;


interface IObserver
{
    void Update(object data);


}

class ObserverA : IObserver
{
    public void Update(object data)
    {
        System.Console.WriteLine("ObservadorA a reagir á mudança: "+data);

    }
}

class ObserverB : IObserver
{
    public void Update(object data)
    {
        System.Console.WriteLine("ObservadorB a reagir á mudança: "+data);

    }
}

class Sujeito
{
    private List<IObserver> obs = new List<IObserver>();
    public void Adicionar(IObserver observer)
    {
        obs.Add(observer);

    }

    public void Remover(IObserver observer)
    {
        obs.Remove(observer);
    }

    public void Notify(object data)
    {
        foreach (var observer in obs)
        {
            observer.Update(data);
        }
    }
}





class Program
{
    static void Main(string[] args)
    {
        Sujeito suj = new Sujeito();
        ObserverA obsA = new ObserverA();
        ObserverB obsB = new ObserverB();

        suj.Adicionar(obsA);
        suj.Adicionar(obsB);
        suj.Notify("Dados Atualizados");
    }
}
