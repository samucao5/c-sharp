namespace ex_2;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[6];

        for(int i = 0;i < numeros.Length; i++)
        {
            System.Console.Write($"numero{i + 1}:\n->");
            numeros[i] = int.Parse(System.Console.ReadLine().Trim());
            System.Console.Clear();
        }

        System.Console.WriteLine("vetor normal:");

        foreach (int n in numeros)
        {
            System.Console.WriteLine(n);
        }

        Array.Reverse(numeros);

        System.Console.WriteLine("vetor ao contrario");

        foreach (int n in numeros)
        {
            System.Console.WriteLine(n);
        }
    }
}
