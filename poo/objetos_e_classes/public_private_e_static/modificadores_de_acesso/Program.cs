namespace modificadores_de_acesso;

class Program
{
    /*
    Introdução
    os modificadores da classe e especificadores de acesso são termos utilizados para definir a proteção / visibilidade de um elemento
    
    Public -> público / sem restrições

    private -> restrito à propria classe

    Static -> elementos pertencem à classes e não precisam de objetos
    todos valores dentro da static devem ser static

    sintaxe
    modificador class nome
    {
    especificador valor nome;
    }
    */
    static void Main(string[] args)
    {
        Felinos gato_1 = new Felinos();
        System.Console.WriteLine(gato_1.ex1);
    }

}

public class Felinos
{
    public int ex1 = 0;
    private int ex2 = 0;



}