namespace caso_pratico;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite um numero:\n-> ");
        double numero1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("digite um segundo numero: ");
        double numero2 = int.Parse(System.Console.ReadLine());

        if(numero1 < numero2)
        {
            numero1 = numero1;
        }
        else if(numero1 > numero2)
        {
            numero2 = numero1;
        }
        else
        {
            numero2 = numero2;
        }

        System.Console.Write($"maior: {numero2} \nmenor: {numero1}");

    }
}
