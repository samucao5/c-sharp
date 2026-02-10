namespace Virtual;

class Program
{
    /*
    Métodos Virtuais são métodos que podem ser rescritos em classes derivadas através do override
    */
    static void Main(string[] args)
    {
        Classe_1 obj = new Classe_1();
        Classe_2 obj_2 = new Classe_2();

        obj.metodo();
        obj_2.metodo();
    }
}

class Classe_1
{
    public virtual void metodo()
    {
        System.Console.WriteLine("olá,Mundo!");
    }
}

class Classe_2: Classe_1
{
    public override void metodo()
    {
        System.Console.WriteLine("outra coisa");
    }
}
