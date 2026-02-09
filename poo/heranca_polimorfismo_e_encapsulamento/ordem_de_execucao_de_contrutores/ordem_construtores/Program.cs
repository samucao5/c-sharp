namespace ordem_construtores;

class Program
{
    /*
    Em classes derivadas os construtores de 0 argumentos serão executados entre as diferentes classes derivadas.
    Existem uma ordem a qual esses construtores são executados.
    */
    static void Main(string[] args)
    {
        Classe_3 obj = new Classe_3();
    }

    class Classe_1
    {
        public Classe_1()
        {
            System.Console.WriteLine("Construtor da Classe_1");
        }
    }

    class Classe_2 : Classe_1
    {
        public Classe_2()
        {
            System.Console.WriteLine("Construtor da Classe_2");
        }
    }

    class Classe_3: Classe_2
    {
        public Classe_3()
        {
            System.Console.WriteLine("Construtor da Classe_3");
        }
    }
}
