namespace metodos_para_array_e_matrizes;

class Program
{
    /*
    Existem diversos métodos para trabalhar com arrays, seja desde copiar, procurar indice, elemento etc.




    */
    static void Main(string[] args)
    {
        int[] numeros = {10,40,32}; 
        //procura um valor pelo array
        //System.Array.binarySearch(nome_do_array, numero ou qualquer coisa que deseja procurar);
        int pos = System.Array.BinarySearch(numeros, 40);
        System.Console.WriteLine(pos);
        
        //pega um valor do array 
        object value = numeros.GetValue(2);
        //tambem funciona da maneira abaixo caso não queira usar o object
        int valores = Convert.ToInt32(numeros.GetValue(1));
        System.Console.WriteLine(value);
        System.Console.WriteLine(valores);

        //pegar o menor espaço do array no caso 0
        //caso queira um array digite 0 dentro dos parenteses numeros.GetLowerBound(0);
        //caso queira trabalhar com uma matriz digite 1 dentro dos parenteses numeros.GetLowerBound(1);
        int m_index = numeros.GetLowerBound(0);
        System.Console.WriteLine(m_index);

        //pega o maior espaço do array no caso 2
        int u_index = numeros.GetUpperBound(0);
        System.Console.WriteLine(u_index);

        //reverte a ordem dos vetores
        System.Array.Reverse(numeros);

        System.Console.WriteLine(numeros[0]);
        foreach(int n in numeros)
        {
            System.Console.WriteLine(n);
        }

    }
}
