namespace Namespaces{//diretório

    class Program //nome do arquivo
    {
    /*
    Um namespace é um espaço no código que armazena qualquer tipo de dado.
    Utilizado para criar espaços e organizae o código.
    Possui escopo.

    funcoes do namespace
    Organiza o código
    Evita conflito de nomes
    Define escopo
    Permite ter classes com o mesmo nome em lugares diferentes
    */
        static void Main(string[] args)//metodo principal
        {
            // Para usar uma classe que está em outro namespace,
            // é necessário escrever:
            // nome_do_namespace.NomeDaClasse

            // Exemplo:
            Outro.Principal obj = new Outro.Principal();
        }
    }
}

namespace Outro
{
    //posso ter o nome das classes iguais pois eles não estão no mesmo escopo
    class Principal 
    {
        public int n1;
    }
}