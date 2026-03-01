namespace Composite;

interface IComponente
{
    void Exibir(int prof);
}

class Folha : IComponente
{
    private System.String nome;
    public Folha(System.String nome)
    {
        this.nome = nome;
    }

    public void Exibir(int prof)
    {
        System.Console.WriteLine(new System.String('-',prof)+nome);
    }
}

class Composto : IComponente
{
    public System.String nome;
    private List<IComponente> filhos = new List<IComponente>();

    public Composto(System.String nome)
    {
        this.nome = nome;
    }

    public void Adicionar(IComponente comp)
    {
        filhos.Add(comp);
    }

    public void Remover(IComponente comp)
    {
        filhos.Remove(comp);
    }

    public void Exibir(int prof)
    {
        System.Console.WriteLine(new System.String('-', prof)+nome);
        foreach (var filho in filhos)
        {
            filho.Exibir(prof+2);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Composto raiz = new Composto("Raiz");
        raiz.Adicionar(new Folha("Folha1"));
        raiz.Adicionar(new Folha("Folha2"));

        Composto outro = new Composto("Outro");
        outro.Adicionar(new Folha("Outro1"));
        outro.Adicionar(new Folha("Outro2"));

        raiz.Adicionar(outro);
        raiz.Adicionar(new Folha("Folha3"));

        Folha folha = new Folha("folha4");
        raiz.Adicionar(folha);

        raiz.Remover(folha);
        raiz.Exibir(1);
    }
}
