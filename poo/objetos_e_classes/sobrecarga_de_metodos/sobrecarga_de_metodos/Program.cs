namespace sobrecarga_de_metodos;

class Program
{
    /*
    A sobrecarga de métodos dá se quando existem vários métodos com o mesmo nome numa classe mas número de argumentos diferente.
    Parecido com a sobrecarga de construtores 
    */

    static void Main(string[] args)
    {
        Calculo calculo_1 = new Calculo();
        System.Console.WriteLine(calculo_1.soma(20,35));
        Calculo calculo_2 = new Calculo();
        System.Console.WriteLine(calculo_2.soma(1,2,2));
    }

    class Calculo
    {
        public int soma(int num1, int num2)
        {
            return num1+num2;
        }
        public int soma(int num1, int num2,int num3)
        {
            return num1+num2+num3;
        }
    }
}
