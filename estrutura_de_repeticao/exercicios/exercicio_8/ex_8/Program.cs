namespace ex_8;

class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[51];

        for(int i = 0;i <= 50;i++)
        {
            num[i] = i;
        } 

        for(int i = 0;i <= 50;i++)
        {
            System.Console.WriteLine($"vetor{i}: {num[i]}");

        } 
    }
}
