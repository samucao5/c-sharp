namespace ex_9;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3,3];
        int[] resultado  = new int[3];

        for(int i = 0;i < matriz.GetLength(0);i++)
        {
            for(int d = 0;d < matriz.GetLength(1); d++)
            {
                System.Console.Write($"digite o valor da matriz[{i},{d}]:\n-> ");
                matriz[i,d] = int.Parse(System.Console.ReadLine().Trim());
                resultado[i] += matriz[i,d];
                System.Console.Clear();
            }
        }

        for(int c = 0;c < resultado.Length; c++)
        {
            System.Console.WriteLine($"soma das colunas da linha {c + 1}: {resultado[c]}");
        }
    }
}
