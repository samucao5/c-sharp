namespace ex_4;

class Program
{
    static void Main(string[] args)
    {
        while(true){
        erro1:
        System.Console.Clear();
        System.Console.Write("digite um numero inteiro para começar\nobs:deve ser menor que o segundo\n->");
        int num1 = int.Parse(System.Console.ReadLine().Trim());
        System.Console.Write("digite o segundo numero inteiro para terminar\nobs:deve ser maior que o primeiro\n->");
        int num2 = int.Parse(System.Console.ReadLine().Trim());
        if(num1 < num2){
        for(int i = 0;i <= num2;i++)
        {
            if((num1 <= i) && (num2 >= i))
            {
                System.Console.WriteLine(i);
            }
            continue;
        }
        }
        else
        {
            System.Console.Clear();
            System.Console.WriteLine("numero1 esta maior que numero2, digite novamente");
            goto erro1;

        }
            
        erro2:
        System.Console.Write("sair do programa:\ndigite sim ou não\n->");
        System.String opcao = (System.Console.ReadLine().Trim()).ToLower();
        if(opcao == "sim")
            {
            System.Console.Clear();
            System.Console.WriteLine("saindo do programa");
            break;
            }
            else if(opcao == "nao" || opcao == "não")
            {
                System.Console.Clear();
            }
            else
            {
                System.Console.WriteLine("opcao não encontrada, digite novamente");
                goto erro2;
            }
        }
            
    }    
}
