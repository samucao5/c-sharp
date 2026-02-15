namespace bubble_sort;

class Program
{
    /*
    Este algoritmo percorre repetidamente a lista, compara elementos adjacentes e os troca se estiverem na ordem errada.

    A cada passagem atraves da lista, o maior elemento "sobe" para a sua posição correta.

    {5,3,1,2,4} -> {1,2,3,4,5}

    1 Loop
        Define a quantidade de iterações
    2 Loop
        Percorre a estrutura de dados
    3 Condicional
        Compara os valores e move-los
    */
    static void Main(string[] args)
    {
        int[] vetor = new int[5];
        for(int b = 0;b < vetor.Length; b++)
        {
            System.Console.Write($"digite um valor para o vetor[{b + 1}]:\n->");
            vetor[b] = int.Parse(System.Console.ReadLine().Trim());
        }
        Bubble_sort(vetor);
        foreach(var item in vetor)
        {
            System.Console.WriteLine(item);
        }
    }

    static void Bubble_sort(int[] arr)
    {
        int n = arr.Length;
        for(int i = 0; i < n-1; i++)
        {
            for(int j = 0; j < n-i-1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    int t = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = t;
                }
            }
        }
    }
}
