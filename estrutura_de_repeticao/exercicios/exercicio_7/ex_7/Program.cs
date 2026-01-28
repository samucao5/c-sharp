namespace ex_7;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int [10];
        for (int i = 0;i < 10;i++)
        {
            System.Console.Clear();
            System.Console.Write($"adicione um numero no vetor{i+1}:\n->");
            numeros[i] = int.Parse(System.Console.ReadLine().Trim());
        }
        System.Console.WriteLine("mostrando o vetor em ordem normal:\n");

        for (int i = 0;i < 10;i++)
        {
            System.Console.WriteLine($"numero do vetor{i + 1}:{numeros[i]}");
        }

        System.Console.WriteLine("mostrando o vetor com a ordem invertida:\n");
        System.Array.Reverse(numeros);

        for (int i = 0;i < 10;i++)
        {
            System.Console.WriteLine($"numero do vetor{i + 1}:{numeros[i]}");
        }

    }
}
