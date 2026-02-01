
namespace This;

class Program
{
    /*
    O operador this permite-nos distinguir valores com o mesmo escopo diferentes.

    Por exemplo os parametros de um método dos valores de uma classe com o mesmo nome.
    */
    static void Main(string[] args)
    {
        System.Console.Write("digite o titulo do livro:\n->");
        System.String titulo_livro = System.Console.ReadLine().Trim().ToLower();
        System.Console.Write("digite o nome do autor:\n->");
        System.String autor_livro = System.Console.ReadLine().Trim().ToLower();
        Livros livro_1 = new Livros(titulo_livro ,autor_livro);
        livro_1.exibir_dados(livro_1.titulo, livro_1.autor);
        
    }
}

class Livros
{
    public System.String titulo, autor;

    public Livros(System.String titulo, System.String autor)
    {
        //This -> faz referencia á classe
        this.titulo = titulo;
        this.autor = autor;
    }
    
    public void exibir_dados(System.String titulo, System.String autor)
    {
        System.Console.WriteLine($"titulo do livro: {titulo}\nautor do livro: {autor}");
    }

}
