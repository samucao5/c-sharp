namespace incremento_e_decremento;

class Program
{
    /*
    Uma das caracteristicas de um loop é o processo da incrementação e decrementação.
    Esses processos são feitos atraves de operadores de incremento e decremento,que tem como função adicionar 1 ao valor atual.
    ++
    ex: n1++;
    --
    ex: n1--;

    ordem do sufixo(++)
    caso voce coloque antes e depois da variavel
    ++num1: Incrementa primeiro, depois usa
    num1++: Usa primeiro, depois incrementa

    */
    static void Main(string[] args)
    {
        System.Console.Write("digite um numero:\n->");
        int num1 = int.Parse(System.Console.ReadLine().Trim());
        int num2 = num1 + 1;
        System.Console.WriteLine($"voce digitou {num1}, eu escolho {num2} Ganhei");

        //postfix (sufixo)
        int num3 = 20;
        System.Console.WriteLine(num3);
        System.Console.WriteLine(num3++);
        System.Console.WriteLine(num3);
        
        //prefixo
        int num4 = 20;
        System.Console.WriteLine(num4);
        System.Console.WriteLine(++num4);
        System.Console.WriteLine(num4);
    }
}
