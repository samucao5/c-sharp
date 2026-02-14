namespace Delgates;

class Program
{
    /*
    um Delegate é um objeto que faz referencia a métodos guardando o endereço deles.
    A sua principal função é no uso de eventos.
    */
    static void Main(string[] args)
    {
        
        //criando o delegate dentro da main e associando com a função da classe Operation
        //associando com o Operation.soma
        Op del1 = new Op(Operation.soma);
        //associando com o Operation.subs
        Op del2 = new Op(Operation.subs);
        int resultado = del1(10,20);
        int resultado_2 = del2(20,15);
        System.Console.WriteLine(resultado);
        System.Console.WriteLine(resultado_2);
    }
}

//criação do delegate
delegate int Op(int n1, int n2);

class Operation
{
    public static int soma ( int n1, int n2)
    {
        return n1 + n2;
    }

    public static int subs (int n1, int n2)
    {
        return n1 - n2;
    }
}