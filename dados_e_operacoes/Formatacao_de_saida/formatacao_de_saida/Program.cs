namespace formatacao_de_saida;

class Program
{

    /*
    \n = Quebra de linha
    \b = Backspace (delete)
    \" = Aspas duplas
    \a = bell (sinal sonoro)
    \r = Carriage return
    \t = tubulação horizontal
    \v = tubulação vertical
    \\ = caractere \
    \' = caractere '
    \" = caractere "
    \? = caractere ? 
    */



    static void Main(string[] args)
    {
        Console.WriteLine("\t opa,\nmundo");
        Console.Write("\n ola, \"mundo\" ");
        Console.Write("\n ola, \\mundo\\");
    }
}
