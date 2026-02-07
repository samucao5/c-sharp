namespace iteracao_sobre_matrizes;

class Program
{
    /*
    Iteração: Percorrer um iteravel
    Iterável: Qualquer estrutura que pode ser percorrida

    Iterar uma matriz:
    Percorrer todos os seus elementos, um por um, para ler, modificar ou usar cada valor.
    como? Atraves de um loop (For,While,Do-while ou foreach)
    
    metodos essenciais:
    int linhas = matriz.GetLenght(0); quantidade de linhas
    int colunas = matriz.GetLenght(1); quantidade de colunas
    
    Iteração com loops:
    Loop externo -> percorrer linhas
    Loop Interno -> percorrer colunas
    */

    static void Main(string[] args)
    {
        int[,] numeros = new int[3,2];
        numeros[0,0] = 10;
        numeros[0,1] = 5;
        numeros[1,0] = 8;
        numeros[1,1] = 4;
        numeros[2,0] = 3;
        numeros[2,1] = 1;

        System.Console.WriteLine($"quantidade de linhas: {numeros.GetLength(0)}");
        System.Console.WriteLine($"quantidade de colunas: {numeros.GetLength(1)}");
        
        for(int i = 0; i < numeros.GetLength(0) ;i++)
        {
            for(int b = 0; b < numeros.GetLength(1); b++)
            {
                System.Console.WriteLine($"{numeros[i,b]}");
            }
        }
    }
}
