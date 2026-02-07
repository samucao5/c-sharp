namespace Loop_foreach;

class Program
{
    /*
    Loop Foreach:
    Estrutura de repetição própria para percorrer coleções
    Executa um bloco de código para cada elemento ao mesmo tempo que o lê
    
    Sintaxe
    o loop foreach possui a seguinte sintaxe:

    tipo[] vetor = {...};

    foreach(tipo elemento in vetor)
    {
        bloco de codigo
    }
    
    */
    static void Main(string[] args)
    {
        System.String[] nomes = {"samuel", "maria", "joao", "daniele"};

        foreach(System.String n in nomes)
        {
            System.Console.WriteLine(n);
        }

    //Atenção:
    //foreach não indica a posição
    //não salta posições
    //n não e alteravel

        int[,] matriz =
        {
            {2,3},
            {1,5},
            {7,9}
        };

        foreach(int n in matriz)
        {
            System.Console.WriteLine(n);
        }

    }
}
