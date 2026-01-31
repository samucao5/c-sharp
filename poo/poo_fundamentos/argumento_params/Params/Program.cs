namespace Params;

class Program
{
    /*
    O tipo de argumento params permite-nos entrar com vários argumentos em formato de vetor.
    Ou seja os diferentes parâmetros passados ficarão todos guardados em um vetor
    */

    static void Main(string[] args)
    {
        exibindo_valores(10,20,30,40);
    }

    static void exibindo_valores(params int[]numeros)
    {
        foreach (int n1 in numeros)
        {
            System.Console.WriteLine(n1);
        }
    }
}
