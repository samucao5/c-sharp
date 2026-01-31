namespace referencia;

class Program
{
    /*Numa passagem por valor o valor fica guardado em uma posição da memória diferente
    
    Ou seja ao passar um valor por um método em formato de parametro, as modificações desse valor não retornadas ficarão numa outra posição da memoria.
    */
    static void Main(string[] args)
    {
        System.Console.Write("digite um numero:\n->");
        int num1 = int.Parse(System.Console.ReadLine().Trim());
        //ref: o valor fica guardado na posição de memoria do argumento para isso e necessário o operador ref
        mais_um (ref num1);
        System.Console.WriteLine(num1);
    }

    static void mais_um(ref int num1)
    {
        num1 = num1 + 1;
    }
}
