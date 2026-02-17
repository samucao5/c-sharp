using System.Runtime.InteropServices;

namespace so_obtendo_informacoes;

class Program
{
    /*
    É possível trabalhar com sistema operativo em C# com a OperatingSystem Class

    É possivel obter diversos valores, e verificar o sistema.
    */
    static void Main(string[] args)
    {
        //coloca dentro da variavel os, o seu sistema operacional
        var os = System.Environment.OSVersion;
        //retorna a platarforma 
        System.Console.WriteLine(os.Platform);
        System.Console.WriteLine(os.Version.Major);
        System.Console.WriteLine(os.Version.Minor);
        System.Console.WriteLine(os.ServicePack);
        //caso queira todas as informações e um linha de codigo
        System.Console.WriteLine(os.VersionString);
    }
}
