namespace Abstract;

class Program
{
    /*
    Classes Abstratas são classes que servirão de referencia para outras classes.
    Não se pode instanciar objetos,e as propriedades abstratas não possuem implementação.
    Podem ser reescritas com override
    
    
    */
    static void Main(string[] args)
    {
        Classe_2 obj = new Classe_2();
        System.Console.WriteLine(obj.n1);
        obj.M1();
    }
}

abstract class Classe_1
{
    public int n1 = 10;
//a classe que herda, tem como obrigação dar a implementação a este metodo abstrato
    abstract public void M1(); 
}

class Classe_2 : Classe_1
{
    override public void M1()
    {
        System.Console.WriteLine("metodo preenchido");
    }
}