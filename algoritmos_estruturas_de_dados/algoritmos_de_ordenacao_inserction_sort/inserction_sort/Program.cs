namespace inserction_sort;

class Program
{
/*
O algoritmo Inserction Sort move um elemento de cada vez para a sua posição
Move elementos não ordenados para uma parte ordenada da lista
Inicia no segundo elemento

1 Loop
Número de repetições

2 Loop
Move os elementos para a sua posição correta

*/
    static void Main(string[] args)
    {
        int[] vetor = new int[5];
        for(int s = 0; s < vetor.Length; s++)
        {
            System.Console.Write($"digite um valor para o vetor[{s + 1}]:\n->");
            vetor[s] = int.Parse(System.Console.ReadLine().Trim());
            System.Console.Clear();
        }
        InSort(vetor);
        foreach(var item in vetor)
        {
            System.Console.WriteLine(item);
        }

    }

    static void InSort(int[] arr)
    {
        for(int i = 1;i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while(j>=0 && arr[j] > key)
            {
                arr[j+1] = arr[j];
                j = j - 1;
            }

            arr[j+1] = key;
        }
    }
}
