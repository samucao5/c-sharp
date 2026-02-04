namespace heranca_de_construtores;

/*
Construtores não são herdados

Cada classe possui um construtor padrão que possui 0 argumentos.
Ao herdar uma classe de outra que possui um construtor de maior número de construtores
o objeto da classe  derivada não vai herdar o construtor da classe base.
*/

class Program
{

    static void Main(string[] args)
    {
        Classe_2 obj = new Classe_2();
    }
}

class Classe_1
{
        public Classe_1(int n1)
    {
        System.Console.WriteLine("construtor da C1");
    }
}

class Classe_2:Classe_1
{
    static int valor = 10;
    //O :base chama o construtor da classe base durante herança.
    //: base(argumentos);
    public Classe_2():base(valor){
        System.Console.WriteLine("Construtor da C2");
    }
}

