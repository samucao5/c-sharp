namespace ex_10;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite a quantidade de vetor:\n-> ");
        int quantidade = int.Parse(System.Console.ReadLine().Trim());
        int[] vetores = new int [quantidade];
        int contador = 0;
        for(int i = 0; i < vetores.Length; i++)
        {
            System.Console.Write($"numero {i + 1}:\n-> ");
            vetores[i] = int.Parse(System.Console.ReadLine().Trim());

            if((vetores[i] >= 10) && (vetores[i] <= 20))
            {
                contador += 1;
            }
        }
        System.Console.WriteLine($"quantidade de numeros entre 10 e 20: {contador}");
    }
}
