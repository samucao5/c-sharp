namespace Grafos;

class Program
{
    /*
    Estrutura de dados não lineares onde os dados se encontram interligados de diferentes formas

    Tipos de Grafos:
    Directed Graph
    Undirected Graph
    Weighted Graph
    Cyclic Graph
    Acyclic Graph
    */
    static void Main(string[] args)
    {
        Grafo grafo = new Grafo(4);
        grafo.AdicionarAresta(0,2);
        grafo.AdicionarAresta(1,2);
        grafo.AdicionarAresta(2,3);
        grafo.AdicionarAresta(1,3);
        grafo.AdicionarAresta(2,3);
        grafo.AdicionarAresta(3,2);
        grafo.Mostrar();
    }
}

class Grafo
{
    public int numVertices;
    public Dictionary<int,List<int>> adj;
    public Grafo(int vertices)
    {
        numVertices = vertices;
        adj = new Dictionary<int, List<int>>();
    
        for(int i = 0; i < numVertices; i++ )
        {
            adj[i] = new List<int>();
        }
    }

    public void AdicionarAresta(int org, int dest)
    {
        adj[org].Add(dest);
    }

    public void Mostrar()
    {
        foreach (var vertice in adj)
        {
            System.Console.Write($"o vertice {vertice.Key} esta ligado aos vertices: ");
            foreach(var vertice2 in vertice.Value)
            {
                System.Console.Write(vertice2+" ");
            }
            System.Console.WriteLine();
        }
    }
}
