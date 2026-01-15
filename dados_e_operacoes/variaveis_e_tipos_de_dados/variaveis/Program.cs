using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

namespace variaveis;

class Program
{
    static void Main(string[] args)
    {
        //variavel numero inteiro
        int idade = 19;
        // variavel de texto
        string nome = "Samuel";
        //variavel booleana true
        bool verdadeiro = true;
        //variavel booleana false
        bool falso = false;
        //var: identifica o tipo sem voce determinar
        var sobrenome = "Felipe";

        Console.WriteLine(nome);
        Console.WriteLine(idade);
        Console.WriteLine(verdadeiro);
        Console.WriteLine(falso);
        Console.WriteLine(sobrenome);
    }
}
