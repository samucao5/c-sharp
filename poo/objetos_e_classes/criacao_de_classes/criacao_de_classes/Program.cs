namespace criacao_de_classes;

class Program
{
    static void Main(string[] args)
    {
    }
}
/*classes -> modifidores da classe -> public, private
não definido -> public
public -> não possui restrições 
*/
public class classe1
{
    //membros da classe -> modificadores de acesso
    //mesma coisa de public int num1 = 55;
    int num1 = 55;

    public void boa_tarde()
    {
        System.Console.WriteLine("boa tarde");
    }
}

