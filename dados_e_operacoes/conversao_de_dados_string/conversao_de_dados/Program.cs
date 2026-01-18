namespace conversao_de_dados;

class Program
{
    /*
    conversões

    classe Convert:
    String numeroStr = "123";
    int numero = Convert.ToInt32(numeroStr);

    função Parse():
    String texto = "42";
    int numero = int.Parse(texto);
    */

    static void Main(string[] args)
    {
        //classe Covert
        string texto = "123";
        int num1 = 5;
        int numero = Convert.ToInt32(texto);
        System.Console.WriteLine(num1 + numero);

        double d = 12.8;
        int numero1 = Convert.ToInt32(d);
        System.Console.WriteLine(numero1);

        bool b = true;
        int numero2 = System.Convert.ToInt32(b);
        System.Console.WriteLine(numero2);

        //metodo parse (so funciona com valores primitivos como: int, double, char, etc)
        string text = "555";
        int num3 = int.Parse(text);
        System.Console.WriteLine(num3);

        //entrada de dados
        System.Console.Write("digite o nome do produto: \n ->");
        string produto_nome = System.Console.ReadLine();
        System.Console.Write($"\ndigite o preço do produto {produto_nome} \n ->");
        double preco = Convert.ToDouble(System.Console.ReadLine());
        System.Console.WriteLine($"o produto e {produto_nome} tem o preco de R$ {preco}");

    }
}
