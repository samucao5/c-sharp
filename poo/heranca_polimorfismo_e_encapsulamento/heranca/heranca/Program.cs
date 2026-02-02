namespace heranca;

class Program
{
    /*
    Quando um classe herda de outra classe ela possui as mesmas propriedades e métodos da classe base.

    Chama-se classe base á classe inicial e classe derivada á que herda da classe base
    */
    static void Main(string[] args)
    {
        Pessoa pessoa_1 = new Pessoa("pedro", 20);
        System.Console.Write($"Nome: {pessoa_1.nome}\nIdade: {pessoa_1.idade} anos\nTrabalho: {pessoa_1.nome_trabalho}\nSalario: R${pessoa_1.salario}\n");
    }

    class Trabalho
    {
        public System.String nome_trabalho = "repositor";
        public double salario = 1640;
    }

    class Pessoa:Trabalho
    //possui nome_trabalho, salario e o construtor
    {
        public System.String nome = "fernando";
        public int idade = 18;

        public Pessoa(System.String nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }
}
