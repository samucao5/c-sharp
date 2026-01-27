namespace Foreach;

class Program
{
    /*
    o loop foreach ("for each" = "para cada") é um loop que serve especificamente para trabalhar com arrays.
    o loop repete o codigo para cada elemento do array.

    ex sintaxe:
    n = numero de elementos do array

    foreach(int n in array)
    {

    }
    
    */
    static void Main(string[] args)
    {
        //outra forma de fazer array
        //int array = {1,2,3};
        int[] idade = {18,23,25};

        foreach(int n in idade)
        {
            System.Console.WriteLine(n);
        }

    }
}
