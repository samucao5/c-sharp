namespace ex_5;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrizes = new int[3,3];

        for(int i = 0; i < matrizes.GetLength(0); i++)
        {
            for(int b = 0; b < matrizes.GetLength(1); b++)
            {
                System.Console.Write($"digite na matriz [{i},{b}]:\n-> ");
                matrizes[i,b] = int.Parse(System.Console.ReadLine().Trim());
                System.Console.Clear();
            }
        }

        int resultado_diagonal_1 = (matrizes[0,0] + matrizes[1,1] + matrizes[2,2]);
        int resultado_diagonal_2 = (matrizes[0,2] + matrizes[1,1] + matrizes[2,0]);
        int resultado_final = resultado_diagonal_1 + resultado_diagonal_2;

        System.Console.WriteLine(resultado_final);
    }
}
