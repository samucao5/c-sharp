namespace lista_encadeadas;

class Program
{
/*
LinkedList
Uma lista de forma sequencial

Os dados são armazenados com informações sobre os dados ao seu redor

using System.Collections.Generic;
Linked <int> nome = new LinkedList<int>();

metodos

adiciona um elemento no início da lista.
nome.AddFirst(valor);

remove o primeiro elemento da lista.
nome.RemoveFirst();

adiciona um elemento no final da lista.
nome.AddLast(valor);

remove o último elemento da lista.
nome.RemoveLast();

adiciona um elemento depois de um nó específico.
nome.AddAfter(no, valor);

adiciona um elemento antes de um nó específico.
nome.AddBefore(no, valor);
*/
    static void Main(string[] args)
    {
        LinkedList<int> Lista1 = new LinkedList<int>();
        Lista1.AddFirst(10);
        Lista1.AddFirst(20);
        Lista1.AddLast(55);
        Lista1.RemoveFirst();
        Lista1.Clear();
        
        Lista1.AddFirst(30);
        Lista1.AddFirst(20);
        Lista1.AddFirst(10);

        LinkedListNode<int> no;
        no = Lista1.FindLast(20);
        Lista1.AddAfter(no, 50);

        foreach(var item in Lista1)
        {
            Console.WriteLine(item);
        }
    }
}
