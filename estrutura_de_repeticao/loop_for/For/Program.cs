namespace For;

class Program
{
    /*
    O loop For é um loop que junta 3 caracteristica de um loop, incremento, teste lógico, e inicialização numa só linha do loop
    ex:
    for(int i = 1;i < 5;i++){
    }
    */
    static void Main(string[] args)
    {
        for(int i = 1;i <= 5; i++)
        {
            System.Console.WriteLine(i);
        }

        System.Console.WriteLine("for composto");

        for(int s = 0;s <= 10; s++)
        {
            for(int b = 0;b <= 5; b++)
           {
            System.Console.Write($"nome:{b}");
           }
       }
    }
}
