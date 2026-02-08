namespace ex_3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite a quantidade de numeros:\n-> ");
        int quantidade = int.Parse(System.Console.ReadLine().Trim());
        int[] inteiros = new int[quantidade];
        int resultado = 0;

        for(int i = 0;i < inteiros.Length; i++)
        {
            System.Console.Write($"numero{i + 1}:\n-> ");
            inteiros[i] = int.Parse(System.Console.ReadLine().Trim());
        }

        for(int b = 0; b < inteiros.Length; b++)
        {
            int valor = inteiros[b];
            if (resultado < valor)
            {
                resultado = valor;
            }
        }
        
        System.Console.WriteLine("numeros dentro do vetor: ");
        foreach(int n in inteiros)
        {
            System.Console.WriteLine(n);
        }

        int pos = Array.IndexOf(inteiros,resultado);
        System.Console.WriteLine($"indice do maior valor:{pos}");
        
    }
}
