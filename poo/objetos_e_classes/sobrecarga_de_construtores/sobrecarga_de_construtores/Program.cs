namespace sobrecarga_de_construtores;

class Program
{
    /*
    A sobrecarga de construtores dá-se quando uma classe possui mais de um construtor.
    Parra uma classe possuir mais de um construtor é necessário uma alteração no número de paramentros
    */
    static void Main(string[] args)
    {
    //inserindo somente o nome
        produto produto_1 = new produto("banana");
        produto_1.exibir_produtos(produto_1.nome_produto, produto_1.quantidade_produto, produto_1.preco_produto);
    //inserindo somente a quantidade
        produto produto_2 = new produto(1);
        produto_2.exibir_produtos(produto_2.nome_produto, produto_2.quantidade_produto, produto_2.preco_produto);
    //inserindo somente o preco
        produto produto_3 = new produto(5.34);
        produto_3.exibir_produtos(produto_3.nome_produto, produto_3.quantidade_produto, produto_3.preco_produto);
    //inserindo os 3 dados 
        produto produto_4 = new produto("banana",1, 5.43);
        produto_4.exibir_produtos(produto_4.nome_produto, produto_4.quantidade_produto, produto_4.preco_produto);

    }
}

    class produto
    {
        public System.String nome_produto = "sem nome";
        public int quantidade_produto = 0;
        public double preco_produto = 0;

        public produto(System.String nome)
        {
            nome_produto = nome;
            quantidade_produto = 0;
            preco_produto = 0;
        }

        public produto(int quantidade)
        {
            nome_produto = "sem nome";
            quantidade_produto = quantidade;
            preco_produto = 0;
        }

        public produto(double preco)
        {
            nome_produto = "sem nome";
            quantidade_produto = 0;
            preco_produto = preco;
        }

        public produto(System.String nome, int quantidade, double preco)
        {
            nome_produto = nome;
            quantidade_produto = quantidade;
            preco_produto = preco;
        }

        public void exibir_produtos(System.String nome_produto, int quantidade_produto, double preco_produto )
        {
            System.Console.WriteLine($"nome do produto: {nome_produto}\nquantidade no estoque:{quantidade_produto}\npreco do produto:R$ {preco_produto}\n");
        }
    }

