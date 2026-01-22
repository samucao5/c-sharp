namespace operadores_logicos;

class Program
{
    /*
    operador  designação 
    & e &&    AND (e)
    ^         XOR (Exclusive Or)
    | e ||    OR (ou)
    !         NOT (negação)
    
    */


    static void Main(string[] args)
    {
        System.Console.Write("digite um numero: \n->");
        int num1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("digite um segundo numero: \n->");
        int num2 = int.Parse(System.Console.ReadLine());

        //AND (&&): retorna true caso todos os requisitos forem true
        System.Console.WriteLine($"({num1} > {num2}) && ({num1} != {num2}) : {(num1 >= num2) && (num1 != num2)}");

        //OR (||):retorna true caso um dos requisitos for true
        System.Console.WriteLine($"({num2} < {num1}) || ({num1} != {num2}): {(num2 < num1 ) || (num1 != num2)}");

        //XOR (^): quando os dois requisitos sejam true o XOR retornara falso
        System.Console.WriteLine($"({num1} > {num2}) && ({num1} != {num2}) : {(num1 >= num2) ^ (num1 != num2)}");

        //NOT (!): retorna o contrario do que retornaria ex: caso retorne true o NOT retorna false
        System.Console.WriteLine($"!({num2} < {num1}) || !({num1} != {num2}): {!(num2 < num1 ) || !(num1 != num2)}");
        
    }
}
