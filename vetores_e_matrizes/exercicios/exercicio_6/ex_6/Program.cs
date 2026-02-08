namespace ex_6;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrizes = new int[2,4];
        int contador = 0;
        for(int i = 0; i < matrizes.GetLength(0); i++)
        {
            for(int s = 0; s < matrizes.GetLength(1); s++)
            {
                System.Console.Write($"digite a matrizes[{i},{s}]:\n-> ");
                matrizes[i,s] = int.Parse(System.Console.ReadLine().Trim());
                if(matrizes[i,s] < 0)
                {
                    contador += 1;
                }
                System.Console.Clear();
            }
        }
        System.Console.WriteLine($"quantos valores negativos tem na matrizes: {contador}");
    }
}
