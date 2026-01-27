namespace ex_1;

class Program
{
    static void Main(string[] args)
    {
        while(true){
        System.Console.Write("digite uma nota de 0 - 10:\n->");
        int nota = int.Parse(System.Console.ReadLine().Trim());
        if((nota >= 0) && (nota <= 10))
            {
                System.Console.WriteLine("nota enviada com sucesso");
                break;
            }
            else
            {
                System.Console.WriteLine("nota fora dos parametros, digite novamente");
            }

        }
    }
}
