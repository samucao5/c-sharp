namespace pilhas;
using System.Collections.Generic;

class Program
{
    /*
    princípios:
    LIFO -> LAST In, FIRST Out
    FIFO -> FIRST In, First Out
    
    Estruturas
    pilhas (Stack) -> LIFO
    Fila (Queue) -> FIFO

    Pilhas (stack)
    Estrutura de dados que segue o principio de LIFO
    Ultimo elemento inserido é o primeiro a ser removido

    using System.Collection.Generic;

    Stack <int> pilha = new Stack<int>();

    metodos

    Adiciona um elemento ao topo da pilha
    Push(); 

    Remove e retorna o elemento no topo da pilha
    Pop();

    Retorna o elemento no topo da pilha sem removê-lo
    Peek();

    Remove todos os elementos da pilha
    Clear();

    Numero de elementos na pilha
    Count;
    */
    static void Main(string[] args)
    {
        Stack<int> pilha = new Stack<int>();
        pilha.Push(10);
        pilha.Push(20);
        pilha.Push(30);
        //remove o dados que esta no topo
        pilha.Pop();
        foreach(var item in pilha)
        {
            System.Console.WriteLine(item);
        }
    }
}
