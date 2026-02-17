namespace so_verificando_o_sistema;
using System.Runtime.InteropServices;
class Program
{
    /*
    É possível trabalhar com o sistema operativo em C# com a OperatingSystemClass

    É possível obter diversos valores, e verificar o sistema
    
    obs: vai precisar chamar um classe
    using System.Runtime.InteropServices;
    */
    static void Main(string[] args)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            System.Console.WriteLine("o sistema operacional e um Windows");
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            System.Console.WriteLine("o sistema operacional e um Linux");
        }
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            System.Console.WriteLine("o sistema operacional e um Mac");
        }
        else
        {
            System.Console.WriteLine("sistema operacional não encontrado");
        }
    }
}
