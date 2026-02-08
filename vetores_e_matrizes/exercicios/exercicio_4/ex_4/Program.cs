namespace ex_4;

class Program
{
    static void Main(string[] args)
    {
        int[] numero = {3,2,5,6};
        int resultado = 0;
        foreach(int n in numero)
        {
            if((n % 2) == 0)
            {
                resultado += n;
            }
        }

        System.Console.WriteLine($"soma dos numeros pares: {resultado}");
    }
}
