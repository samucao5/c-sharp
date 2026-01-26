namespace eletrica_v2;

class Program
{
    static void Main(string[] args)
    {
         while (true)
        {
            System.Console.Write("1 - calcular a resistencia\n2 - calcular a corrente\n3 - calcular a tensao\n4 - resistencia em serie\n5 - resistencia em paralelo\n6 - sair do programa\n");
            System.Console.Write("qual formula voce deseja calcular:\n->");
            int opcao = int.Parse((System.Console.ReadLine()).Trim());

            if (opcao == 1)
            {
                while (true)
                {
                    System.Console.Clear();
                    System.Console.Write("digite a tensão do circuito:\n->");
                    double tensao = double.Parse((System.Console.ReadLine()).Trim());
                    System.Console.Write("digite a corrente do circuito:\n->");
                    double corrente = double.Parse((System.Console.ReadLine()).Trim());
                    double resultado = (tensao / corrente);
                    System.Console.WriteLine($"R = {tensao}/{corrente} = {resultado} ohm");
                    System.Console.Write("continuar calculando:\ndigite sim ou não\n->");
                    System.String opcao_2 = (System.Console.ReadLine().Trim().ToLower());
                    if (opcao_2 == "sim")
                    {

                    }
                    else if (opcao_2 == "nao" || opcao_2 == "não")
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("finalizando as contas");
                        break;
                    }
                    else
                    {

                    }
                }

            }

            else if (opcao == 2)
            {
                while (true)
                {
                    System.Console.Clear();
                    System.Console.Write("digite a tensão do circuito:\n->");
                    double tensao = double.Parse((System.Console.ReadLine()).Trim());
                    System.Console.Write("digite a resistencia do circuito:\n->");
                    double resistencia = double.Parse((System.Console.ReadLine()).Trim());
                    double resultado = (tensao / resistencia);
                    System.Console.WriteLine($"I = {tensao}/{resistencia} = {resultado} A");

                    System.Console.Write("Continuar calculando:\ndigite sim ou nao\n->");
                    System.String opcao_2 = (System.Console.ReadLine().Trim().ToLower());
                    if (opcao_2 == "sim")
                    {

                    }
                    else if (opcao_2 == "nao" || opcao_2 == "não")
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("opção não encontrada");
                    }
                }

            }
            else if (opcao == 3)
            {
                while (true)
                {
                    System.Console.Clear();
                    System.Console.Write("digite a corrente do circuito:\n->");
                    double corrente = double.Parse((System.Console.ReadLine()).Trim());
                    System.Console.Write("digite a resistencia do circuito:\n->");
                    double resistencia = double.Parse((System.Console.ReadLine()).Trim());
                    double resultado = (corrente * resistencia);
                    System.Console.WriteLine($"V = {corrente} * {resistencia} = {resultado} ohm");
                    System.Console.Write("Continuar calculando:\ndigite sim ou nao\n->");
                    System.String opcao_2 = (System.Console.ReadLine().Trim().ToLower());
                    if (opcao_2 == "sim")
                    {

                    }
                    else if (opcao_2 == "nao" || opcao_2 == "não")
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("finalizando as contas");
                        break;
                    }
                    else
                    {

                    }

                }
            }
            else if (opcao == 4)
            {
                while (true)
                {
                    System.Console.Clear();
                    double resultado = 0;
                    System.Console.Write("digite a quantidade de resistores:\n->");
                    int quantidade_res = int.Parse(System.Console.ReadLine().Trim());
                    double[] resistores = new double[quantidade_res];

                    for (int i = 0; i < quantidade_res; i++)
                    {
                        System.Console.Clear();
                        System.Console.Write($"digite o resistor{i + 1}:\n->");
                        resistores[i] = int.Parse(System.Console.ReadLine());
                        resultado = resultado + resistores[i];
                    }
                    System.Console.WriteLine($"a soma dos resistores e:{resultado} ohm");

                    System.Console.Write("Continuar calculando:\ndigite sim ou nao\n->");
                    System.String opcao_2 = (System.Console.ReadLine().Trim().ToLower());
                    if (opcao_2 == "sim")
                    {

                    }
                    else if (opcao_2 == "nao" || opcao_2 == "não")
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("finalizando as contas");
                        break;

                    }
                    else
                    {

                    }



                }
            }
            else if (opcao == 5)
            {
                while (true)
                {
                    System.Console.Clear();
                    double resultado = 0;
                    double resistencia_1, resistencia_2;
                    System.Console.Write("digite a resistencia_1:\n->");
                    resistencia_1 = double.Parse(System.Console.ReadLine().Trim());
                    System.Console.Write("digite a resistencia_2:\n->");
                    resistencia_2 = double.Parse(System.Console.ReadLine().Trim());
                    resultado = (resistencia_1 * resistencia_2) / (resistencia_1 + resistencia_2);
                    System.Console.WriteLine($"({resistencia_1} * {resistencia_2})/({resistencia_1} + {resistencia_2}) = {resultado}");
                    System.Console.Write("Continuar calculando:\ndigite sim ou nao\n->");
                    System.String opcao_2 = (System.Console.ReadLine().Trim().ToLower());
                    if (opcao_2 == "sim")
                    {

                    }
                    else if (opcao_2 == "nao" || opcao_2 == "não")
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("finalizando as contas");
                        break;

                    }
                    else
                    {

                    }
                }
            }
            else if (opcao == 6)
            {
                System.Console.Clear();
                System.Console.WriteLine("saindo do programa");
                System.Console.Write(".");
                System.Console.Write(".");
                System.Console.Write(".");
                System.Console.Write(".");
                break;

            }
            else
            {
                System.Console.WriteLine("opção não encontrada");
            }

        }
    }
}
