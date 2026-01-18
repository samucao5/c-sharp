using System.Reflection.Metadata;

namespace math;

class Program
{
    /*
    Classe:
    Conjunto de metodos e variaveis

    classe math:
    estatica
    pertence ao namespace system
    possui: Constantes, funções utilitarias e matematicas

    
    
    */

    static void Main(string[] args)
    {
        //para criar constante, constante não podem ser mudadas, não diretamente
        const System.String nome = "samuel";

        //classe math
        //Constantes

        //PI
        System.Console.WriteLine(System.Math.PI);

        //Euler
        System.Console.WriteLine(System.Math.E);

        //valor absoluto: retorna so valores com sinal positivo
        System.Console.WriteLine(System.Math.Abs(-55));

        //Maximo e Minimo
        //retorna o maior valor
        System.Console.WriteLine(System.Math.Max(50,23));
        //retorna o menor valor
        System.Console.WriteLine(System.Math.Min(50,23));

        //Potencias e Raizes
        //potencia
        System.Console.WriteLine(System.Math.Pow(10,2));
        //raiz quadrada
        System.Console.WriteLine(System.Math.Sqrt(4));

        //Arredondamento
        //arredonda para o mais proximo
        System.Console.WriteLine(System.Math.Round(5.6)); //6
        //arredonda para cima
        System.Console.WriteLine(System.Math.Ceiling(5.4)); //6
        //arredonda para baixo
        System.Console.WriteLine(System.Math.Floor(5.7)); //5

        //Trigonometria (Radianos)
        double angulo = 45 * (System.Math.PI / 180);

        System.Console.WriteLine(System.Math.Sin(System.Math.Round(angulo)));
        System.Console.WriteLine(System.Math.Cos(System.Math.Round(angulo)));
        System.Console.WriteLine(System.Math.Tan(System.Math.Round(angulo)));

        //Logaritmos e Exponenciais
        Console.WriteLine(System.Math.Log(10)); //Log natural (base e)
        Console.WriteLine(System.Math.Log10(100)); // 2
        Console.WriteLine(System.Math.Exp(1)); //e^¹

    }
}
