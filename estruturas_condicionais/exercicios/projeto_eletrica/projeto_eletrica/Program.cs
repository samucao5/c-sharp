namespace projeto_eletrica;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("1 - calcular a resistencia\n2 - calcular a corrente\n3 - calcular a tensao\n4 - resistencia equivalente \n");
        System.Console.Write("qual formula voce deseja calcular:\n->");
        int opcao = int.Parse((System.Console.ReadLine()).Trim());

        if (opcao == 1)
        {
            System.Console.Write("digite a tensão do circuito:\n->");
            double tensao = double.Parse((System.Console.ReadLine()).Trim());
            System.Console.Write("digite a corrente do circuito:\n->");
            double corrente = double.Parse((System.Console.ReadLine()).Trim());
            double resultado = (tensao / corrente);
            System.Console.WriteLine($"R = {tensao}/{corrente} = {resultado} ohm");
        }
        else if (opcao == 2)
        {
            System.Console.Write("digite a tensão do circuito:\n->");
            double tensao = double.Parse((System.Console.ReadLine()).Trim());
            System.Console.Write("digite a resistencia do circuito:\n->");
            double resistencia = double.Parse((System.Console.ReadLine()).Trim());
            double resultado = (tensao / resistencia);
            System.Console.WriteLine($"I = {tensao}/{resistencia} = {resultado} A");
        }
        else if (opcao == 3)
        {
            System.Console.Write("digite a corrente do circuito:\n->");
            double corrente = double.Parse((System.Console.ReadLine()).Trim());
            System.Console.Write("digite a resistencia do circuito:\n->");
            double resistencia = double.Parse((System.Console.ReadLine()).Trim());
            double resultado = (corrente * resistencia);
            System.Console.WriteLine($"V = {corrente} * {resistencia} = {resultado} V");
        }
        else if (opcao == 4)
        {
            System.Console.Write("digite a r1:\n->");
            double r1 = double.Parse((System.Console.ReadLine()).Trim());
            System.Console.Write("digite a r2:\n->");
            double r2 = double.Parse((System.Console.ReadLine()).Trim());
            double resultado = (r1 * r2) / (r1 + r2);
            System.Console.WriteLine($"({r1} * {r2}) / ({r1} + {r2}) = {resultado} ohm");
        }
        else
        {
            System.Console.WriteLine("opção não encontrada");
        }
    }
}
