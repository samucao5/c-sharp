namespace arvore_de_pesquisa_binaria;

class Program
{
    static void Main(string[] args)
    {
        ArvoreBinaria tree = new ArvoreBinaria();
        tree.inserir(10);
        tree.inserir(20);
        tree.inserir(55);
        tree.inserir(11);
        tree.inserir(43);
        tree.inserir(12);
        tree.inserir(34);

        tree.iniciar();
        
    }

}

class Node
{
    public int valor;
    public Node esq, dir;

    public Node(int v)
    {
        valor = v;
        esq = dir = null;
    }
}

class ArvoreBinaria
{
    public Node raiz;

    public ArvoreBinaria()
    {
        raiz = null;
    }

    public void inserir(int val)
    {
        raiz = Adicionar(raiz,val);
    }



    //adicionar elementos
    public Node Adicionar(Node raiz, int valor)
    {
        if(raiz == null)
        {
            raiz = new Node(valor);
            return raiz;
        }
        if(valor < raiz.valor)
        {
            raiz.esq = Adicionar(raiz.esq, valor);
        }
        else if(valor > raiz.valor)
        {
            raiz.dir = Adicionar(raiz.dir, valor);    
        }
        return raiz;
    }

    public void Percorrer(Node raiz)
    {
        if(raiz!=null){
        Percorrer(raiz.esq);
        System.Console.Write(raiz.valor+" ");
        Percorrer(raiz.dir);
        //esquerda → raiz → direita
        }
    }

    public void iniciar()
    {
        Percorrer(raiz);
    }
}
