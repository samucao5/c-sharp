namespace recursividade;

class Program
{
    /*
    Recursividade ou métodos recursivos baseia-se em um método a ser chamado dentro dele gerando um loop

    */
    static void Main(string[] args)
    {
        Metodo(5);
    }
    static void Metodo(int n1)
    {
        if(n1 > 0){
        System.Console.WriteLine("Repetiu "+n1);
        n1--;
        Metodo(n1);
        }
    }
}
