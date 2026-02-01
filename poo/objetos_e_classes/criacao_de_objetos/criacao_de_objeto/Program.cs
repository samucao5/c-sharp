namespace criacao_de_objeto;

class Program
{
    static void Main(string[] args)
    {
        //criação de objetos cachorro_1 e cachorro_2
        cachorro cachorro_1 = new cachorro();
        cachorro cachorro_2 = new cachorro();
        //cachorro_1 perde 10 de vida
        cachorro_1.vida = cachorro_1.vida - 10;
        //exibindo a vida de cachorro_1
        System.Console.WriteLine(cachorro_1.vida);
        //exibindo a vida de cachorro_2
        System.Console.WriteLine(cachorro_2.vida);
        //cachorro_2 perde vida de acordo com a vida do cachorro_1
        cachorro_2.vida = cachorro_2.vida - cachorro_1.vida;

        System.Console.WriteLine(cachorro_2.vida);
        //exibe o metodo ataque
        cachorro_1.ataque();

        //exibe o metodo de dano
        cachorro_1.damage(5);
        System.Console.WriteLine(cachorro_1.vida);
        
    }

    public class cachorro{
        public int vida = 100;
    public void ataque()
    {
        System.Console.WriteLine("mordida");
    }

    public void damage(int dano)
        {
            vida = vida - dano;
        }
}
}
