namespace busca_binaria;

class Program
{
    /*
    Busca binaria
    O principio básico é dividir repetidamente o intervalo de busca pela metade até que o elemento desejado seja encontrado ou até que o intervalo de busca se torne vazio.

    Trabalha com listas ordenadas
    
    Algoritmo
    Loop While

    3 condições
    */
    static void Main(string[] args)
    {
        int[] lista = {1,2,3,4,5,6,7,8,9,10};
        System.Console.Write("Digite o numero que deseja procurar:\n->");
        int num = int.Parse(System.Console.ReadLine().Trim());
        int id = BuscaBinaria(lista,num);
        System.Console.WriteLine(id);
        
    }

    static int BuscaBinaria(int[] lista, int val)
    {
        int inicio = 0;
        int fim = lista.Length -1;

        while(inicio <= fim)
        {
            int meio = (inicio+fim)/2;

            if(lista[meio] == val)
            {
                return lista[meio];
            }
            else if(lista[meio] < val)
            {
                inicio = meio + 1;
            }
            else //lista[meio] > val
            {
                fim = meio-1;
            }
        }
        return -5;
    }
}
