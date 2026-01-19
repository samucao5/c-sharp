using System.Net.Http.Headers;

namespace ex_2;

class Program
{
    static void Main(string[] args)
    {
        decimal nota1, nota2, nota3;
        System.Console.Write("digite a nota1:\n ->");
        nota1 = decimal.Parse(System.Console.ReadLine());
        System.Console.Write("digite a nota2:\n ->");
        nota2 = decimal.Parse(System.Console.ReadLine());
        System.Console.Write("digite a nota3:\n ->");
        nota3 = decimal.Parse(System.Console.ReadLine());
        decimal media = ((nota1 + nota2 + nota3)/3);
        System.Console.WriteLine($"\n ({nota1} + {nota2} + {nota3})/3 = {System.Math.Round(media,1)}");

    }
}
