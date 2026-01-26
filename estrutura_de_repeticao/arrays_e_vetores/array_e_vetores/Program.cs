namespace array_e_vetores;

class Program
{
    /*
    Array ou vetores são um dado que guarda varios dados.
    Basicamente gurada varios dados numa só estrutura ou "variavel"
    int[] numero = new int [3];
    
    */

    static void Main(string[] args)
    {   
        System.Console.Write("digite a quantidade de alunos que serão cadastrados:\n->");
        int numero = int.Parse(System.Console.ReadLine().Trim());


        System.String[] nome = new System.String[numero];
        int[] idade = new int[numero];
        int[] numero_turma = new int[numero];

        while (true)
        {
            System.String espaco = "***********************************************";
            System.Console.Write("1 - cadastra alunos\n2 - ver o cadastro dos alunos\n3 - sair\nescolha sua opção\n->");
            int opcao = int.Parse(System.Console.ReadLine().Trim());
            int i = 0;
            erro1:
            if(opcao == 1)
            {
                
                while(i < numero)
                {
                System.Console.Clear();
                System.Console.WriteLine($"criando aluno{i + 1}");
                System.Console.Write("digite o nome do aluno:\n->");
                nome[i] = System.Console.ReadLine().Trim().ToLower();
                System.Console.Write("digite a idade do aluno:\n->");
                idade[i] = int.Parse(System.Console.ReadLine().Trim());
                System.Console.Write("digite a turma do aluno:\n->");
                numero_turma[i] = int.Parse(System.Console.ReadLine().Trim());
                erro:
                System.Console.Write("sair do cadastro dos alunos:\n->");
                System.String opcao_2 = System.Console.ReadLine().Trim().ToLower();

                if(opcao_2 == "sim" || i == numero)
                {
                    break;
                }

                else if(opcao_2 == "não" || opcao_2 == "nao")
                    {
                    }
                else
                    {
                    System.Console.WriteLine("opcao não encontrada");
                    goto erro;
                    }
                    i++;
                    System.Console.Clear();
                }
                
            }
            else if(opcao == 2)
            {   
                
                System.Console.Clear();
                System.Console.WriteLine(espaco);
                System.Console.WriteLine("Alunos");
                for(int b = 0; b < numero; b++)
                {
                    System.Console.WriteLine($"nome:{nome[b]}\nidade:{idade[b]}\nturma:{numero_turma[b]}\n");
                }
                System.Console.WriteLine(espaco);
            }
            else if(opcao == 3)
            {
                break;
            }
            else
            {
                System.Console.Clear();
                System.Console.WriteLine("opção não encontrada digite novamente");
                goto erro1;
            }
            }
        }
    }
