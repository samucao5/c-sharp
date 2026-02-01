namespace destrutores;

class Program
{
    /*
    um método é o contrario de um método construtor da classe.
    o método Destrutor será chamado quando um objeto deixar de existir.
    */

    static void Main(string[] args)
    {
        Felinos gato_1 = new Felinos("mel");
        System.Console.WriteLine(gato_1.nome);

    }
    
    class Felinos
    {
        public int vida = 10;
        public System.String nome;

        public Felinos(string n)
        {
            nome = n;
        }

        //para criamos destrutores so precisamos colocar um ~nome_da_classe(){}
        ~Felinos()
        {
            Console.WriteLine("objeto deixou de existir");
        }
    
    }   

}
