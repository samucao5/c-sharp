namespace retorno_de_objetos;

class Program
{
    /*
    É possivel um método retornar um objeto.
    Para isso ele vai ter que utilizar o operador new diretamente no retorno com a classe.
    */
    static void Main(string[] args)
    {
        Class_1 objeto_1 = new Class_1();
        //objeto_2 guardando a saida do metodo do objeto_1
        Class_2 objeto_2 = objeto_1.metodo();
        System.Console.WriteLine(objeto_2.num_1);
    }

    class Class_1
    {
        //pegando a saida da Class_2
        public Class_2 metodo()
        {
            return new Class_2();
        }
    }

    class Class_2
    {
        public int num_1 = 20;
        public Class_2()
        {
            System.Console.WriteLine("objeto criado");
        }
    }
}
