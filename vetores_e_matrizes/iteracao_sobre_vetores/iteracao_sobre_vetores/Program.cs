namespace iteracao_sobre_vetores;

class Program
{
    /*
    conceitos:
    Iteração -> percorrer um iterável
    Iterável -> Qualquer estrutura que pode ser percorrida

    Iterar um vetor:
    Percorrer todos os seus elementos, um por um, para ler, modificar ou usar cada valor
    Como? -> Através de um loop (For, While, Do-While ou Foreach)
    
    */
    static void Main(string[] args)
    {   
        System.Console.Write("quantos funcionarios serão cadastrados\n->");
        int quant = int.Parse(System.Console.ReadLine().Trim());

        System.String[] nome = new System.String[quant];
        int[] idade = new int[quant];
        System.String[] cargo = new System.String[quant];
        int repeat = 0;

        do
        {   
            System.Console.WriteLine($"funcionario {repeat + 1}");
            System.Console.Write("digite o nome do funcionario:\n->");
            nome[repeat] = System.Console.ReadLine().Trim().ToLower();

            System.Console.Write("digite o idade do funcionario:\n->");
            idade[repeat] = int.Parse(System.Console.ReadLine().Trim());

            System.Console.Write("digite o cargo do funcionario:\n->");
            cargo[repeat] = System.Console.ReadLine().Trim().ToLower();
            System.Console.Clear();
            repeat++;
        }while(repeat < quant);


          for(int i = 0;i < nome.Length;i++)
        {
            System.Console.WriteLine($"nome{i + 1}: {nome[i]}");
        }
        int s = 0;
        while (s < idade.Length)
        {
            System.Console.WriteLine($"idade{repeat + 1}: {idade[s]}");
            s++;
        }

        for(int a = 0;a < cargo.Length; a++)
        {
            System.Console.WriteLine($"cargo{a + 1}: {cargo[a]}");
        }
    }
}
