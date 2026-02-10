namespace Interfaces;

class Program
{
    /*
    Interfaces funcionam como classes que apenas possuem o prototipo de métodos.
    Funcionam como uma referencia para outras classes, definindo as regras e conteúdos das classes derivadas.
    */
    static void Main(string[] args)
    {
        Classe_2 obj = new Classe_2();
        obj.metodo1();
        obj.metodo2();
    }
}
public interface Nome
{
    //metodos -. sem implementação
    //nada de propriedades
    void metodo1();
    void metodo2();
    }


class Classe_2:Nome
{
    public void metodo1()
    {
        System.Console.WriteLine("bom dia");
    }

    public void metodo2()
    {
        System.Console.WriteLine("boa tarde");
    }
}