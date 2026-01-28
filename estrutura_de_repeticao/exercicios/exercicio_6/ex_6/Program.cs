namespace ex_6;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int [5];
        for (int i = 0;i < 5;i++)
        {
            System.Console.Clear();
            System.Console.Write($"adicione um numero no vetor{i+1}:\n->");
            numeros[i] = int.Parse(System.Console.ReadLine().Trim());
        }

        for (int i = 0;i < 5;i++)
        {
            System.Console.WriteLine($"numero do vetor{i + 1}:{numeros[i]}");
        }
    }
}
