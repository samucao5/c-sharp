namespace propriedades_metodos_e_conversoes;

class Program
{
    /*
    métodos
    Funcionalidades que permitem obter informações sobre uma estrutura
    ex:
    int linhas = matriz.GetLength(0); //quantidade de linhas
    int colunas = matriz.GetLength(1); //quantidade de colunas

    Elementos (Propriedades + métodos)
    Membros da estrutura:
    vetor.Length
    vetor.Rank
    matriz.GetLength(0)

    membro da classe Array:
    Array.Sort(vetor);
    Array.Reverse(vetor);
    */
    static void Main(string[] args)
    {
        int[] vetor = {10,20,30};
        int[,] matriz = {{1,2,3},{4,5,6}};

        //pertence à estrutura:
        System.Console.WriteLine(vetor.Length); //comprimento
        System.Console.WriteLine(matriz.Rank); //Quantidade de dimensões

        int[] copia = (int[])vetor.Clone(); //clone de um vetor(conversao)

        //classe Array
        Array.Sort(vetor);//ordenar os elementos (altera o original)
        foreach(int n in vetor)
        {
            System.Console.WriteLine(n);
        }
        System.Console.Write("\n");
        Array.Reverse(vetor);//reverte a ordem dos elementos do vetor (altera o original)
        foreach(int n in vetor)
        {
            System.Console.WriteLine(n);
        }

        int pos = Array.IndexOf(vetor, 10);//retorna o indice do elemento 10

        Array.Clear(vetor, 1, 2);// vetor, indice inicial, quantidade

        //conversões

        //vetor -> string
        int[] v = {20,55,10};
        System.String texto = String.Join(", ",v);
        System.Console.WriteLine(texto);

    }
}
