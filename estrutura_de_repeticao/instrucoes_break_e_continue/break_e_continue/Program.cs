

class Program
{
    /*
    um loop e formado por iterações, cada iteração é uma vez que o bloco de codigo é repetido.

    Através das instruções break, e continue é possivel saltar iteração ou parar o loop atual.
    */
    static void Main(string[] args)
    {
        System.Console.WriteLine("contando ate 20 ate 1, so os numeros impares");
        int i = 20;
        while(1 <= i)
        {
            if (i%2==0)
            {
                i--;
                continue;
            }
            System.Console.WriteLine(i);
            i--;
        }
        while(true)
        {
            System.Console.Write("digite o nome do administrador:\n->");
            System.String nome = (System.Console.ReadLine().Trim().ToLower());

            if(nome == "samuel")
            {
                System.Console.WriteLine("administrador encontrado");
                break;
            }
            System.Console.Clear();
        }
    }
}
