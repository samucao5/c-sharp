namespace ex_3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("contando de 1 ate 50, mas so numeros impares");
        int i = 1;
        while(i <= 50)
        {
            if ((i % 2 ) == 0)
            {
                i++;
                continue;
            };
            System.Console.WriteLine(i);
            i++;
        }
    }
}
