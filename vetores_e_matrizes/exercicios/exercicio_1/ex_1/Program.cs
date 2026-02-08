namespace ex_1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("quantos numeros voce deseja utilizar:\n->");
        int quantidade = int.Parse(System.Console.ReadLine().Trim());
        
        int[] numeros = new int[quantidade];
        int media = 0;
        for(int i = 0;i < quantidade; i++)
        {
            System.Console.Clear();
            System.Console.Write($"numero {i + 1}\n->");
            numeros[i] = int.Parse(System.Console.ReadLine().Trim());
            media = media + numeros[i];
        }
        
        media = media / quantidade;

        System.Console.WriteLine($"numeros maiores que a media({media}):");
        for(int s = 0; s < quantidade; s++)
        {   
            if(numeros[s] > media)
            {
                System.Console.WriteLine(numeros[s]);
            }
        }
    }
}
