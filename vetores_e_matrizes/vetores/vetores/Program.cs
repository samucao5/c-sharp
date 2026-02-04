namespace vetores;

class Program
{
    /*
    formas de se declarar um vetor:
    declaração sem inicialização

    vetor com 5 posições:
    int[] numeros = new int[quantidade_de_vetores];
    
    declaração com inicialização:

    //forma explicita:
    int[] numeros = new int[3] {10, 20, 30};

    //forma implícita:
    int[] numeros = {10, 20, 30};
    */

    static void Main(string[] args)
    {
    //vetor -> array
    //0  1  2  3  4
    //10,20,30,40,50
        System.String[] nomes = new System.String[3];
        nomes[0] = "samuel";
        nomes[1] = "allan";
        nomes[2] = "joao";

        int[] numero = new int[5] {10,20,30,40,50};

        double[] preco = {10.3,11.2, 23.2}; 

    //pegar o comprimento do vetor
        System.Console.WriteLine(numero.Length);

    //caso queira ler somente um dados
        System.Console.WriteLine(numero[3]);

    //laço de repetição para ler vetores
        for(int i = 0;i < nomes.Length;i++)
        {
            System.Console.WriteLine($"vetor{i + 1}: {nomes[i]}");
        }
        int quant = 0;

        while (quant < preco.Length)
        {
            System.Console.WriteLine(preco[quant]);
            quant++;
        }

        for(int a = 0;a < numero.Length; a++)
        {
            System.Console.WriteLine($"vetor{a + 1}: {numero[a]}");
        }
        }
    }

