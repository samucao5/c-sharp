namespace ex_6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Digite a cordenada de x1: \n-> ");
        int x1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Digite a cordenada de y1: \n->");
        int y1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Digite a cordenada de x2: \n->");
        int x2 = int.Parse(System.Console.ReadLine());
        System.Console.Write("digite a cordenada de y2:\n->");
        int y2 = int.Parse(System.Console.ReadLine());

        int distancia_x = x1 - x2;
        int distancia_y = y1 - y2;

        System.Console.WriteLine($"a diferença entre o ponto x1: {x1} e o ponto x2: {x2} e de {distancia_x}");
        System.Console.WriteLine($"a diferença entre o ponto y1: {y1} e o ponto y2: {y2} e de {distancia_y}");
    }
}


