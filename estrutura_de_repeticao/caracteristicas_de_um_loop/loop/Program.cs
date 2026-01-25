namespace loop;

class Program
{
    /*
    Todos os loops possuem 3 caracteristicas em comum.

    Incremento/decremento, inicialização teste lógicos.

    Essas três caracteristicas permitem distinguir 3 principais loops
    
    */
    static void Main(string[] args)
    {
        System.Console.WriteLine("contando ate 5");
        //inicialização: Valor inicial do teste logico
        int i = 1;
        //teste lógico: Verificação continua de um valor
        while(i <= 5)
        {
            System.Console.WriteLine(i);
            //incrementação/Decrementação: Alteração do valor da inicialização a favor do teste lógico
            i++;
        }
    }
}
