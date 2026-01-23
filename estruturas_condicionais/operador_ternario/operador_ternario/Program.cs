namespace operador_ternario;

class Program
{
    /*
    operador Ternario (?):
    operador que ultiliza 3 argumentos

    sintaxe condição ? expressão1 : expressão2;

    funcionamento:
    Resultado verdadeiro -> retorna a expressão 1
    Resultado falso -> retorna a expressão 2
    
    */
    static void Main(string[] args)
    {
        System.Console.Write("digite seu nome de usuario: ");
        System.String usuario =(System.Console.ReadLine()).Trim();

        usuario = System.String.IsNullOrEmpty(usuario) ? "user555" : usuario;
        System.Console.WriteLine($"seu de usuario e: {usuario}");
        
    }
}
