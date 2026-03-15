namespace Iterator;
using System.Collections.Generic;

class Livro
{
    public System.String Titulo{get; set;}
    public System.String Autor{get; set;}
    
    public Livro(System.String titulo, System.String autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public override System.String ToString()
    {
        return $"titulo do livro: {Titulo}\nAutor: {Autor}\n";
    }
}

interface Iterator<T>
{
    bool TemProximo();

    T Proximo();
}

interface IAgregado<T>
{
    Iterator<T> CriarIterator();
}

class Livraria : IAgregado<Livro>
{
    private List<Livro> _Livro = new List<Livro>();

    public void AdicionarLivros(Livro livro)
    {
        _Livro.Add(livro);
    }

    public Iterator<Livro> CriarIterator()
    {
        return new LivrariaIterator(this);
    }

    public int Count
    {
        get{return _Livro.Count;}
    }

    public Livro this[int index]
    {
        get{return _Livro[index];}
    }
}

class LivrariaIterator : Iterator<Livro>
{
    private Livraria _livraria;

    private int _index;
    public LivrariaIterator( Livraria livraria)
    {
        _livraria = livraria;
        _index = 0;
    }

    public bool TemProximo()
    {
        return _index < _livraria.Count;
    }

    public Livro Proximo()
    {
        return _livraria[_index++];
    }
}



class Program
{
    static void Main(string[] args)
    {
        Livraria livraria = new Livraria();
        livraria.AdicionarLivros(new Livro("Eleanor & Park","Rainbow rowell"));
        livraria.AdicionarLivros(new Livro("it a coisa","Stephen king"));
        livraria.AdicionarLivros(new Livro("gato preto","edgar allan Poe"));

        Iterator<Livro> iterator = livraria.CriarIterator();

        while (iterator.TemProximo())
        {
            Livro livro = iterator.Proximo();
            System.Console.WriteLine(livro);
        }
    }   
}
