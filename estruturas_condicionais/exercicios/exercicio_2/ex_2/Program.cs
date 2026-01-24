namespace ex_2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite um ano:\n->");
        int ano = int.Parse(System.Console.ReadLine().Trim());
        int ano_bissexto = ano % 4;
        
        if(ano_bissexto == 0)
        {
            System.Console.WriteLine($"{ano} e um ano bissexto");
        }
        else
        {
            System.Console.WriteLine($"{ano} não e um ano bissexto");
        }
    }
}
