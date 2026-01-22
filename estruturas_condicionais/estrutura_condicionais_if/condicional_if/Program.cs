namespace condicional_if;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite sua idade:\n-> ");
        int idade = int.Parse(System.Console.ReadLine());
        //caso idade maior ou igual a 18, ela retorna "acesso permitido"
        if(idade >= 18)
        {
            System.Console.WriteLine("acesso permitido");
        }
    }
}
