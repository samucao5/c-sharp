namespace matrizes;

class Program
{
    /*
    matrizes ou arrays bidimensionais, como o nome diz são arrays com 2 dimensões.
    representam uma tabela com diferentes linhas e colunas armazenando dados em várias posições.

    
    
    */


    static void Main(string[] args)
    {


        //int [,]: para indicar que vai ter mais de um indice
        //[l,c]: primeiro sempre e linha e o segundo e coluna
        int[,] numero = new int [3,3];

        numero[0,0] = 15; numero[0,1] = 30; numero[0,2] = 60;
        numero[1,0] = 21; numero[1,1] = 45; numero[1,2] = 2;
        numero[2,0] = 10; numero[2,1] = 43; numero[2,2] = 80;

        for(int i = 0; i < 3; i++)
        {
            for(int b = 0;b < 3; b++)
            {
                System.Console.WriteLine(numero[i,b]);
            }
        }
        
        

    }
}
