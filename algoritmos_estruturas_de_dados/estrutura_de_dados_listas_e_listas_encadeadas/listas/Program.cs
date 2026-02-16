namespace listas;
using System.Collections.Generic;

class Program
{
    /*
    Uma lista funciona como um vetor tradicional mas dinâmico

    Possui métodos e operações não aplicadas a vetores

    //para usara a lista e necessario importa a biblioteca abaixo
    using System.Collection.Generic;

    List <int> nome = new List <int>();
    System.Console.WriteLine(nomee[0]);

    metodos

    adiciona um item no final da lista.
    nome.Add();

    remove a primeira ocorrência do valor "ola".
    nome.Remove("ola");

    insere "sushi" na posição 0 da lista.
    nome.Insert(0, "sushi");

    retorna a quantidade de elementos da lista.
    nome.Count;

    retorna o índice da primeira ocorrência do valor.
    nome.IndexOf(valor);

    verifica se o valor existe na lista (true/false).
    nome.Contains(valor);

    inverte a ordem dos elementos da lista.
    nome.Reverse();

    ordena a lista em ordem crescente.
    nome.Sort();

    remove todos os elementos da lista.
    nome.clear();
    */
    static void Main(string[] args)
    {
        List<System.String> Nomes = new List<System.String>(/*serve para importar dados de vetores ou matrizes*/);
        Nomes.Add("samuel");
        Nomes.Add("mar");
        Nomes.Insert(1,"maria");
        System.Console.WriteLine($"quantidade de nomes:{Nomes.Count}");
        foreach(var item in Nomes)
        {
            System.Console.WriteLine(item);
        }

        System.Console.Write("digite o nome do usuario:\n->");
        System.String nome_busca = System.Console.ReadLine().Trim().ToLower();
        //.Contains(valor_procurado): verifica se existe esse valor na lista
        if(Nomes.Contains(nome_busca) == true)
        {
            System.Console.WriteLine($"este valor existe na lista: esta na Lista[{Nomes.IndexOf(nome_busca)}]");
        }
        else
        {
            System.Console.WriteLine("este nome não foi encontrado");
        }

    }
}
