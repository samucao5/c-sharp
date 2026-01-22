
namespace operadores_relacionais;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite um numero:\n->");
        int num1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("digite um segundo nuemro:\n->");
        int num2 = int.Parse(System.Console.ReadLine());

        //simbolo de igualdade: num1 e igual a num2, se sim true, se não false
        System.Console.WriteLine($"{num1} == {num2}: {num1 == num2}");
        //simbolo de Diferente: num1 e diferente de num2, se sim true, se não false
        System.Console.WriteLine($"{num1} != {num2}: {num1 != num2}");
        //simbolo de maior: num1 e maior que num2, se sim true, se não false
        System.Console.WriteLine($"{num1} > {num2}: {num1 > num2}");
        //simbolo de menor: num1 e menor que num2, se sim true, se não false
        System.Console.WriteLine($"{num1} < {num2}: {num1 < num2}");
        //simbolo de maior ou igual: num1 e maior ou igual a num2, se sim true, se não false
        System.Console.WriteLine($"{num1} >= {num2}: {num1 >= num2}");
        //simbolo de menor ou igual: num1 e menor ou igual a num2, se sim true, se não false
        System.Console.WriteLine($"{num1} <= {num2}: {num1 <= num2}");


    }
}
