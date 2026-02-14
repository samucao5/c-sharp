namespace tratamento_de_excecoes;

class Program
{
    /*
    Uma exceção é um erro ou falha não detectada pelo compilarode sim na hora de rodar o programa
    Em c# é possivel tratar excessões atraves da estrutura Try-Catch_finally
    
    */
    static void Main(string[] args)
    {
        int n1 = 10;
        int n2 = 0;

        try
        {//verifica ser tem um erro ou tenta
            System.Console.WriteLine(n1/n2);
        }
        catch(Exception erro)//caso tenha o erro a mensagem e exibida na tela
        {
            System.Console.WriteLine("houve um erro "+erro.Message);
        }
        finally//a mensagem que e sempre exibida mesmo dando certo ou errado
        {
            System.Console.WriteLine("fim da conta");
            //caso queira gerar um erro deve usar o comando abaixo
            //throw new Exception("erro");
        }
    }
}
