namespace Struct;

class Program
{
    /*
    Estrutura são um tipo de dado que armazenam outros dados de diversos tipos.
    É parecido mas não é uma classe.
    E`considerado um tipo de valor e não de referencia
    Pode ter construtores
    */
    static void Main(string[] args)
    {
        //podemos chamar destas duas maneiras
        est1 obj = new est1(20,31);
        est1 valores;
        //podemos criar em forma de array tambem
        //um array de dois valores
        est1[] nome = new est1[2];
        nome[0].n1 = 10;
        valores.n1 = 20;
        valores.n2 = 5;
        System.Console.WriteLine(valores.n1);
        System.Console.WriteLine(obj.n2);
        System.Console.WriteLine(nome[0].n1);
    }

    struct est1
    {
        public int n1;
        public int n2;

        public est1(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
    }
}
