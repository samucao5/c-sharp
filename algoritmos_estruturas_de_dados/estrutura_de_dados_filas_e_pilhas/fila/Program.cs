namespace fila;
using System.Collections.Generic;
class Program
{
    /*
    Fila (Queue)

    Estrutura de dados que segue o princípio FIFO

    Primeiro elemento inserido é o primeiro a ser removido

    using System.Collections.Generic;
    Queue<int> fila = new Queue<int>();
    metodos

    Adiciona um elemento ao final da fila
    Enqueue();

    Remove e retorna o elemento no inicio da fila
    Dequeue();

    Retorna o elemento no início da fila sem removê-lo
    peek();

    Remove todos os elementos da fila
    Clear();

    Propriedade que retorna o número de elementos na fila
    Count
    */
    static void Main(string[] args)
    {
        Queue<int> Fila = new Queue<int>();
        Fila.Enqueue(10);
        Fila.Enqueue(20);
        Fila.Enqueue(30);
        Fila.Dequeue();

        foreach (var item in Fila)
        {
            System.Console.WriteLine(item);
        }
    }
}
