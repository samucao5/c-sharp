namespace numericos_decimais;

class Program
{

    /*
    float   ±1.5 x 10−45 to ±3.4 x 1038 	~6-9 digits 	4 bytes
    double 	±5.0 × 10−324 to ±1.7 × 10308 	~15-17 digits 	8 bytes
    decimal ±1.0 x 10-28 to ±7.9228 x 1028 	28-29 digits 	16 bytes
    */
    static void Main(string[] args)
    {   
        //tem que colocar o sufico f no final
        float num1 = 1.55f;
        double temperatura = 34.3;
        //tem que colocar o sufixo m no final 
        decimal pi = 3.1415926535897932384m;
        
        Console.WriteLine(num1);
        Console.WriteLine(temperatura);
        Console.WriteLine(pi);
    }
}
