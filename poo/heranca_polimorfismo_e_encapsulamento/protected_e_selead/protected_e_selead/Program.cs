namespace protected_e_selead;

class Program
{
    /*
    Membros protected funcionam como membros privados mas podendo ser acessados em classes derivadas.
    Já classes sealed não podem ser herdadas.

    */
    static void Main(string[] args)
    {
        Classe_2 obj = new Classe_2();
        obj.n1 = 5;
        obj.metodo();
        obj.metodo_3();
    }

    class Classe_1
    {
        public int n1;
        private int n2;
        protected int n3;
    }

    class Classe_2:Classe_1
    {
        public void metodo()
        {
            System.Console.WriteLine(n1);
        }

        /*aparece um problema e não deixa ocorrer o andamento do codigo
        public void metodo_2()
        {
            System.Console.WriteLine(n2);
        }
        */
        //mostra o valor de n3 pois o valor pode ser lido por classes derivadas
        public void metodo_3()
        {
            System.Console.WriteLine(n3);
        }
        
        //a classe selead pode herdar valores de outra classe, mas não pode ser herdada
        sealed class Classe_3:Classe_1{
            
        }
        
        /*
        retorna um erro pois a Classe_3 não pode ser herdada
        class Classe_4: Classe_3{
        
        }


        */
              
    }
}
