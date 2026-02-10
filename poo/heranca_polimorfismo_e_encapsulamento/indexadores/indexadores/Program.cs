namespace indexadores;

class Program
{
    /*
    Os indexadores permitem que objetos comportem-se como vetores.
    Ou seja os objetos são indexados como arrays.
    
    */
    static void Main(string[] args)
    {
        Classe_1 obj = new Classe_1();
        obj[1] = 55;
        System.Console.WriteLine(obj[1]);
    }

}
class Classe_1
{
    private int[] numeros = new int[3]{10,20,30};
    public int this[int i]//indexador (i - indice)
    {
        get{return numeros[i];}
        set{ numeros[i] = value;}
    }
}