namespace Out;

class Program
{
    /*
    O tipo de argumento Out funciona de forma semelhante ao argumento ref.

    um argumento out sera um argumento de saida
    */

    static void Main(string[] args)
    {
        System.String nome_1;
        retornando_nome(out nome_1);
        System.Console.WriteLine($"seu nome e: {nome_1}");

    }
/*
Diferenças entre red e out

Ref:
A variavel deve ser inicializada no metodo não e necessario ser modificada

Out:
A variavel não precisa ser inicializada no metodo a variavel deve ser modificada
*/

    static void retornando_nome(out System.String nome)
    {
        System.Console.Write("digite seu nome:\n->");
        nome = System.Console.ReadLine().Trim().ToLower();
    }
}
