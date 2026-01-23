namespace condicionais_compostas;

class Program
{
    static void Main(string[] args)
    {
       System.Console.Write("digite sua idade:\n->");
       int idade = int.Parse(System.Console.ReadLine());
       System.Console.Write("qual seu sexo:\n->");
       char sexo = char.Parse(((System.Console.ReadLine()).ToLower()).Trim());

       if(idade >= 18 && sexo == 'm')
        {
            System.Console.Write("ja serviu o exercito?\n->");
            System.String resultado = ((System.Console.ReadLine()).ToLower()).Trim();
            if(resultado == "sim")
            {
                System.Console.WriteLine("boa sorte");
            }
            else if(resultado == "nao" || resultado == "não")
            {
                System.Console.WriteLine("boa sorte no alistamento");
            }
            else
            {
                System.Console.WriteLine("resultado não encontrado");
            }
        }
        else if(idade >= 18 && sexo == 'f')
        {
            System.Console.WriteLine("voce e maior de idade");
        }
        else
        {
            System.Console.WriteLine("voce e menor de idade");
        }

    }
}
