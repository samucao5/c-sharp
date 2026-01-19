namespace ex_5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("digite alguma hora: \n->");
        System.String teste = (System.Console.ReadLine()).Trim();
        double hora = double.Parse(teste);
        
        int minutos = (int)(hora * 60);
        int segundos = (int)(hora * 3600);

        System.Console.WriteLine($"Horas digitadas: {hora}");
        System.Console.WriteLine($"em minutos: {minutos}");
        System.Console.WriteLine($"em segundos: {segundos}");
    }
}
