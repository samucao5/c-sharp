namespace arvores;
using System.Collections.Generic;
class Program
{
    /*
    Estrutura de dados não linear onde os dados se encontram de forma hierárquica

    tipos de árvores:
    General Tree
    Binary Tree
    Binary Seach Tree
    AVL Tree
    Red Black Tree

    aplicações
    Machine Learning
    Banco De Dados
    DNS
    Explorador de Arquivos
    */
    static void Main(string[] args)
    {
        Arvore<int> tree = new Arvore<int>(1);

        tree.AddFilho(tree.Raiz, 2);
        tree.AddFilho(tree.Raiz, 3);

        TreeNode<int> no2 = tree.Raiz.Filhos[0];
        tree.AddFilho(no2,4);
        tree.AddFilho(no2,5);

        tree.percorrer(tree.Raiz);
    }
}

class TreeNode<T>
{
    public T Valor;
    public List <TreeNode<T>> Filhos;
    public TreeNode(T valor)
    {
      Valor = valor;
      Filhos = new List<TreeNode<T>>();  
    }

}

class Arvore<T>
{
    public TreeNode<T> Raiz;
    public Arvore(T valorRaiz)
    {
        Raiz = new TreeNode<T>(valorRaiz);
    }

    //adicionar Filho
    public void AddFilho(TreeNode<T> pai, T valorFilho)
    {
        pai.Filhos.Add(new TreeNode<T>(valorFilho));
    }
    
    //percorrer a estrutura
    public void percorrer(TreeNode<T> no)
    {
        if(no != null)
        {
            System.Console.WriteLine(no.Valor);
            foreach(var filho in no.Filhos)
            {
                percorrer(filho);
            }
        }
    }
}
