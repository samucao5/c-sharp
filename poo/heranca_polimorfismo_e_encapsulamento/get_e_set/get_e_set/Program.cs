namespace get_e_set;

class Program
{
    /*
    Os acessors Get e Set permitem-nos trabalhar com propriedades privadas de maneira segura.

    Get -> de leitura
    Set -> de escrita / alteração
    
    */
    static void Main(string[] args)
    {
        Classe_1 obj = new Classe_1();
        obj.mudar_valor = 5;
        System.Console.WriteLine(obj.Num);

    }
}

class Classe_1
{
    //tambem pode ser criado como public int Num(get;set);
    private int num = 50;
    public int Num
    {
        get //chama o valor (leitura)
        {
            return num;
        }   
    }

    public int mudar_valor//alterar (escrita)
    {
        set
        {
            num = value;
        }
    }
}
