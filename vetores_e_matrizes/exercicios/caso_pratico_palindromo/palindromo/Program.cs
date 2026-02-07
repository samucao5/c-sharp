namespace palindromo;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Digite um numero inteiro:\n->");
        string numero = System.Console.ReadLine(); //12321

        char[] digitos = numero.ToCharArray(); //['1', '2', '3', '2', '1']
        bool palindromo_1 = true;

        for(int i = 0; i < digitos.Length / 2; i++)
        {
            //i = 0 -> digitos[0] com digitos[length-1]
            if(digitos[i] != digitos[digitos.Length - 1 - i])
            {
                palindromo_1 = false;
                System.Console.WriteLine("este valor não e um palindromo");
                break;  
            }
            System.Console.WriteLine("este valor e um palindromo");
        }
    }
}
