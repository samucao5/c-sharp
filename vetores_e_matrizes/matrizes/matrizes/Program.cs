namespace matrizes;

class Program
{
    /*
    Declaração:

    Matriz bidimensional (3 linhas e 2 colunas):

    int[,] numeros = new int[linhas,colunas];
    int[,] numeros = new int[3,2];

    Declaração com inicialização:

    int[,] matriz = {
        {1,2},
        {3,4},
        {5,6}
    };
    
    
    */

    static void Main(string[] args)
    {
        //matriz -> multidimensional (bidimensional ou tridimensional)
        int[,] matriz = new int[3,3]; // 3 linhas e 3 colunas
        // caso queira uma matriz tridimensional e so fazer: int[,] matriz = new int[3,3,3];
        //adicionar dados dentro da matriz 0,0
        matriz[0,0] = 10;
        System.Console.WriteLine(matriz[0,0]);
        int[,] numeros =
        {
            {5,3},
            {9,0},
            {2,3}
        };

        System.Console.WriteLine(numeros[2,1]);
        //saber a soma todas de fatores da matrizes (linhas + colunas)
        System.Console.WriteLine(numeros.Length);
        //saber somente as linhas das matrizes
        //GetLength(0) e somente para linhas
        System.Console.WriteLine(numeros.GetLength(0));
        //saber somente as linhas das matrizes
        //GetLength(1) e somente para colunas
        System.Console.WriteLine(numeros.GetLength(1));
        //caso queira pegar caso queira descobrir somente o volume ou profundidade de uma matriz tridimensional
        //GetLength(2)
    }
}
