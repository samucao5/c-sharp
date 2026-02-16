namespace busca_sequencial;

class Program
{
    /*
    A busca sequencial, tambem conhecida como busca linear, é um algoritmo que percorre cada elemento de uma lista em sequência até encontrar o elemento desejado

    Algoritmo
    loop for que percorre a lista

    condicional que testa se o valor é igual ao procurado
    */
    static void Main(string[] args)
    {
        System.String[] nomes = new System.String[5] {"isa", "mar", "dan", "samuel", "allan"};
        System.Console.Write("digite o nome da pessoa:\n->");
        System.String buscar = System.Console.ReadLine().Trim().ToLower();
        System.String s = BuscaSequencial(nomes,buscar);
        System.Console.WriteLine(s);
    }

    static System.String BuscaSequencial(System.String[] lista,System.String valor)
    {
        for(int i = 0; i < lista.Length; i++)
        {
            if(lista[i] == valor)
            {
                return $"valor encontrado no vetor[{i + 1}]: {lista[i]}";
            }
        }
        return "valor não encontrado";
    }
}
