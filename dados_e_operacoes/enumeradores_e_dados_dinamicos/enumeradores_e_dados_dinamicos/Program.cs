namespace enumeradores_e_dados_dinamicos;

class Program
{
    /*
    dados:
    permanecem em variaveis que possuem um tipo

    enumeradores:
    tipo especial que representa um conjunto de valores

    dados do enumerador:
    enum Dias{segunda, quinta, sexta}
    Dias hoje = Dias.segunda;

    //tipos dinamicos:
    oposto de tipagem forte

    dynamic x = 10;
    x = "ola, mundo";
    
    importante

    var:
    tipo definido em tempo de compilação
    Depois de definido não pode mudar

    dynamic:
    tipo definido em tempo de execução
    pode mudar para qualquer tipo
     
    */
    enum estacoes{Verao, outono, inverno, primavera}
    static void Main(string[] args)
    {
        estacoes estacao_atual = estacoes.Verao;
        System.Console.WriteLine(estacao_atual);
        System.Console.WriteLine((int)estacao_atual);

        //dynamic -> sem tipo

        dynamic valor = 5;
        System.Console.WriteLine(valor);

        valor = "agora e uma texto";
        System.Console.WriteLine(valor);

        valor = false;
        System.Console.WriteLine(valor);
    }
}
