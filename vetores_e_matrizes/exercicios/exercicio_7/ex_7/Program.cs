namespace ex_7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite o numero de linhas da matriz:\n-> ");
        int linhas = int.Parse(System.Console.ReadLine().Trim());
        System.Console.Write("digite o numero de colunas da matriz:\n-> ");
        int colunas = int.Parse(System.Console.ReadLine().Trim());
        int[,] matriz = new int[linhas,colunas];
        int[] resultado = new int[linhas];

        for(int i = 0;i < matriz.GetLength(0); i++)
        {
            
            for(int c = 0; c < matriz.GetLength(1); c++)
            {
                System.Console.WriteLine($"digite o valor da matriz [{i},{c}]");
                matriz[i,c] = int.Parse(System.Console.ReadLine().Trim());

                if(matriz[i,c] > resultado[i])
                {
                    resultado[i] = matriz[i,c];
                }
                System.Console.Clear();
            }
        } 
        for(int d = 0; d < resultado.Length; d++)
        {
            System.Console.WriteLine($"maior valor da linha {d + 1}: {resultado[d]}");
        }
    }
}
