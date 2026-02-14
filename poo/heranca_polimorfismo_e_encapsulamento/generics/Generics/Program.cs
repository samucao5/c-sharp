namespace Generics;

class Program
{
    /*
    os tipos genericos de dados permitem-nos trabalhar com diversos tipos em algo que funcionaria apenas para um.
    como por exemplo um argumento que aceita qualquer tipo de dado.

    */

    static void Main(string[] args)
    {
        int n1 = 20;
        double n2 = 20.0;
        string n3 = "20";
        Metodo(n1);
        Metodo(n2);
        Metodo(n3);
    }

    public static void Metodo <Qualquer>(Qualquer res)
    {
        System.Console.WriteLine(res);
    }
}
