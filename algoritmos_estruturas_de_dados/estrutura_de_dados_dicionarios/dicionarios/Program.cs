namespace dicionarios;
using System.Collections.Generic;
class Program
{
    /*
    Dicionários são estruturas de dados que armazenam dados no formato de chave-valor

    cada dado(valor) possui uma chave que o identifica e permite que o mesmo seja acessado

    "Nome" -> "Pedro"
    "valor" -> 200
    using System.Collections.Generic;
    Dictionary<int, System.String> nome = new Dictionary<int, System.String>();

    nome[chave] = valor;
    nome.Add(chave,valor);

    metodos
    adiciona um par chave → valor ao dicionário.
    nome.Add(chave,valor);

    remove o item com a chave informada.
    nome.Remove(chave);

    verifica se a chave existe (true/false).
    nome.ContainsKey(chave);

    verifica se o valor existe (true/false).
    nome.ContainsValue(valor);

    remove todos os elementos do dicionário.
    nome.Clear();

    retorna a quantidade de pares chave → valor.
    nome.Count;
    */


    static void Main(string[] args)
    {
        Dictionary<System.String, System.String> dic1 = new Dictionary<System.String, System.String>()
        {
            //caso queira colocar os dados de maneira direta
            {"marca", "ford"}, {"time","flamengo"}

        };
        // nome -> pedro
        dic1.Add("nome","samuel");
        dic1.Add("pais","Brasil");
        System.Console.WriteLine(dic1["nome"]);
        System.Console.WriteLine(dic1["pais"]);

        foreach(KeyValuePair<System.String, System.String> item in dic1)
        {
            System.Console.WriteLine($"chaves: {item.Key} valores:{item.Value}");
        }
    }
}
