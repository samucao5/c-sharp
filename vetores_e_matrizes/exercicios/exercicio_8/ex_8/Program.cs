namespace ex_8;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite a quantidade de vetores:\n-> ");
        int quantidade = int.Parse(System.Console.ReadLine().Trim());
        int[] valores = new int [quantidade];
        bool repetido = false;
        for(int i = 0;i < valores.Length; i++)
        {
            System.Console.Write($"digite o valor {i + 1}:\n-> ");
            valores[i] = int.Parse(System.Console.ReadLine().Trim());
        }

        for (int i = 0; i < valores.Length; i++)
        {
            for (int j = i + 1; j < valores.Length; j++)
            {
                if (valores[i] == valores[j])
                {
                    repetido = true;
                }
            }
        }

        
        System.Console.WriteLine($"tem valores repetido: {repetido}");
    }
}
