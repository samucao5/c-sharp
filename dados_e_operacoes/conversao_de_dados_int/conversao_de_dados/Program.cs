namespace conversao_de_dados;

class Program
{
    /*
    convesoes
    implicita e do menor para o maior 
    conversão implicita:
    int inteiro = 10;
    double real = inteiro;

    explicitas: e do maior para o menor 
    conversão explicita:
    double real = 9.8;
    int inteiro = (int)real;

    decimal > double > float > long > int > short
    */


    static void Main(string[] args)
    {
        //conversao implicita (maior -> menor)
        // int -> long
        int x = 10;
        long y = x;
        System.Console.WriteLine($"int: {x} \n long: {y}");

        //float -> double
        float f = 3.5f;
        double d = f;
        System.Console.WriteLine($"float: {f} \n double: {d}");

        //int -> double
        int num1 = 10;
        double num2 = num1;
        System.Console.WriteLine($"int: {num1} \n double: {num2}");

        //explicita (maior -> menor)
        //(tipo) valor
        double num3 = 10.5;
        int num4 = (int)num3;
        System.Console.WriteLine($"double: {num3} \n int: {num4}");

    }
}
