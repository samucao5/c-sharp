namespace dados_inteiros;

class Program
{

    /*
    numeros Inteiros:
    
    short -32.768 a 32.767 16 bits
    ushort 0 a 65.535 16 bits
    int -2.147.483.648 a 2.147.483.647 32 bits
    uint 0 a 4.294.967.295 32 bits
    long 9.223.372.036.854.775.909 a 9.223.372.036.854.775.807 64 bits
    ulong 0 a 18.446.774.073.709.551.615 64 bits

    20u = valor inteiro sem sinal negativo
    20l = valor inteiro long
    20ul = valor inteiro long sem sinal negativo
    
    
    
    */
    static void Main(string[] args)
    {
        short num1 = 35;
        int num2 = 200;
        long num3 = 10l;

        uint num4 = 232u;
        ulong num5 = 50ul;
        ushort num6 = 30;

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        Console.WriteLine(num4);
        Console.WriteLine(num5);
        Console.WriteLine(num6);

        int tamanho_int = sizeof(int); //retorno (bytes)
        //32 bits = 4 bytes (1 byte = 8 bits)
        Console.WriteLine(tamanho_int);
    }
}
