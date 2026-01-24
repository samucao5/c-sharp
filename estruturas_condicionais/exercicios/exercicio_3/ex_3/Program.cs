

namespace ex_3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite a nota do aluno entre 0 a 20:\n->");
        int nota = int.Parse(System.Console.ReadLine().Trim());
        if (nota < 10)
        {
            System.Console.WriteLine($"sua nota foi: {nota}\nvoce foi reprovado");
        }
        else if((nota >= 10) && (nota < 13))
        {
            System.Console.WriteLine($"sua nota foi: {nota}\nfoi o suficiente para passar");
        }
        else if((nota >= 13) && (nota <= 16))
        {
            System.Console.WriteLine($"sua nota foi: {nota}\nvoce tirou uma nota boa");
        }
        else if((nota > 16) && (nota < 20))
        {
            System.Console.WriteLine($"sua nota foi: {nota}\nvoce tirou uma nota muito boa, parabens");
        } 
        else if((nota == 20))
        {
            System.Console.WriteLine($"sua nota foi: {nota}\nvoce gabaritou, parabens");
        }
        else
        {
            System.Console.WriteLine($"o valor que voce colocou {nota} esta fora dos parametros");
        }

    }
}
