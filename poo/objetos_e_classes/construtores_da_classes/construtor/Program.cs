namespace construtor;

class Program
{
    /*
    Todas as classes podem possuir um método construtor.
    Quando instanciado um objeto dessa classe o método construtor será imediatamente chamado 
    */
    static void Main(string[] args)
    {
       carros carro_1 = new carros();
       System.Console.Write("digite a marca do carro:\n->");
       carro_1.marca = System.Console.ReadLine().Trim().ToLower();
       System.Console.Write("digite o modelo do carro:\n->");
       carro_1.modelo = System.Console.ReadLine().Trim().ToLower();
       System.Console.Write("digite o preço do carro:\n->");
       carro_1.preco = double.Parse(System.Console.ReadLine().Trim());
       carro_1.apresentacao(carro_1.marca, carro_1.modelo, carro_1.preco);

       vendedor vendedor_1 = new vendedor("marcio", 25);
       System.Console.WriteLine($"nome do vendedor: {vendedor_1.nome}");
       System.Console.WriteLine($"idade do vendedor: {vendedor_1.idade}");
    }

    class carros
    {
        public System.String marca, modelo;
        public double preco;
        public void apresentacao(System.String marca, System.String modelo, double preco)
        {
            System.Console.WriteLine($"o modelo do carro e: {modelo}\na marca do carro e:: {marca}\nO preço e: R$ {preco}");
        }

    }

    class vendedor
    {
        public System.String nome;
        public int idade;

//construtor 
        public vendedor(System.String nome_vendedor, int idade_vendedor)
        {
            nome = nome_vendedor;
            idade = idade_vendedor;
        }
    }
}
